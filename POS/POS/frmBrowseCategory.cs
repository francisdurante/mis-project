using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.forBrowseCategory;
using POS.foLogin;
using POS.Globals;

namespace POS
{
    public partial class frmBrowseCategory : Form
    {
        public frmBrowseCategory()
        {
            InitializeComponent();
            forBrowseCatergoryDAO.browseCatergoryListView = this;
            frmAddCategory.browseCategoryListView = this;
        }

        private void frmBrowseCategory_Load(object sender, EventArgs e)
        {
            forBrowseCatergoryDAO.toRetrieveCategory(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            forBrowseCatergoryDAO.toRetrieveCategory(txtSearch.Text);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmAddCategory"];
            if (f == null)
            {
                forBrowseCategoryVO.setFunctionFor = 1;
                frmAddCategory fac = new frmAddCategory();
                fac.Text = "Add categoryr";
                fac.MdiParent = MdiParent;
                fac.Show();
            }
            else
            {
                MessageBox.Show("The Add Category Form is Already Opened!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if(lvCategory.SelectedItems.Count != 0)
            {
                Form f = Application.OpenForms["frmAddCategory"];
                if (f == null)
                {
                    forBrowseCategoryVO.setFunctionFor = 2;
                    frmAddCategory fac = new frmAddCategory();
                    fac.Text = "Edit Category";
                    fac.MdiParent = MdiParent;
                    fac.Show();
                }
                else
                {
                    MessageBox.Show("The Edit Category Form is Already Opened!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Select Item To Edit!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lvCategory_DoubleClick(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count != 0)
            {
                Form f = Application.OpenForms["frmAddCategory"];
                if (f == null)
                {
                    forBrowseCategoryVO.setFunctionFor = 2;
                    frmAddCategory fac = new frmAddCategory();
                    fac.Text = "Edit Category";
                    fac.MdiParent = MdiParent;
                    fac.Show();
                }
                else
                {
                    MessageBox.Show("The Edit Category Form is Already Opened!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are You Sure You Want To Delete The Selected Item?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                GlobalsCodeDAO.toSaveInAuditTrail("toDeleteCategory:" + lvCategory.SelectedItems[0].SubItems[1].Text, forLoginVO.getUserLoggedIn.ToString(), forLoginVO.getUserLoggedIn.ToString(), DateTime.Now, "frmBrowseCategory");
                forBrowseCatergoryDAO.toDeleteCategory(Convert.ToInt32(lvCategory.SelectedItems[0].Text));
            }
        }
    }
}
