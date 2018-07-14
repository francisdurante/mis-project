using System;
using System.Windows.Forms;
using POS.forBrowseCategory;
using POS.foLogin;
using POS.Globals;

namespace POS
{
    public partial class frmAddCategory : Form
    {
        public frmAddCategory()
        {
            InitializeComponent();
        }
        int id = 0;
        string currentCatName = "";
        string currentStatus = "";
        public static frmBrowseCategory browseCategoryListView { get; set; }
        private void frmAddCategory_Load(object sender, EventArgs e)
        {
            if(forBrowseCategoryVO.getFunctionFor == 1)
            {
                rbActive.Checked = true;
                gbStatus.Enabled = false;
            }
            else
            {
                ListViewItem item = browseCategoryListView.lvCategory.SelectedItems[0];
                id = Convert.ToInt32(item.SubItems[0].Text);
                txtCategory.Text = item.SubItems[1].Text;
                currentCatName = txtCategory.Text;
                currentStatus = item.SubItems[2].Text;
                if(item.SubItems[2].Text == "ACTIVE")
                {
                    rbActive.Checked = true;
                }
                else
                {
                    rbInActive.Checked = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtCategory.Text != "")
            {
                if (forBrowseCategoryVO.getFunctionFor == 1)
                {
                    forBrowseCatergoryDAO.toSaveNewCategory(txtCategory.Text, forLoginVO.getUserLoggedIn); 
                    GlobalsCodeDAO.toSaveInAuditTrail("ToAddCategory:" + txtCategory.Text.ToUpper(), forLoginVO.getUserLoggedIn.ToString(), forLoginVO.getUserLoggedIn.ToString(), DateTime.Now, "frmCategory");
                    Close();
                }
                else
                {
                    string status = "";
                    if (rbActive.Checked)
                    {
                        status = "ACTIVE";
                    }
                    else
                    {
                        status = "IN-ACTIVE";
                    }
                    if (forBrowseCatergoryDAO.toSaveEditCategory(id, txtCategory.Text, status))
                    {
                        if(txtCategory.Text != currentCatName)
                        {
                            GlobalsCodeDAO.toSaveInAuditTrail("ToEditCategoryFrom" + currentCatName.ToUpper() + "To" + txtCategory.Text.ToUpper(), forLoginVO.getUserLoggedIn.ToString(), forLoginVO.getUserLoggedIn.ToString(), DateTime.Now, "frmCategory");
                        }
                        if(currentStatus != status)
                        {
                            GlobalsCodeDAO.toSaveInAuditTrail("ToEditCategoryStatusFrom" + currentStatus.ToUpper() + "To" + status.ToUpper(), forLoginVO.getUserLoggedIn.ToString(), forLoginVO.getUserLoggedIn.ToString(), DateTime.Now, "frmCategory");
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
    }
}
