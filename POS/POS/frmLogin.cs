using System;
using System.Windows.Forms;
using POS.foLogin;
using POS.Globals;

namespace POS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserID.Text !=""|| txtPassword.Text != "")
            {
                if (forLoginVO.getStatus.Equals("IN-ACTIVE"))
                {
                    MessageBox.Show("User is In-Active!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (forLoginVO.getState.Equals("ONLINE"))
                {
                    MessageBox.Show("User is Currently Online", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (forLoginVO.getPassword.Equals(Cryptography.Encrypt(txtPassword.Text)))
                    {
                        this.Hide();
                        frmMain fm = new frmMain();
                        fm.Show();
                        GlobalsCodeDAO.toSaveInAuditTrail("toLoginUser:" + txtUserID.Text,txtUserID.Text, txtUserID.Text, DateTime.Now, "frmLogin");
                        GlobalsCodeDAO.toChangeState("ONLINE");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Input Data Needed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtUserID_Leave(object sender, EventArgs e)
        {
            forLoginDAO.toRetrieveUsersInfo(Convert.ToInt32(txtUserID.Text));
            txtFullName.Text = forLoginVO.getFullName;
            txtPosition.Text = forLoginVO.getPosition;
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
