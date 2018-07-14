using System;
using System.Windows.Forms;
using POS.forBrowsePosition;
using POS.Globals;
using POS.foLogin;

namespace POS
{
    public partial class frmBrowsePosition : Form
    {
        public frmBrowsePosition()
        {
            InitializeComponent();
            forBrowsePositionDAO.browsePositionListView = this;
            frmAddPosition.browsePositionListView = this;
        }

        private void frmBrowsePosition_Load(object sender, EventArgs e)
        {
            forBrowsePositionDAO.toRetrievePosition();
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmAddPosition"];
            if (f == null)
            {
                forBrowsePositionVO.setFunctionFor = 1;
                frmAddPosition fap = new frmAddPosition();
                fap.MdiParent = MdiParent;
                fap.Text = "Add Position";
                fap.Show();
            }
            else
            {
                MessageBox.Show("The Add Position Is Already Opened!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditPosition_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmAddPosition"];
            if (f == null)
            {
                forBrowsePositionVO.setFunctionFor = 2;
                frmAddPosition fap = new frmAddPosition();
                fap.MdiParent = MdiParent;
                fap.Text = "Edit Position";
                fap.Show();
            }
            else
            {
                MessageBox.Show("The Edit Position Is Already Opened!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lvPosition_DoubleClick(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmAddPosition"];
            if (f == null)
            {
                forBrowsePositionVO.setFunctionFor = 2;
                frmAddPosition fap = new frmAddPosition();
                fap.MdiParent = MdiParent;
                fap.Text = "Edit Position";
                fap.Show();
            }
            else
            {
                MessageBox.Show("The Edit Position Is Already Opened!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lvPosition.SelectedItems.Count != 0)
            {
                DialogResult dialog = MessageBox.Show("Are You Sure To Delete The Selected Data?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    GlobalsCodeDAO.toSaveInAuditTrail("toDeletePosition:" + lvPosition.SelectedItems[0].SubItems[1].Text, forLoginVO.getUserLoggedIn.ToString(), forLoginVO.getUserLoggedIn.ToString(), DateTime.Now, "frmBrowsePosition");
                    forBrowsePositionDAO.toDeletePosition(Convert.ToInt32(lvPosition.SelectedItems[0].Text));
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            forBrowsePositionDAO.toSearchPosition(txtSearch.Text);
        }
    }
}
