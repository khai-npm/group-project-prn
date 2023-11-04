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
    public partial class frmAddBlog : Form
    {
        public string AddPostSession { get; set; }
        IBlogrepository AddPostrepository = new Blogrepository();
        public frmAddBlog()
        {
            InitializeComponent();
        }

        private void frmAddBlog_Load(object sender, EventArgs e)
        {
            txtUser.Text = AddPostSession;
        }

        private void btnPostBlog_Click(object sender, EventArgs e)
        {
            Boolean flag = true;
            List<Post> numberOfPosts = AddPostrepository.GetPostList();
            TblUser user = AddPostrepository.GetbyUserName(AddPostSession);
            int currentId = numberOfPosts.Count;
            do
            {
                if (AddPostrepository.GetbyPostID(currentId) != null)
                {
                    currentId = currentId + 1;
                    flag = false;
                }
            }
            while (flag = false);
            Post addBlog = new Post();
           // {
           //     PostId = currentId,
           //     Approve = 1,
          //      ApproveTime = null,
         //       AppovedBy = null,
         //       PostAuthor = txtUser.Text,
         //       Award = 1,
         //       PostCategoryId=1,
         //       PostComment=null,
         //       Image=null,
         //       PostContent = txtContent.Text,
         //       Status=1,
         //       PostSubjectId=null,
         //       PostTagId=null,
          //      Title = txtTitle.Text,   
         //       UserId = user.UserId,
         //     SubjectId=null,
         //       CategoryId=null,
        //    };
                string author = txtUser.Text;
                 string title = txtTitle.Text;
                string content = txtContent.Text;

                addBlog.PostId = currentId;
               addBlog.PostAuthor = author;
               addBlog.Title = title;
               addBlog.PostContent = content;
                AddPostrepository.AddNewPost(addBlog);

            this.Close();
        }
    }
}
