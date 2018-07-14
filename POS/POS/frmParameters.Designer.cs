namespace POS
{
    partial class frmParameters
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBranchAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.lblComapnyName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBranchAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBranch);
            this.groupBox1.Controls.Add(this.txtCompanyAddress);
            this.groupBox1.Controls.Add(this.txtCompanyName);
            this.groupBox1.Controls.Add(this.lblBranch);
            this.groupBox1.Controls.Add(this.lblCompanyAddress);
            this.groupBox1.Controls.Add(this.lblComapnyName);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Details";
            // 
            // txtBranchAddress
            // 
            this.txtBranchAddress.Location = new System.Drawing.Point(118, 119);
            this.txtBranchAddress.Name = "txtBranchAddress";
            this.txtBranchAddress.Size = new System.Drawing.Size(268, 20);
            this.txtBranchAddress.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Branch Address: ";
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(118, 93);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(268, 20);
            this.txtBranch.TabIndex = 5;
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Location = new System.Drawing.Point(118, 65);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(268, 20);
            this.txtCompanyAddress.TabIndex = 4;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(118, 36);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(268, 20);
            this.txtCompanyName.TabIndex = 3;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(6, 95);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(50, 13);
            this.lblBranch.TabIndex = 2;
            this.lblBranch.Text = "Branch : ";
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Location = new System.Drawing.Point(6, 68);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(101, 13);
            this.lblCompanyAddress.TabIndex = 1;
            this.lblCompanyAddress.Text = "Company Address : ";
            // 
            // lblComapnyName
            // 
            this.lblComapnyName.AutoSize = true;
            this.lblComapnyName.Location = new System.Drawing.Point(6, 39);
            this.lblComapnyName.Name = "lblComapnyName";
            this.lblComapnyName.Size = new System.Drawing.Size(91, 13);
            this.lblComapnyName.TabIndex = 0;
            this.lblComapnyName.Text = "Company Name : ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(411, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 51);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(411, 75);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 51);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 197);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmParameters";
            this.Text = "Parameters";
            this.Load += new System.EventHandler(this.frmParameters_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.Label lblComapnyName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBranch;
        public System.Windows.Forms.TextBox txtCompanyAddress;
        public System.Windows.Forms.TextBox txtCompanyName;
        public System.Windows.Forms.TextBox txtBranchAddress;
    }
}