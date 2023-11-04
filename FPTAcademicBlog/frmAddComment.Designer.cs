namespace FPTAcademicBlog
{
    partial class Form2
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
            txtUserName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtComment = new System.Windows.Forms.TextBox();
            btnSubmitComment = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(40, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "User";
            // 
            // txtUserName
            // 
            txtUserName.Location = new System.Drawing.Point(154, 27);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(204, 27);
            txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(40, 98);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Comment";
            // 
            // txtComment
            // 
            txtComment.Location = new System.Drawing.Point(154, 98);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.Size = new System.Drawing.Size(573, 229);
            txtComment.TabIndex = 3;
            // 
            // btnSubmitComment
            // 
            btnSubmitComment.Location = new System.Drawing.Point(322, 374);
            btnSubmitComment.Name = "btnSubmitComment";
            btnSubmitComment.Size = new System.Drawing.Size(94, 29);
            btnSubmitComment.TabIndex = 4;
            btnSubmitComment.Text = "Submit";
            btnSubmitComment.UseVisualStyleBackColor = true;
            btnSubmitComment.Click += btnSubmitComment_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnSubmitComment);
            Controls.Add(txtComment);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Name = "Form2";
            Text = "AddComment";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSubmitComment;
    }
}