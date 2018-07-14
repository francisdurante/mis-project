namespace POS
{
    partial class frmChangePassword
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
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblVerifyNewPassword = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtVerifyPassword = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Location = new System.Drawing.Point(12, 12);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(81, 13);
            this.lblOldPassword.TabIndex = 0;
            this.lblOldPassword.Text = "Old Password : ";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(12, 41);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(87, 13);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "New Password : ";
            // 
            // lblVerifyNewPassword
            // 
            this.lblVerifyNewPassword.AutoSize = true;
            this.lblVerifyNewPassword.Location = new System.Drawing.Point(11, 72);
            this.lblVerifyNewPassword.Name = "lblVerifyNewPassword";
            this.lblVerifyNewPassword.Size = new System.Drawing.Size(100, 13);
            this.lblVerifyNewPassword.TabIndex = 2;
            this.lblVerifyNewPassword.Text = " Verify Passoword : ";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(112, 9);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '_';
            this.txtOldPassword.Size = new System.Drawing.Size(171, 20);
            this.txtOldPassword.TabIndex = 3;
            this.txtOldPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(112, 38);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '_';
            this.txtNewPassword.Size = new System.Drawing.Size(171, 20);
            this.txtNewPassword.TabIndex = 4;
            // 
            // txtVerifyPassword
            // 
            this.txtVerifyPassword.Location = new System.Drawing.Point(112, 69);
            this.txtVerifyPassword.Name = "txtVerifyPassword";
            this.txtVerifyPassword.PasswordChar = '_';
            this.txtVerifyPassword.Size = new System.Drawing.Size(171, 20);
            this.txtVerifyPassword.TabIndex = 5;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(15, 108);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(123, 42);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(144, 108);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 42);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 162);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtVerifyPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.lblVerifyNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblOldPassword);
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblVerifyNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtVerifyPassword;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnClose;
    }
}