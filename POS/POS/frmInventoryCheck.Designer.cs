namespace POS
{
    partial class frmInventoryCheck
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
            this.lvItemList = new System.Windows.Forms.ListView();
            this.chItemCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chItemQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvItemList
            // 
            this.lvItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chItemCode,
            this.chItemName,
            this.chItemQty,
            this.chCategory});
            this.lvItemList.Location = new System.Drawing.Point(12, 74);
            this.lvItemList.Name = "lvItemList";
            this.lvItemList.Size = new System.Drawing.Size(493, 164);
            this.lvItemList.TabIndex = 0;
            this.lvItemList.UseCompatibleStateImageBehavior = false;
            this.lvItemList.View = System.Windows.Forms.View.Details;
            // 
            // chItemCode
            // 
            this.chItemCode.Text = "ITEM CODE";
            this.chItemCode.Width = 120;
            // 
            // chItemName
            // 
            this.chItemName.Text = "ITEM NAME";
            this.chItemName.Width = 120;
            // 
            // chItemQty
            // 
            this.chItemQty.Text = "QUANTITY";
            this.chItemQty.Width = 120;
            // 
            // chCategory
            // 
            this.chCategory.Text = "CATEGORY";
            this.chCategory.Width = 120;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 24);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(50, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search : ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(68, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // frmInventoryCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 285);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lvItemList);
            this.Name = "frmInventoryCheck";
            this.Text = "frmInventoryCheck";
            this.Load += new System.EventHandler(this.frmInventoryCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader chItemCode;
        private System.Windows.Forms.ColumnHeader chItemName;
        private System.Windows.Forms.ColumnHeader chItemQty;
        private System.Windows.Forms.ColumnHeader chCategory;
        private System.Windows.Forms.Label lblSearch;
        public System.Windows.Forms.ListView lvItemList;
        public System.Windows.Forms.TextBox txtSearch;
    }
}