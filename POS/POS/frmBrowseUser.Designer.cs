namespace POS
{
    partial class frmBrowseUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchCode = new System.Windows.Forms.TextBox();
            this.lvUserList = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search User : ";
            // 
            // txtSearchCode
            // 
            this.txtSearchCode.Location = new System.Drawing.Point(93, 18);
            this.txtSearchCode.MaxLength = 4;
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Size = new System.Drawing.Size(183, 20);
            this.txtSearchCode.TabIndex = 1;
            this.txtSearchCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSearchCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchCode_KeyPress);
            // 
            // lvUserList
            // 
            this.lvUserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chUserID,
            this.chFullName,
            this.chPosition,
            this.chState,
            this.chStatus});
            this.lvUserList.FullRowSelect = true;
            this.lvUserList.GridLines = true;
            this.lvUserList.Location = new System.Drawing.Point(15, 48);
            this.lvUserList.Name = "lvUserList";
            this.lvUserList.Size = new System.Drawing.Size(537, 175);
            this.lvUserList.TabIndex = 2;
            this.lvUserList.UseCompatibleStateImageBehavior = false;
            this.lvUserList.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 50;
            // 
            // chUserID
            // 
            this.chUserID.Text = "USER ID";
            this.chUserID.Width = 100;
            // 
            // chFullName
            // 
            this.chFullName.Text = "FULL NAME";
            this.chFullName.Width = 120;
            // 
            // chPosition
            // 
            this.chPosition.Text = "POSITION";
            this.chPosition.Width = 100;
            // 
            // chState
            // 
            this.chState.Text = "STATE";
            this.chState.Width = 100;
            // 
            // chStatus
            // 
            this.chStatus.Text = "STATUS";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(15, 230);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(112, 23);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "ADD USER";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(15, 259);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "EDIT USER";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(133, 230);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE USER";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(440, 230);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 52);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmBrowseUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 289);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lvUserList);
            this.Controls.Add(this.txtSearchCode);
            this.Controls.Add(this.label1);
            this.Name = "frmBrowseUser";
            this.Text = "frmBrowseUser";
            this.Load += new System.EventHandler(this.frmBrowseUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchCode;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chUserID;
        private System.Windows.Forms.ColumnHeader chFullName;
        private System.Windows.Forms.ColumnHeader chPosition;
        private System.Windows.Forms.ColumnHeader chState;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.ListView lvUserList;
    }
}