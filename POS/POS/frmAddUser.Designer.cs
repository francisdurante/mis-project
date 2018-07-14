namespace POS
{
    partial class frmAddUser
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
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.gbUserDetails = new System.Windows.Forms.GroupBox();
            this.gbState = new System.Windows.Forms.GroupBox();
            this.rbOnline = new System.Windows.Forms.RadioButton();
            this.rbOffline = new System.Windows.Forms.RadioButton();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInActive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbUserDetails.SuspendLayout();
            this.gbState.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(12, 30);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(52, 13);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID : ";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(82, 27);
            this.txtUserID.MaxLength = 4;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(152, 20);
            this.txtUserID.TabIndex = 1;
            this.txtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserID_KeyPress);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(82, 53);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(152, 20);
            this.txtFullName.TabIndex = 3;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(12, 56);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(63, 13);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Position : ";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(82, 79);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(152, 21);
            this.cbPosition.TabIndex = 5;
            // 
            // gbUserDetails
            // 
            this.gbUserDetails.Controls.Add(this.cbPosition);
            this.gbUserDetails.Controls.Add(this.lblUserID);
            this.gbUserDetails.Controls.Add(this.label1);
            this.gbUserDetails.Controls.Add(this.txtUserID);
            this.gbUserDetails.Controls.Add(this.txtFullName);
            this.gbUserDetails.Controls.Add(this.lblFullName);
            this.gbUserDetails.Location = new System.Drawing.Point(12, 12);
            this.gbUserDetails.Name = "gbUserDetails";
            this.gbUserDetails.Size = new System.Drawing.Size(337, 123);
            this.gbUserDetails.TabIndex = 6;
            this.gbUserDetails.TabStop = false;
            this.gbUserDetails.Text = "User Details";
            // 
            // gbState
            // 
            this.gbState.Controls.Add(this.rbOnline);
            this.gbState.Controls.Add(this.rbOffline);
            this.gbState.Location = new System.Drawing.Point(13, 142);
            this.gbState.Name = "gbState";
            this.gbState.Size = new System.Drawing.Size(165, 64);
            this.gbState.TabIndex = 7;
            this.gbState.TabStop = false;
            this.gbState.Text = "State";
            // 
            // rbOnline
            // 
            this.rbOnline.AutoSize = true;
            this.rbOnline.Location = new System.Drawing.Point(81, 30);
            this.rbOnline.Name = "rbOnline";
            this.rbOnline.Size = new System.Drawing.Size(65, 17);
            this.rbOnline.TabIndex = 1;
            this.rbOnline.TabStop = true;
            this.rbOnline.Text = "ONLINE";
            this.rbOnline.UseVisualStyleBackColor = true;
            // 
            // rbOffline
            // 
            this.rbOffline.AutoSize = true;
            this.rbOffline.Location = new System.Drawing.Point(7, 30);
            this.rbOffline.Name = "rbOffline";
            this.rbOffline.Size = new System.Drawing.Size(69, 17);
            this.rbOffline.TabIndex = 0;
            this.rbOffline.TabStop = true;
            this.rbOffline.Text = "OFFLINE";
            this.rbOffline.UseVisualStyleBackColor = true;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInActive);
            this.gbStatus.Controls.Add(this.rbActive);
            this.gbStatus.Location = new System.Drawing.Point(184, 142);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(165, 64);
            this.gbStatus.TabIndex = 8;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbInActive
            // 
            this.rbInActive.AutoSize = true;
            this.rbInActive.Location = new System.Drawing.Point(81, 30);
            this.rbInActive.Name = "rbInActive";
            this.rbInActive.Size = new System.Drawing.Size(77, 17);
            this.rbInActive.TabIndex = 1;
            this.rbInActive.TabStop = true;
            this.rbInActive.Text = "IN-ACTIVE";
            this.rbInActive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(7, 30);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(63, 17);
            this.rbActive.TabIndex = 0;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "ACTIVE";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 53);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbState);
            this.Controls.Add(this.gbUserDetails);
            this.Name = "frmAddUser";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.gbUserDetails.ResumeLayout(false);
            this.gbUserDetails.PerformLayout();
            this.gbState.ResumeLayout(false);
            this.gbState.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbUserDetails;
        private System.Windows.Forms.GroupBox gbState;
        private System.Windows.Forms.RadioButton rbOnline;
        private System.Windows.Forms.RadioButton rbOffline;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInActive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox cbPosition;
    }
}