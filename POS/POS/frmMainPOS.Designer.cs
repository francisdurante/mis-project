namespace POS
{
    partial class frmMainPOS
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheckOutTeller = new System.Windows.Forms.Button();
            this.btnItemReturn = new System.Windows.Forms.Button();
            this.btnInquireItem = new System.Windows.Forms.Button();
            this.btnItemVoid = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalContent = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancelTransaction = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblTransactionNumberContent = new System.Windows.Forms.Label();
            this.lblTransactionNumber = new System.Windows.Forms.Label();
            this.lvItemList = new System.Windows.Forms.ListView();
            this.chItemCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chItemQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chItemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCheckOutTeller);
            this.groupBox1.Controls.Add(this.btnItemReturn);
            this.groupBox1.Controls.Add(this.btnInquireItem);
            this.groupBox1.Controls.Add(this.btnItemVoid);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 513);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functionality";
            // 
            // btnCheckOutTeller
            // 
            this.btnCheckOutTeller.Location = new System.Drawing.Point(8, 220);
            this.btnCheckOutTeller.Name = "btnCheckOutTeller";
            this.btnCheckOutTeller.Size = new System.Drawing.Size(126, 61);
            this.btnCheckOutTeller.TabIndex = 4;
            this.btnCheckOutTeller.Text = "Check Out Teller (F4)";
            this.btnCheckOutTeller.UseVisualStyleBackColor = true;
            // 
            // btnItemReturn
            // 
            this.btnItemReturn.Location = new System.Drawing.Point(8, 153);
            this.btnItemReturn.Name = "btnItemReturn";
            this.btnItemReturn.Size = new System.Drawing.Size(126, 61);
            this.btnItemReturn.TabIndex = 3;
            this.btnItemReturn.Text = "Item Return (F3)";
            this.btnItemReturn.UseVisualStyleBackColor = true;
            // 
            // btnInquireItem
            // 
            this.btnInquireItem.Location = new System.Drawing.Point(8, 19);
            this.btnInquireItem.Name = "btnInquireItem";
            this.btnInquireItem.Size = new System.Drawing.Size(126, 61);
            this.btnInquireItem.TabIndex = 0;
            this.btnInquireItem.Text = "Inquire Items (F1)";
            this.btnInquireItem.UseVisualStyleBackColor = true;
            this.btnInquireItem.Click += new System.EventHandler(this.btnInquireItem_Click);
            // 
            // btnItemVoid
            // 
            this.btnItemVoid.Location = new System.Drawing.Point(8, 86);
            this.btnItemVoid.Name = "btnItemVoid";
            this.btnItemVoid.Size = new System.Drawing.Size(126, 61);
            this.btnItemVoid.TabIndex = 2;
            this.btnItemVoid.Text = "Item Void (F2)";
            this.btnItemVoid.UseVisualStyleBackColor = true;
            this.btnItemVoid.Click += new System.EventHandler(this.btnItemVoid_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalContent);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.btnCancelTransaction);
            this.groupBox2.Controls.Add(this.btnPost);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Controls.Add(this.txtItemCode);
            this.groupBox2.Controls.Add(this.lblItemCode);
            this.groupBox2.Controls.Add(this.lblTransactionNumberContent);
            this.groupBox2.Controls.Add(this.lblTransactionNumber);
            this.groupBox2.Controls.Add(this.lvItemList);
            this.groupBox2.Location = new System.Drawing.Point(181, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 514);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblTotalContent
            // 
            this.lblTotalContent.AutoSize = true;
            this.lblTotalContent.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalContent.Location = new System.Drawing.Point(428, 324);
            this.lblTotalContent.Name = "lblTotalContent";
            this.lblTotalContent.Size = new System.Drawing.Size(68, 32);
            this.lblTotalContent.TabIndex = 17;
            this.lblTotalContent.Text = "0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(308, 324);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(124, 32);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "TOTAL :";
            // 
            // btnCancelTransaction
            // 
            this.btnCancelTransaction.Location = new System.Drawing.Point(143, 308);
            this.btnCancelTransaction.Name = "btnCancelTransaction";
            this.btnCancelTransaction.Size = new System.Drawing.Size(119, 73);
            this.btnCancelTransaction.TabIndex = 13;
            this.btnCancelTransaction.Text = "CANCEL TRANSACTION";
            this.btnCancelTransaction.UseVisualStyleBackColor = true;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(18, 308);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(119, 73);
            this.btnPost.TabIndex = 12;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(82, 268);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(51, 20);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(18, 271);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 13);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity : ";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(83, 242);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(195, 20);
            this.txtItemCode.TabIndex = 4;
            this.txtItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode_KeyDown);
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(18, 245);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(61, 13);
            this.lblItemCode.TabIndex = 3;
            this.lblItemCode.Text = "Item Code: ";
            // 
            // lblTransactionNumberContent
            // 
            this.lblTransactionNumberContent.AutoSize = true;
            this.lblTransactionNumberContent.Location = new System.Drawing.Point(450, 17);
            this.lblTransactionNumberContent.Name = "lblTransactionNumberContent";
            this.lblTransactionNumberContent.Size = new System.Drawing.Size(73, 13);
            this.lblTransactionNumberContent.TabIndex = 2;
            this.lblTransactionNumberContent.Text = "53454723432";
            // 
            // lblTransactionNumber
            // 
            this.lblTransactionNumber.AutoSize = true;
            this.lblTransactionNumber.Location = new System.Drawing.Point(341, 16);
            this.lblTransactionNumber.Name = "lblTransactionNumber";
            this.lblTransactionNumber.Size = new System.Drawing.Size(106, 13);
            this.lblTransactionNumber.TabIndex = 1;
            this.lblTransactionNumber.Text = "Transaction Number:";
            // 
            // lvItemList
            // 
            this.lvItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chItemCode,
            this.chItemName,
            this.chItemQuantity,
            this.chItemPrice,
            this.chTotal});
            this.lvItemList.FullRowSelect = true;
            this.lvItemList.Location = new System.Drawing.Point(35, 66);
            this.lvItemList.MultiSelect = false;
            this.lvItemList.Name = "lvItemList";
            this.lvItemList.Size = new System.Drawing.Size(488, 161);
            this.lvItemList.TabIndex = 0;
            this.lvItemList.UseCompatibleStateImageBehavior = false;
            this.lvItemList.View = System.Windows.Forms.View.Details;
            this.lvItemList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvItemList_KeyDown);
            // 
            // chItemCode
            // 
            this.chItemCode.Text = "Item Code";
            this.chItemCode.Width = 120;
            // 
            // chItemName
            // 
            this.chItemName.Text = "Item Name";
            this.chItemName.Width = 120;
            // 
            // chItemQuantity
            // 
            this.chItemQuantity.Text = "Quantity";
            this.chItemQuantity.Width = 80;
            // 
            // chItemPrice
            // 
            this.chItemPrice.Text = "Price";
            this.chItemPrice.Width = 80;
            // 
            // chTotal
            // 
            this.chTotal.Text = "Total";
            this.chTotal.Width = 80;
            // 
            // frmMainPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 539);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMainPOS";
            this.Text = "Transanction";
            this.Load += new System.EventHandler(this.frmMainPOS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheckOutTeller;
        private System.Windows.Forms.Button btnItemReturn;
        private System.Windows.Forms.Button btnItemVoid;
        private System.Windows.Forms.Button btnInquireItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Label lblTransactionNumber;
        private System.Windows.Forms.ColumnHeader chItemCode;
        private System.Windows.Forms.ColumnHeader chItemName;
        private System.Windows.Forms.ColumnHeader chItemQuantity;
        private System.Windows.Forms.ColumnHeader chItemPrice;
        private System.Windows.Forms.Button btnCancelTransaction;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ColumnHeader chTotal;
        public System.Windows.Forms.ListView lvItemList;
        public System.Windows.Forms.Label lblTotalContent;
        public System.Windows.Forms.Label lblTransactionNumberContent;
    }
}