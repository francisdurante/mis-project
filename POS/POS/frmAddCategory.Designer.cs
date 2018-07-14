namespace POS
{
    partial class frmAddCategory
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
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInActive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInActive);
            this.gbStatus.Controls.Add(this.rbActive);
            this.gbStatus.Location = new System.Drawing.Point(12, 43);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(226, 51);
            this.gbStatus.TabIndex = 6;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbInActive
            // 
            this.rbInActive.AutoSize = true;
            this.rbInActive.Location = new System.Drawing.Point(121, 20);
            this.rbInActive.Name = "rbInActive";
            this.rbInActive.Size = new System.Drawing.Size(77, 17);
            this.rbInActive.TabIndex = 0;
            this.rbInActive.TabStop = true;
            this.rbInActive.Text = "IN-ACTIVE";
            this.rbInActive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(17, 20);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(63, 17);
            this.rbActive.TabIndex = 0;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "ACTIVE";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(72, 17);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(166, 20);
            this.txtCategory.TabIndex = 5;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(13, 20);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(58, 13);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "Category : ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(127, 114);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 41);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 114);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 41);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 173);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "frmAddCategory";
            this.Text = "Add Category";
            this.Load += new System.EventHandler(this.frmAddCategory_Load);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInActive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}