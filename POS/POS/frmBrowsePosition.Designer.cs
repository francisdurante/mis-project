namespace POS
{
    partial class frmBrowsePosition
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
            this.lvPosition = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPositionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInsertedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInsertedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddPosition = new System.Windows.Forms.Button();
            this.btnEditPosition = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvPosition
            // 
            this.lvPosition.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chPositionName,
            this.chStatus,
            this.chInsertedBy,
            this.chInsertedDate});
            this.lvPosition.FullRowSelect = true;
            this.lvPosition.GridLines = true;
            this.lvPosition.Location = new System.Drawing.Point(12, 56);
            this.lvPosition.Name = "lvPosition";
            this.lvPosition.Size = new System.Drawing.Size(557, 172);
            this.lvPosition.TabIndex = 0;
            this.lvPosition.UseCompatibleStateImageBehavior = false;
            this.lvPosition.View = System.Windows.Forms.View.Details;
            this.lvPosition.DoubleClick += new System.EventHandler(this.lvPosition_DoubleClick);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            // 
            // chPositionName
            // 
            this.chPositionName.Text = "POSITION";
            this.chPositionName.Width = 140;
            // 
            // chStatus
            // 
            this.chStatus.Text = "STATUS";
            this.chStatus.Width = 120;
            // 
            // chInsertedBy
            // 
            this.chInsertedBy.Text = "INSERTED BY";
            this.chInsertedBy.Width = 100;
            // 
            // chInsertedDate
            // 
            this.chInsertedDate.Text = "INSERTED DATE";
            this.chInsertedDate.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Position : ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(108, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(188, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.Location = new System.Drawing.Point(12, 235);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(122, 23);
            this.btnAddPosition.TabIndex = 3;
            this.btnAddPosition.Text = "Add Position";
            this.btnAddPosition.UseVisualStyleBackColor = true;
            this.btnAddPosition.Click += new System.EventHandler(this.btnAddPosition_Click);
            // 
            // btnEditPosition
            // 
            this.btnEditPosition.Location = new System.Drawing.Point(12, 261);
            this.btnEditPosition.Name = "btnEditPosition";
            this.btnEditPosition.Size = new System.Drawing.Size(122, 23);
            this.btnEditPosition.TabIndex = 4;
            this.btnEditPosition.Text = "Edit Position";
            this.btnEditPosition.UseVisualStyleBackColor = true;
            this.btnEditPosition.Click += new System.EventHandler(this.btnEditPosition_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(140, 235);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Position";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(447, 235);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 49);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmBrowsePosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 296);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditPosition);
            this.Controls.Add(this.btnAddPosition);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvPosition);
            this.Name = "frmBrowsePosition";
            this.Text = "Browse Position";
            this.Load += new System.EventHandler(this.frmBrowsePosition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chPositionName;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.ColumnHeader chInsertedBy;
        private System.Windows.Forms.ColumnHeader chInsertedDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddPosition;
        private System.Windows.Forms.Button btnEditPosition;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.ListView lvPosition;
    }
}