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
    public partial class Form2 : Form
    {
        IBlogrepository _repository = new Blogrepository();
        public string user { get; set; }
        public int postId { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSubmitComment_Click(object sender, EventArgs e)
        {
            Boolean flag;
            int currentID = _repository.GetCommentList().Count;

           do
            {
                flag = false;
                if (_repository.GetCommentByID(currentID.ToString())!=null)
                {
                    currentID = currentID +1 ;
                    flag = true;
                }

            }while (flag==true);

            string NewComment = txtComment.Text;
            Comment comment = new Comment();
            comment.CommentId = currentID.ToString();
            comment.Author = user;
            comment.Context = txtComment.Text;
            comment.PostComment = postId;

            _repository.Add(comment);
            MessageBox.Show("comment added to " + postId);
            this.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtUserName.Text = user;
        }
    }
}
