using System;
using System.Windows.Forms;
using POS.foLogin;
using POS.Globals;

namespace POS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fmp = Application.OpenForms["frmMainPOS"];
            if (fmp == null)
            {
                frmMainPOS fmpp = new frmMainPOS();
                fmpp.MdiParent = this;
                fmpp.Show();
            }
            else
            {
                MessageBox.Show("The Transaction Form is Already Open!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void parametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmParameters"];
            if(f == null)
            {
                frmParameters fp = new frmParameters();
                fp.MdiParent = this;
                fp.Show();
            }
            else
            {
                MessageBox.Show("The Parameter Form is Already Open!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmBrowseUser"];
            if(f == null)
            {
                frmBrowseUser fbu = new frmBrowseUser();
                fbu.MdiParent = this;
                fbu.Show();
            }
            else
            {
                MessageBox.Show("Browse User Form Is Already Opened!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void browseUserPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmBrowsePosition"];
            if (f == null)
            {
                frmBrowsePosition fbp = new frmBrowsePosition();
                fbp.MdiParent = this;
                fbp.Show();
            }
            else
            {
                MessageBox.Show("The Browse Position Is Already Opened!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void itemCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmBrowseCategory"];
            if (f == null)
            {
                frmBrowseCategory fbc = new frmBrowseCategory();
                fbc.MdiParent = this;
                fbc.Show();
            }
            else
            {
                MessageBox.Show("The Browse Category Is Already Opened!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(forLoginVO.getPosition == "Teller")
            {
                forHighPosition();
            }
            tssLoggedInUser.Text    = "User Logged In :" + forLoginVO.getUserLoggedIn.ToString();
            tssPosition.Text        = "User Position : " + forLoginVO.getPosition;
            tssDateTime.Text = DateTime.Now.ToString("MMMM/dd/yyyy HH:mm:ss");
            frmMainPOS fmp = new frmMainPOS();
            fmp.MdiParent = this;
            fmp.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssDateTime.Text = DateTime.Now.ToString("MMMM/dd/yyyy HH:mm:ss");
        }

        private void changeMyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmChangePassword"];
            if (f == null)
            {
                frmChangePassword fcp = new frmChangePassword();
                fcp.MdiParent = this;
                fcp.Show();
            }
            else
            {
                MessageBox.Show("The Change Password Form Is Already Opened!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void auditTrailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmChangePassword"];
            if (f == null)
            {
                frmAuditTrail fat = new frmAuditTrail();
                fat.MdiParent = this;
                fat.Show();
            }
            else
            {
                MessageBox.Show("The Audit Trail Form Is Already Opened!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void forHighPosition()
        {
            inventoryToolStripMenuItem.Visible = false;
            salesToolStripMenuItem.Visible = false;
            userToolStripMenuItem.Visible = false;
            browseUserPositionToolStripMenuItem.Visible = false;
            itemCategoryToolStripMenuItem.Visible = false;
            parametersToolStripMenuItem.Visible = false;
            auditTrailToolStripMenuItem.Visible = false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Information",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    GlobalsCodeDAO.toChangeState("OFFLINE");
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmAddItem"];
            if(f == null)
            {
                frmAddItem fai = new frmAddItem();
                fai.MdiParent = this;
                fai.Show();
            }
            else
            {
                MessageBox.Show("Add Item Form is Already Open", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmInventoryCheck"];
            if (f == null)
            {
                frmInventoryCheck fic = new frmInventoryCheck();
                fic.MdiParent = MdiParent;
                fic.Show();
            }
            else
            {
                MessageBox.Show("Add Inventory Check Form is Already Open", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
