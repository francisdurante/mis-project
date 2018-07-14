using System;
using System.Windows.Forms;
using POS.forBrowseUser;
using POS.Globals;
using POS.foLogin;

namespace POS
{
    public partial class frmBrowseUser : Form
    {
        public frmBrowseUser()
        {
            InitializeComponent();
            forAddUserDAO.browseUserListView = this;
            frmAddUser.browseUserListView = this;
        }

        private void frmBrowseUser_Load(object sender, EventArgs e)
        {
            forAddUserDAO.toRetrieveUser();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            forAddUserDAO.toSearchUser(txtSearchCode.Text);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmAddUser"];
            if(f==null)
            {
                forAddUserVO.setFunctionFor = 1;
                frmAddUser fau = new frmAddUser();
                fau.Text = "Add User";
                fau.MdiParent = MdiParent;
                fau.Show();
            }
            else
            {
                MessageBox.Show("Add User Form Is Already Opened!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lvUserList.SelectedItems.Count != 0)
            {
                Form f = Application.OpenForms["frmAddUser"];
                if (f == null)
                {
                    forAddUserVO.setFunctionFor = 2;
                    frmAddUser fau = new frmAddUser();
                    fau.Text = "Edit User";
                    fau.MdiParent = MdiParent;
                    fau.Show();
                }
                else
                {
                    MessageBox.Show("Add User Form Is Already Opened!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Select User To Edit!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvUserList.SelectedItems.Count != 0)
            {
                DialogResult dialog = MessageBox.Show("Are You Sure To Delete The Selected Record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialog == DialogResult.Yes)
                {
                    GlobalsCodeDAO.toSaveInAuditTrail("toDeleteUser:" + lvUserList.SelectedItems[0].SubItems[1].Text, forLoginVO.getUserLoggedIn.ToString(), forLoginVO.getUserLoggedIn.ToString(), DateTime.Now, "frmBrowseUser");
                    forAddUserDAO.toDeleteUser(Convert.ToInt32(lvUserList.SelectedItems[0].Text));
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearchCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
