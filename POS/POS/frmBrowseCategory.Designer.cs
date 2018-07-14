namespace POS
{
    partial class frmBrowseCategory
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
            this.lvCategory = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCategoryStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInsertedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCreatedAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvCategory
            // 
            this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chCategoryName,
            this.chCategoryStatus,
            this.chInsertedBy,
            this.chCreatedAt});
            this.lvCategory.FullRowSelect = true;
            this.lvCategory.GridLines = true;
            this.lvCategory.Location = new System.Drawing.Point(12, 52);
            this.lvCategory.MultiSelect = false;
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(570, 197);
            this.lvCategory.TabIndex = 0;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.Details;
            this.lvCategory.DoubleClick += new System.EventHandler(this.lvCategory_DoubleClick);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 70;
            // 
            // chCategoryName
            // 
            this.chCategoryName.Text = "CATEGORY NAME";
            this.chCategoryName.Width = 120;
            // 
            // chCategoryStatus
            // 
            this.chCategoryStatus.Text = "STATUS";
            this.chCategoryStatus.Width = 100;
            // 
            // chInsertedBy
            // 
            this.chInsertedBy.Text = "INSERTED BY";
            this.chInsertedBy.Width = 120;
            // 
            // chCreatedAt
            // 
            this.chCreatedAt.Text = "INSERTED DATE";
            this.chCreatedAt.Width = 150;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 13);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(126, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search Category Name : ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(144, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(189, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(12, 256);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(126, 23);
            this.btnAddCategory.TabIndex = 3;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(12, 285);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(126, 23);
            this.btnEditCategory.TabIndex = 4;
            this.btnEditCategory.Text = "Edit Category";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(144, 256);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(126, 23);
            this.btnDeleteCategory.TabIndex = 5;
            this.btnDeleteCategory.Text = "Delete Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(456, 256);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 52);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmBrowseCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 315);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lvCategory);
            this.Name = "frmBrowseCategory";
            this.Text = "Browse Category";
            this.Load += new System.EventHandler(this.frmBrowseCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chCategoryName;
        private System.Windows.Forms.ColumnHeader chCategoryStatus;
        private System.Windows.Forms.ColumnHeader chInsertedBy;
        private System.Windows.Forms.ColumnHeader chCreatedAt;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnClose;
    }
}