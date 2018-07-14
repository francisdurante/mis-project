namespace POS
{
    partial class frmAddItem
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.lblItemQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(9, 41);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(116, 16);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Item Category : ";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(129, 38);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(199, 21);
            this.cbCategory.TabIndex = 1;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.Location = new System.Drawing.Point(9, 15);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(90, 16);
            this.lblItemCode.TabIndex = 2;
            this.lblItemCode.Text = "Item Code : ";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(129, 12);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(199, 20);
            this.txtItemCode.TabIndex = 3;
            this.txtItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode_KeyDown);
            this.txtItemCode.Leave += new System.EventHandler(this.txtItemCode_Leave);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(9, 68);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(94, 16);
            this.lblItemName.TabIndex = 4;
            this.lblItemName.Text = "Item Name : ";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(129, 65);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(199, 20);
            this.txtItemName.TabIndex = 5;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPrice.Location = new System.Drawing.Point(9, 94);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(89, 16);
            this.lblItemPrice.TabIndex = 6;
            this.lblItemPrice.Text = "Item Price : ";
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(129, 91);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(199, 20);
            this.txtItemPrice.TabIndex = 7;
            this.txtItemPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemPrice_KeyPress);
            // 
            // lblItemQuantity
            // 
            this.lblItemQuantity.AutoSize = true;
            this.lblItemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemQuantity.Location = new System.Drawing.Point(9, 120);
            this.lblItemQuantity.Name = "lblItemQuantity";
            this.lblItemQuantity.Size = new System.Drawing.Size(105, 16);
            this.lblItemQuantity.TabIndex = 8;
            this.lblItemQuantity.Text = "Item Quantity :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(129, 117);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(199, 20);
            this.txtQuantity.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(357, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 54);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(357, 83);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 54);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 158);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblItemQuantity);
            this.Controls.Add(this.txtItemPrice);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lblCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddItem";
            this.Text = "frmAddItem";
            this.Load += new System.EventHandler(this.frmAddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label lblItemQuantity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.ComboBox cbCategory;
        public System.Windows.Forms.TextBox txtItemName;
        public System.Windows.Forms.TextBox txtItemPrice;
        public System.Windows.Forms.TextBox txtQuantity;
        public System.Windows.Forms.TextBox txtItemCode;
    }
}