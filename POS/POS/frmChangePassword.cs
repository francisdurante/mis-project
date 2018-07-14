using System;
using System.Windows.Forms;
using POS.foLogin;
using POS.forChangePassword;
using POS.Globals;

namespace POS
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (forLoginVO.getPassword.Equals(Cryptography.Encrypt(txtOldPassword.Text)))
            {
                if(txtNewPassword.Text != txtVerifyPassword.Text)
                {
                    MessageBox.Show("New Password is Not Match To Verify Password!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(forChangePasswordDAO.toChangePassword(txtNewPassword.Text, forLoginVO.getUserLoggedIn))
                    {
                        GlobalsCodeDAO.toSaveInAuditTrail("toChangePasswordOfUser:" + forLoginVO.getUserLoggedIn.ToString(), forLoginVO.getUserLoggedIn.ToString(), forLoginVO.getUserLoggedIn.ToString(), DateTime.Now, "frmChangePassword");
                        MessageBox.Show("Password Successfully Change!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong Please Contact The Administrator!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Old Password is Not Match To Current Password!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
