namespace POS
{
    partial class frmMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLoggedInUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseUserPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditTrailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssDateTime,
            this.tssLoggedInUser,
            this.tssPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 352);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(747, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssDateTime
            // 
            this.tssDateTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssDateTime.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tssDateTime.Name = "tssDateTime";
            this.tssDateTime.Size = new System.Drawing.Size(65, 19);
            this.tssDateTime.Text = "Date Time";
            // 
            // tssLoggedInUser
            // 
            this.tssLoggedInUser.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssLoggedInUser.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tssLoggedInUser.Name = "tssLoggedInUser";
            this.tssLoggedInUser.Size = new System.Drawing.Size(90, 19);
            this.tssLoggedInUser.Text = "Logged In User";
            // 
            // tssPosition
            // 
            this.tssPosition.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssPosition.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tssPosition.Name = "tssPosition";
            this.tssPosition.Size = new System.Drawing.Size(54, 19);
            this.tssPosition.Text = "Position";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.maintenanceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemsToolStripMenuItem,
            this.checkInventoryToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // addItemsToolStripMenuItem
            // 
            this.addItemsToolStripMenuItem.Name = "addItemsToolStripMenuItem";
            this.addItemsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addItemsToolStripMenuItem.Text = "Add Items";
            this.addItemsToolStripMenuItem.Click += new System.EventHandler(this.addItemsToolStripMenuItem_Click);
            // 
            // checkInventoryToolStripMenuItem
            // 
            this.checkInventoryToolStripMenuItem.Name = "checkInventoryToolStripMenuItem";
            this.checkInventoryToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.checkInventoryToolStripMenuItem.Text = "Check Inventory";
            this.checkInventoryToolStripMenuItem.Click += new System.EventHandler(this.checkInventoryToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.browseUserPositionToolStripMenuItem,
            this.itemCategoryToolStripMenuItem,
            this.parametersToolStripMenuItem,
            this.changeMyPasswordToolStripMenuItem,
            this.auditTrailToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.userToolStripMenuItem.Text = "Browse User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // browseUserPositionToolStripMenuItem
            // 
            this.browseUserPositionToolStripMenuItem.Name = "browseUserPositionToolStripMenuItem";
            this.browseUserPositionToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.browseUserPositionToolStripMenuItem.Text = "Browse User Position";
            this.browseUserPositionToolStripMenuItem.Click += new System.EventHandler(this.browseUserPositionToolStripMenuItem_Click);
            // 
            // itemCategoryToolStripMenuItem
            // 
            this.itemCategoryToolStripMenuItem.Name = "itemCategoryToolStripMenuItem";
            this.itemCategoryToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.itemCategoryToolStripMenuItem.Text = "Browse Item Category";
            this.itemCategoryToolStripMenuItem.Click += new System.EventHandler(this.itemCategoryToolStripMenuItem_Click);
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.parametersToolStripMenuItem.Text = "Parameters";
            this.parametersToolStripMenuItem.Click += new System.EventHandler(this.parametersToolStripMenuItem_Click);
            // 
            // changeMyPasswordToolStripMenuItem
            // 
            this.changeMyPasswordToolStripMenuItem.Name = "changeMyPasswordToolStripMenuItem";
            this.changeMyPasswordToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.changeMyPasswordToolStripMenuItem.Text = "Change My Password";
            this.changeMyPasswordToolStripMenuItem.Click += new System.EventHandler(this.changeMyPasswordToolStripMenuItem_Click);
            // 
            // auditTrailToolStripMenuItem
            // 
            this.auditTrailToolStripMenuItem.Name = "auditTrailToolStripMenuItem";
            this.auditTrailToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.auditTrailToolStripMenuItem.Text = "Audit Trail";
            this.auditTrailToolStripMenuItem.Click += new System.EventHandler(this.auditTrailToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 376);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "POS System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssDateTime;
        private System.Windows.Forms.ToolStripStatusLabel tssLoggedInUser;
        private System.Windows.Forms.ToolStripStatusLabel tssPosition;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeMyPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditTrailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseUserPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInventoryToolStripMenuItem;
    }
}