using System;
using System.Windows.Forms;
using POS.forBrowsePosition;
using POS.foLogin;
using POS.Globals;

namespace POS
{
    public partial class frmAddPosition : Form
    {
        public frmAddPosition()
        {
            InitializeComponent();
        }
        public static frmBrowsePosition browsePositionListView { get; set; }
        int id = 0;
        string currentPosition = "";
        string currentStatus = "";
        private void frmAddPosition_Load(object sender, EventArgs e)
        {
            try
            {
                if (forBrowsePositionVO.getFunctionFor == 1)
                {
                    rbActive.Checked = true;
                    gbStatus.Enabled = false;
                }
                else
                {
                    ListViewItem items = browsePositionListView.lvPosition.SelectedItems[0];
                    id = Convert.ToInt32(items.SubItems[0].Text);
                    txtPosition.Text = items.SubItems[1].Text;
                    currentPosition = txtPosition.Text;
                    currentStatus = items.SubItems[2].Text;
                    if (items.SubItems[2].Text == "ACTIVE")
                    {
                        rbActive.Checked = true;
                    }
                    else
                    {
                        rbInActive.Checked = true;
                    }
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string status = "";
            if(txtPosition.Text != "")
            {
                if (rbActive.Checked)
                {
                    status = "ACTIVE";
                }
                else
                {
                    status = "IN-ACTIVE";
                }
                if (forBrowsePositionVO.getFunctionFor == 1)//ADD NEW POSITION
                {
                    forBrowsePositionDAO.toSaveNewPosition(txtPosition.Text, status, forLoginVO.getUserLoggedIn);
                    GlobalsCodeDAO.toSaveInAuditTrail("ToAddPosition:" + txtPosition.Text.ToUpper(), forLoginVO.getUserLoggedIn.ToString(), forLoginVO.getUserLoggedIn.ToString(), DateTime.Now, "frmAddPosition");
                    Close();
                }
                else //EDIT POSITION
                {
                    if (forBrowsePositionDAO.toSaveEditPosition(txtPosition.Text, status, id))
                    {
                        if (txtPosition.Text != currentPosition)
                        {
                            GlobalsCodeDAO.toSaveInAuditTrail("ToEditPositionFrom " + currentPosition.ToUpper() + "to" + txtPosition.Text.ToUpper(), forLoginVO.getUserLoggedIn.ToString(), forLoginVO.getUserLoggedIn.ToString(), DateTime.Now, "frmEditPosition");
                        }
                        if(status != currentStatus)
                        {
                            GlobalsCodeDAO.toSaveInAuditTrail("ToEditPositionStatusFrom : " + currentStatus.ToUpper() + "to" + status.ToUpper(), forLoginVO.getUserLoggedIn.ToString(), forLoginVO.getUserLoggedIn.ToString(), DateTime.Now, "frmEditPosition");
                        }
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Input Data Needed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
