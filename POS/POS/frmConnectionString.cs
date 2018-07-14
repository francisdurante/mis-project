using System;
using System.IO;
using System.Windows.Forms;
using POS.Globals;
namespace POS
{
    public partial class frmConnectionString : Form
    {
        public frmConnectionString()
        {
            InitializeComponent();
        }

        private void frmConnectionString_Load(object sender, EventArgs e)
        {
            if (GlobalsCodeDAO.RetrieveConnectionString())
            {
                txtServerIp.Text            = GlobalCodeVO.getServerIp;
                txtDatabaseName.Text        = GlobalCodeVO.getDatabaseName;
                txtDatabaseUser.Text        = GlobalCodeVO.getDatabaseUser;
                txtDatabasePassword.Text    = GlobalCodeVO.getDatabasePassword;
            }
            else
            {
                MessageBox.Show("Please Create a Connection String!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmConnectionString fcs = new frmConnectionString();
                fcs.Show();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtServerIp.Text=="" || txtDatabaseName.Text == "" || txtDatabaseUser.Text =="" || txtDatabasePassword.Text == "")
            {
                MessageBox.Show("Please Complete The Information Needed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GlobalsCodeDAO.toSaveConnectionString(txtServerIp.Text, txtDatabaseName.Text, txtDatabaseUser.Text, txtDatabasePassword.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GlobalsCodeDAO.toTestConnection(txtServerIp.Text, txtDatabaseName.Text, txtDatabaseUser.Text, txtDatabasePassword.Text).Equals(1))
            {
                MessageBox.Show("Connection OK!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Connection Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
