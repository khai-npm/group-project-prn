using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPTAcademicBlog
{
    public partial class frmHomePage : Form
    {
        public string userSession { get; set; }
        IBlogrepository repository = new Blogrepository();
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void loadUserList()
        {
            try
            {
                var customerList = repository.GetPostList().Select(p => new { p.PostId, p.PostAuthor, p.Title, p.PostContent })
            .ToList();
                BindingSource source = new BindingSource();
                source.DataSource = customerList;

                //           txtUserID.DataBindings.Clear();
                //          txtUserID.DataBindings.Add("Text", source, "UserId");

                dgvPost.DataSource = null;
                dgvPost.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of customers");
            }
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            loadUserList();
            txtSessionName.Text = userSession;
        }

        private void dgvPost_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dgvPost.Rows[e.RowIndex];

                DataGridViewRow selectedRow = dgvPost.Rows[e.RowIndex];

                object postAuthor = selectedRow.Cells["PostAuthor"].Value;
                object title = selectedRow.Cells["Title"].Value;
                object postContent = selectedRow.Cells["PostContent"].Value;
                object postId = selectedRow.Cells["PostId"].Value;

                Post postDetail = new Post()
                {
                    PostAuthor = postAuthor?.ToString(),
                    Title = title?.ToString(),
                    PostContent = postContent?.ToString(),
                    PostId = int.Parse(postId?.ToString()),
                };


                frmBlogDetail frmBlogDetail = new frmBlogDetail()
                {
                    Postrepository = repository,
                    PostInfor = postDetail,
                    userPostSession = txtSessionName.Text,
                };
                frmBlogDetail.ShowDialog();

            }
        }

        private void btnOwnDelete_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadUserList();
        }

        private void btnAddBlog_Click(object sender, EventArgs e)
        {
            frmAddBlog frmAddBlog = new frmAddBlog()
            {
                //             AddPostrepository = repository,
                AddPostSession = txtSessionName.Text,
            };
            frmAddBlog.ShowDialog();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            TblUser user = repository.GetbyUserName(userSession);
            frmProfile frmProfile = new frmProfile()
            {
                userProfile = user,
                profileRepository = repository,
            };
            frmProfile.ShowDialog();
        }

        private void dgvPost_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var keyword = txtSearchBar.Text;
            var searchName = repository.GetbyKeyWord(keyword).Select(p => new { p.PostId, p.PostAuthor, p.Title, p.PostContent })
            .ToList();
            if (searchName != null)
            {
                BindingSource source = new BindingSource();
                source.DataSource = searchName;
                dgvPost.DataSource = null;
                dgvPost.DataSource = source;
            }
        }
    }
}
