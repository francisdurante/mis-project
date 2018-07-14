namespace POS
{
    partial class frmAuditTrail
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
            this.lvAuditTrail = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chActions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProcessBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUserLoggedIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvAuditTrail
            // 
            this.lvAuditTrail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chActions,
            this.chProcessBy,
            this.chUserLoggedIn,
            this.chDate});
            this.lvAuditTrail.Location = new System.Drawing.Point(13, 51);
            this.lvAuditTrail.Name = "lvAuditTrail";
            this.lvAuditTrail.Size = new System.Drawing.Size(605, 211);
            this.lvAuditTrail.TabIndex = 0;
            this.lvAuditTrail.UseCompatibleStateImageBehavior = false;
            this.lvAuditTrail.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 40;
            // 
            // chActions
            // 
            this.chActions.Text = "ACTIONS";
            this.chActions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chActions.Width = 240;
            // 
            // chProcessBy
            // 
            this.chProcessBy.Text = "PROCESS BY";
            this.chProcessBy.Width = 90;
            // 
            // chUserLoggedIn
            // 
            this.chUserLoggedIn.Text = "USER LOGGED IN";
            this.chUserLoggedIn.Width = 110;
            // 
            // chDate
            // 
            this.chDate.Text = "DATE";
            this.chDate.Width = 100;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(9, 13);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(121, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search By Process By : ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(136, 10);
            this.txtSearch.MaxLength = 4;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // frmAuditTrail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 296);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lvAuditTrail);
            this.Name = "frmAuditTrail";
            this.Text = "Audit Trail";
            this.Load += new System.EventHandler(this.frmAuditTrail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chActions;
        private System.Windows.Forms.ColumnHeader chProcessBy;
        private System.Windows.Forms.ColumnHeader chUserLoggedIn;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.ListView lvAuditTrail;
    }
}