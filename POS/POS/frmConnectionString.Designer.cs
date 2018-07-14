namespace POS
{
    partial class frmConnectionString
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnectionString));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblConnectionStringGlobal = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDatabasePassword = new System.Windows.Forms.TextBox();
            this.lblDatabasePassword = new System.Windows.Forms.Label();
            this.txtDatabaseUser = new System.Windows.Forms.TextBox();
            this.lblDatabaseUser = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.txtServerIp = new System.Windows.Forms.TextBox();
            this.lblServerIp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "• Reports";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "• SSS E-Collection System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 39);
            this.button1.TabIndex = 42;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblConnectionStringGlobal
            // 
            this.lblConnectionStringGlobal.AutoSize = true;
            this.lblConnectionStringGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionStringGlobal.Location = new System.Drawing.Point(16, 17);
            this.lblConnectionStringGlobal.Name = "lblConnectionStringGlobal";
            this.lblConnectionStringGlobal.Size = new System.Drawing.Size(348, 24);
            this.lblConnectionStringGlobal.TabIndex = 49;
            this.lblConnectionStringGlobal.Text = "This Is For Global Connection String";
            this.lblConnectionStringGlobal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(205, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 39);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(97, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 39);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDatabasePassword
            // 
            this.txtDatabasePassword.Location = new System.Drawing.Point(166, 238);
            this.txtDatabasePassword.Name = "txtDatabasePassword";
            this.txtDatabasePassword.PasswordChar = '*';
            this.txtDatabasePassword.Size = new System.Drawing.Size(100, 20);
            this.txtDatabasePassword.TabIndex = 41;
            // 
            // lblDatabasePassword
            // 
            this.lblDatabasePassword.AutoSize = true;
            this.lblDatabasePassword.Location = new System.Drawing.Point(51, 241);
            this.lblDatabasePassword.Name = "lblDatabasePassword";
            this.lblDatabasePassword.Size = new System.Drawing.Size(105, 13);
            this.lblDatabasePassword.TabIndex = 48;
            this.lblDatabasePassword.Text = "Database Password:";
            // 
            // txtDatabaseUser
            // 
            this.txtDatabaseUser.Location = new System.Drawing.Point(166, 194);
            this.txtDatabaseUser.Name = "txtDatabaseUser";
            this.txtDatabaseUser.Size = new System.Drawing.Size(100, 20);
            this.txtDatabaseUser.TabIndex = 40;
            // 
            // lblDatabaseUser
            // 
            this.lblDatabaseUser.AutoSize = true;
            this.lblDatabaseUser.Location = new System.Drawing.Point(51, 196);
            this.lblDatabaseUser.Name = "lblDatabaseUser";
            this.lblDatabaseUser.Size = new System.Drawing.Size(81, 13);
            this.lblDatabaseUser.TabIndex = 47;
            this.lblDatabaseUser.Text = "Database User:";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(166, 153);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(100, 20);
            this.txtDatabaseName.TabIndex = 39;
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.Location = new System.Drawing.Point(51, 156);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(90, 13);
            this.lblDatabaseName.TabIndex = 46;
            this.lblDatabaseName.Text = "Database Name: ";
            // 
            // txtServerIp
            // 
            this.txtServerIp.Location = new System.Drawing.Point(166, 113);
            this.txtServerIp.Name = "txtServerIp";
            this.txtServerIp.Size = new System.Drawing.Size(100, 20);
            this.txtServerIp.TabIndex = 38;
            // 
            // lblServerIp
            // 
            this.lblServerIp.AutoSize = true;
            this.lblServerIp.Location = new System.Drawing.Point(51, 116);
            this.lblServerIp.Name = "lblServerIp";
            this.lblServerIp.Size = new System.Drawing.Size(57, 13);
            this.lblServerIp.TabIndex = 45;
            this.lblServerIp.Text = "Server IP: ";
            // 
            // frmConnectionString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 382);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblConnectionStringGlobal);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDatabasePassword);
            this.Controls.Add(this.lblDatabasePassword);
            this.Controls.Add(this.txtDatabaseUser);
            this.Controls.Add(this.lblDatabaseUser);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.lblDatabaseName);
            this.Controls.Add(this.txtServerIp);
            this.Controls.Add(this.lblServerIp);
            this.Name = "frmConnectionString";
            this.Text = "Connection String";
            this.Load += new System.EventHandler(this.frmConnectionString_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblConnectionStringGlobal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDatabasePassword;
        private System.Windows.Forms.Label lblDatabasePassword;
        private System.Windows.Forms.TextBox txtDatabaseUser;
        private System.Windows.Forms.Label lblDatabaseUser;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.TextBox txtServerIp;
        private System.Windows.Forms.Label lblServerIp;
    }
}