namespace POS
{
    partial class frmAmountRender
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
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalAmountContent = new System.Windows.Forms.Label();
            this.lblAmountGiven = new System.Windows.Forms.Label();
            this.txtAmountGiven = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblChangeContent = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(12, 18);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(118, 29);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "TOTAL : ";
            // 
            // lblTotalAmountContent
            // 
            this.lblTotalAmountContent.AutoSize = true;
            this.lblTotalAmountContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountContent.Location = new System.Drawing.Point(143, 18);
            this.lblTotalAmountContent.Name = "lblTotalAmountContent";
            this.lblTotalAmountContent.Size = new System.Drawing.Size(104, 29);
            this.lblTotalAmountContent.TabIndex = 1;
            this.lblTotalAmountContent.Text = "1000.00";
            // 
            // lblAmountGiven
            // 
            this.lblAmountGiven.AutoSize = true;
            this.lblAmountGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountGiven.Location = new System.Drawing.Point(14, 58);
            this.lblAmountGiven.Name = "lblAmountGiven";
            this.lblAmountGiven.Size = new System.Drawing.Size(128, 18);
            this.lblAmountGiven.TabIndex = 2;
            this.lblAmountGiven.Text = "Amount Given : ";
            // 
            // txtAmountGiven
            // 
            this.txtAmountGiven.Location = new System.Drawing.Point(148, 59);
            this.txtAmountGiven.Name = "txtAmountGiven";
            this.txtAmountGiven.Size = new System.Drawing.Size(179, 20);
            this.txtAmountGiven.TabIndex = 3;
            this.txtAmountGiven.Text = "0.00";
            this.txtAmountGiven.TextChanged += new System.EventHandler(this.txtAmountGiven_TextChanged);
            this.txtAmountGiven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountGiven_KeyPress);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(14, 93);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(80, 18);
            this.lblChange.TabIndex = 4;
            this.lblChange.Text = "Change : ";
            // 
            // lblChangeContent
            // 
            this.lblChangeContent.AutoSize = true;
            this.lblChangeContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeContent.Location = new System.Drawing.Point(144, 93);
            this.lblChangeContent.Name = "lblChangeContent";
            this.lblChangeContent.Size = new System.Drawing.Size(44, 20);
            this.lblChangeContent.TabIndex = 5;
            this.lblChangeContent.Text = "0.00";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(17, 128);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 45);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmAmountRender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 185);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblChangeContent);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.txtAmountGiven);
            this.Controls.Add(this.lblAmountGiven);
            this.Controls.Add(this.lblTotalAmountContent);
            this.Controls.Add(this.lblTotalAmount);
            this.Name = "frmAmountRender";
            this.Load += new System.EventHandler(this.frmAmountRender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalAmountContent;
        private System.Windows.Forms.Label lblAmountGiven;
        private System.Windows.Forms.TextBox txtAmountGiven;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblChangeContent;
        private System.Windows.Forms.Button btnOK;
    }
}