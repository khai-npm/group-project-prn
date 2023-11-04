using BusinessObjects;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmBlogDetail : Form
    {
        public string userPostSession { get; set; }
        public IBlogrepository Postrepository { get; set; }
        public Post PostInfor { get; set; }
        public frmBlogDetail()
        {
            InitializeComponent();
        }

        private void loadCommentList()
        {
            try
            {
                var customerList = Postrepository.GetbyPostId(PostInfor.PostId).Select(p => new { p.Author, p.Context })
            .ToList();
                BindingSource source = new BindingSource();
                source.DataSource = customerList;

                //           txtUserID.DataBindings.Clear();
                //          txtUserID.DataBindings.Add("Text", source, "UserId");
              
                dgvComment.DataSource = null;
                dgvComment.DataSource = source;

                DataGridViewColumn column = dgvComment.Columns[1];
                column.Width = 500;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No Comment right now!");
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmBlogDetail_Load(object sender, EventArgs e)
        {
            loadCommentList();
            txtAuthor.Text = PostInfor.PostAuthor;
            txtTitle.Text = PostInfor.Title;
            txtContent.Text = PostInfor.PostContent;
            if (PostInfor.PostAuthor.Equals(userPostSession, StringComparison.InvariantCultureIgnoreCase))
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                txtTitle.ReadOnly = false;
                txtContent.ReadOnly = false;
            }
            else
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                txtTitle.ReadOnly = true;
                txtContent.ReadOnly = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to delete this post?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                MessageBox.Show("Delete Complete");
                //      Post post = Postrepository;
                Postrepository.DeletePost(PostInfor);
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to update this post?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                string Newtitle = txtTitle.Text;
                string Newcontent = txtContent.Text;
                PostInfor.Title = Newtitle;
                PostInfor.PostContent = Newcontent;
                Postrepository.UpdatePost(PostInfor);
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2() { user = userPostSession, postId = PostInfor.PostId };
            a.ShowDialog();

        }

        private void btnRefeshComment_Click(object sender, EventArgs e)
        {
            loadCommentList();
        }
    }
}
