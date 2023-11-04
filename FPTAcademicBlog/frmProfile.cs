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
    public partial class frmProfile : Form
    {
        public TblUser userProfile { get; set; }
        public IBlogrepository profileRepository { get; set; }

        public frmProfile()
        {
            InitializeComponent();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            txtUsername.Text = userProfile.UserName;
            txtUserId.Text = userProfile.UserId;
            txtRoleId.Text = userProfile.RoleId;
            txtDescription.Text = userProfile.Description;
            txtBirthdate.Text = userProfile.Birthdate;
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            TblUser userAccountInfo = new TblUser()
            {
                UserName = txtUsername.Text,
                Password = userProfile.Password,
                NumberOfPosts = userProfile.NumberOfPosts,
                Major = userProfile.Major,
                Status = userProfile.Status,
                Award = userProfile.Award,
                UserId = txtUserId.Text,
                RoleId = txtRoleId.Text,
                Description = txtDescription.Text,
                Birthdate = txtBirthdate.Text,
                Image = userProfile.Image,
            };
            profileRepository.UpdateUser(userAccountInfo);
            MessageBox.Show("Edit Profile Ok !");
            this.Close();
        }
    }
}

