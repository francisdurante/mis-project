namespace POS
{
    partial class frmItemList
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
            this.lblSearchCode = new System.Windows.Forms.Label();
            this.txtSearchCode = new System.Windows.Forms.TextBox();
            this.lvListView = new System.Windows.Forms.ListView();
            this.chItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chItemCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chItemCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chItemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSearchCode
            // 
            this.lblSearchCode.AutoSize = true;
            this.lblSearchCode.Location = new System.Drawing.Point(13, 13);
            this.lblSearchCode.Name = "lblSearchCode";
            this.lblSearchCode.Size = new System.Drawing.Size(104, 13);
            this.lblSearchCode.TabIndex = 0;
            this.lblSearchCode.Text = "Search Item Name : ";
            // 
            // txtSearchCode
            // 
            this.txtSearchCode.Location = new System.Drawing.Point(121, 9);
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Size = new System.Drawing.Size(207, 20);
            this.txtSearchCode.TabIndex = 1;
            this.txtSearchCode.TextChanged += new System.EventHandler(this.txtSearchCode_TextChanged);
            // 
            // lvListView
            // 
            this.lvListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chItemID,
            this.chItemCode,
            this.chItemName,
            this.chItemCategory,
            this.chItemPrice});
            this.lvListView.FullRowSelect = true;
            this.lvListView.Location = new System.Drawing.Point(16, 46);
            this.lvListView.Name = "lvListView";
            this.lvListView.Size = new System.Drawing.Size(568, 230);
            this.lvListView.TabIndex = 2;
            this.lvListView.UseCompatibleStateImageBehavior = false;
            this.lvListView.View = System.Windows.Forms.View.Details;
            // 
            // chItemID
            // 
            this.chItemID.Text = "ID";
            this.chItemID.Width = 100;
            // 
            // chItemName
            // 
            this.chItemName.Text = "ITEM NAME";
            this.chItemName.Width = 160;
            // 
            // chItemCode
            // 
            this.chItemCode.Text = "ITEM CODE";
            this.chItemCode.Width = 100;
            // 
            // chItemCategory
            // 
            this.chItemCategory.Text = "ITEM CATEGORY";
            this.chItemCategory.Width = 100;
            // 
            // chItemPrice
            // 
            this.chItemPrice.Text = "ITEM PRICE";
            this.chItemPrice.Width = 100;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(16, 283);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 330);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lvListView);
            this.Controls.Add(this.txtSearchCode);
            this.Controls.Add(this.lblSearchCode);
            this.Name = "frmItemList";
            this.Text = "frmItemList";
            this.Load += new System.EventHandler(this.frmItemList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchCode;
        private System.Windows.Forms.TextBox txtSearchCode;
        private System.Windows.Forms.ColumnHeader chItemID;
        private System.Windows.Forms.ColumnHeader chItemCode;
        private System.Windows.Forms.ColumnHeader chItemName;
        private System.Windows.Forms.ColumnHeader chItemCategory;
        private System.Windows.Forms.ColumnHeader chItemPrice;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.ListView lvListView;
    }
}