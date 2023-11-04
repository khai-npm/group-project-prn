namespace FPTAcademicBlog
{
    partial class frmProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            txtUserId = new System.Windows.Forms.TextBox();
            txtRoleId = new System.Windows.Forms.TextBox();
            txtBirthdate = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();
            btnEditProfile = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(91, 124);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 35);
            label1.TabIndex = 0;
            label1.Text = "UserID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(119, 26);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(176, 46);
            label2.TabIndex = 1;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(92, 185);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(85, 35);
            label3.TabIndex = 2;
            label3.Text = "RoleId";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(91, 246);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(115, 35);
            label4.TabIndex = 3;
            label4.Text = "Birthdate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(91, 303);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(142, 35);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // txtUsername
            // 
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtUsername.Location = new System.Drawing.Point(292, 31);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new System.Drawing.Size(227, 41);
            txtUsername.TabIndex = 5;
            // 
            // txtUserId
            // 
            txtUserId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtUserId.Location = new System.Drawing.Point(243, 126);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtUserId.Size = new System.Drawing.Size(434, 34);
            txtUserId.TabIndex = 6;
            // 
            // txtRoleId
            // 
            txtRoleId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtRoleId.Location = new System.Drawing.Point(243, 187);
            txtRoleId.Name = "txtRoleId";
            txtRoleId.ReadOnly = true;
            txtRoleId.Size = new System.Drawing.Size(434, 34);
            txtRoleId.TabIndex = 7;
            // 
            // txtBirthdate
            // 
            txtBirthdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtBirthdate.Location = new System.Drawing.Point(243, 246);
            txtBirthdate.Name = "txtBirthdate";
            txtBirthdate.Size = new System.Drawing.Size(434, 34);
            txtBirthdate.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDescription.Location = new System.Drawing.Point(243, 305);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(434, 34);
            txtDescription.TabIndex = 9;
            // 
            // btnEditProfile
            // 
            btnEditProfile.Location = new System.Drawing.Point(292, 367);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new System.Drawing.Size(158, 48);
            btnEditProfile.TabIndex = 10;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = true;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnEditProfile);
            Controls.Add(txtDescription);
            Controls.Add(txtBirthdate);
            Controls.Add(txtRoleId);
            Controls.Add(txtUserId);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProfile";
            Text = "frmProfile";
            Load += frmProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtRoleId;
        private System.Windows.Forms.TextBox txtBirthdate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnEditProfile;
    }
}