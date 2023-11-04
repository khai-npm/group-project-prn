namespace FPTAcademicBlog
{
    partial class frmHomePage
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
            dgvPost = new System.Windows.Forms.DataGridView();
            txtSessionName = new System.Windows.Forms.TextBox();
            User = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            btnAddBlog = new System.Windows.Forms.Button();
            btnViewProfile = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txtSearchBar = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvPost).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(252, -6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(283, 67);
            label1.TabIndex = 0;
            label1.Text = "Home Page";
            // 
            // dgvPost
            // 
            dgvPost.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPost.Location = new System.Drawing.Point(-4, 211);
            dgvPost.Name = "dgvPost";
            dgvPost.ReadOnly = true;
            dgvPost.RowHeadersWidth = 51;
            dgvPost.RowTemplate.Height = 29;
            dgvPost.Size = new System.Drawing.Size(803, 359);
            dgvPost.TabIndex = 1;
            dgvPost.CellContentClick += dgvPost_CellContentClick;
            dgvPost.CellDoubleClick += dgvPost_CellDoubleClick;
            // 
            // txtSessionName
            // 
            txtSessionName.Location = new System.Drawing.Point(59, 25);
            txtSessionName.Name = "txtSessionName";
            txtSessionName.ReadOnly = true;
            txtSessionName.Size = new System.Drawing.Size(145, 27);
            txtSessionName.TabIndex = 2;
            // 
            // User
            // 
            User.AutoSize = true;
            User.Location = new System.Drawing.Point(12, 28);
            User.Name = "User";
            User.Size = new System.Drawing.Size(41, 20);
            User.TabIndex = 3;
            User.Text = "User:";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(640, 165);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(116, 27);
            button1.TabIndex = 4;
            button1.Text = "refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAddBlog
            // 
            btnAddBlog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAddBlog.Location = new System.Drawing.Point(252, 150);
            btnAddBlog.Name = "btnAddBlog";
            btnAddBlog.Size = new System.Drawing.Size(283, 44);
            btnAddBlog.TabIndex = 5;
            btnAddBlog.Text = "What do you want to ask?";
            btnAddBlog.UseVisualStyleBackColor = true;
            btnAddBlog.Click += btnAddBlog_Click;
            // 
            // btnViewProfile
            // 
            btnViewProfile.Location = new System.Drawing.Point(640, 12);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.Size = new System.Drawing.Size(116, 53);
            btnViewProfile.TabIndex = 6;
            btnViewProfile.Text = "View Profile";
            btnViewProfile.UseVisualStyleBackColor = true;
            btnViewProfile.Click += btnViewProfile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(148, 92);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 28);
            label2.TabIndex = 7;
            label2.Text = "Search";
            // 
            // txtSearchBar
            // 
            txtSearchBar.Location = new System.Drawing.Point(224, 95);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.Size = new System.Drawing.Size(325, 27);
            txtSearchBar.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(564, 96);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(69, 27);
            button2.TabIndex = 9;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmHomePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 550);
            Controls.Add(button2);
            Controls.Add(txtSearchBar);
            Controls.Add(label2);
            Controls.Add(btnViewProfile);
            Controls.Add(btnAddBlog);
            Controls.Add(button1);
            Controls.Add(User);
            Controls.Add(txtSessionName);
            Controls.Add(dgvPost);
            Controls.Add(label1);
            Name = "frmHomePage";
            Text = "frmHomePage";
            Load += frmHomePage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPost;
        private System.Windows.Forms.TextBox txtSessionName;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddBlog;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Button button2;
    }
}