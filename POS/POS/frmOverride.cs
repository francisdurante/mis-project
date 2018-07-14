using System;
using System.Windows.Forms;
using POS.forOverride;
using POS.Globals;
using POS.foLogin;

namespace POS
{
    public partial class frmOverride : Form
    {
        public frmOverride()
        {
            InitializeComponent();
        }
        public frmMainPOS frmMainPOSListview { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
           
            if (forOverrideDAO.toVoidItem(txtUserId.Text, txtPassword.Text))
            {
                GlobalsCodeDAO.toSaveInAuditTrail("toOverrideVoidItem", txtUserId.Text, forLoginVO.getUserLoggedIn.ToString(), DateTime.Now, "frmOverride");
                MessageBox.Show("Override Success!");
                frmMainPOSListview.toVoidItem(0);

                Close();
            }
            else
            {
                MessageBox.Show("Override Password Error");
            }
        }

        private void frmOverride_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUserId_Leave(object sender, EventArgs e)
        {
            forOverrideVO.setPosition = "";
            forOverrideVO.setFullName = "";
            forOverrideDAO.toGetPosition(txtUserId.Text);
            if (forOverrideVO.getOverrideNeedPosition.Equals(forOverrideVO.getPosition))
            {
                txtFullName.Text = forOverrideVO.getFullName;
                txtPosition.Text = forOverrideVO.getPosition;
            }
            else
            {
                MessageBox.Show("You Are Not Applicable to Override Item Void!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFullName.Clear();
                txtPosition.Clear();
            }

        }
    }
}
