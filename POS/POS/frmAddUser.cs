using System;
using System.Windows.Forms;
using POS.forBrowseUser;
using POS.foLogin;
using POS.Globals;

namespace POS
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
            forAddUserDAO.cbInAddUser = this;
        }
        int id = 0;
        public static frmBrowseUser browseUserListView { get; set; }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            forAddUserDAO.toRetrievePosition();
            if(forAddUserVO.getFunctionFor != 1)
            {
                ListViewItem items = browseUserListView.lvUserList.SelectedItems[0];
                id = Convert.ToInt32(items.SubItems[0].Text);
                txtUserID.Text = items.SubItems[1].Text;
                txtFullName.Text = items.SubItems[2].Text;
                cbPosition.Text = items.SubItems[3].Text;
                if(items.SubItems[4].Text.Equals("ONLINE"))
                {
                    rbOnline.Checked = true;
                }
                else
                {
                    rbOffline.Checked = true;
                }
                if (items.SubItems[5].Text.Equals("ACTIVE"))
                {
                    rbActive.Checked = true;
                }
                else
                {
                    rbInActive.Checked = true;
                }
            }
            else
            {
                txtUserID.ReadOnly = false;
                rbOffline.Checked = true;
                rbActive.Checked = true;
                gbState.Enabled = false;
                gbStatus.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string state = "";
            string status = "";
            if(txtFullName.Text != "" || txtUserID.Text != ""|| cbPosition.Text !="")
            {
                if (forAddUserVO.getFunctionFor != 1)
                {
                    if (rbActive.Checked)
                    {
                        status = "ACTIVE";
                    }
                    else
                    {
                        state = "IN-ACTIVE";
                    }
                    if (rbOnline.Checked)
                    {
                        state = "ONLINE";
                    }
                    else
                    {
                        state = "OFFLINE";
                    }
                    forAddUserDAO.toSaveEditUser(Convert.ToInt32(txtUserID.Text), txtFullName.Text, cbPosition.Text, state, status, id);
                    forAddUserDAO.toRetrieveUser();
                    GlobalsCodeDAO.toSaveInAuditTrail("ToEditUserFrom:" + browseUserListView.lvUserList.SelectedItems[0].SubItems[1].Text.ToUpper() + "to" + txtUserID.Text.ToUpper(), forLoginVO.getUserLoggedIn.ToString(), forLoginVO.getUserLoggedIn.ToString(), DateTime.Now, "frmEditUser");
                    Close();
                }
                else
                {
                    if (forAddUserDAO.toSaveNewUser(Convert.ToInt32(txtUserID.Text), txtUserID.Text, txtFullName.Text, cbPosition.Text, "OFFLINE", "ACTIVE", forLoginVO.getUserLoggedIn))
                    {
                        GlobalsCodeDAO.toSaveInAuditTrail("ToAddUser:" + txtUserID.Text.ToUpper(), forLoginVO.getUserLoggedIn.ToString(), forLoginVO.getUserLoggedIn.ToString(), DateTime.Now, "frmAddUser");
                        forAddUserDAO.toRetrieveUser();
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Input Data Needed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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
