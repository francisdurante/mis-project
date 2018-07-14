using System;
using System.Windows.Forms;
using POS.forAddItem;

namespace POS
{
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
            forAddItemsVO.frmAddItemContent = this;
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            if (forAddItemDAO.toRetrieveItemCategory() == 2)
            {
                DialogResult dialogresult = MessageBox.Show("Please Insert Item Category First", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogresult == DialogResult.OK)
                {
                    Form f = Application.OpenForms["frmAddCategory"];
                    if (f == null)
                    {
                        frmAddCategory fac = new frmAddCategory();
                        fac.MdiParent = MdiParent;
                        fac.Show();
                    }
                }
            }
        }

        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(!forAddItemDAO.ExistingItem(txtItemCode.Text,1))
                {
                    DialogResult dialogbox = MessageBox.Show("This item is not in Database do you want to add it?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialogbox != DialogResult.Yes)
                    {
                        txtItemCode.Clear();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            forAddItemDAO.toAddItem(txtItemCode.Text, txtItemName.Text, cbCategory.Text, Convert.ToDouble(txtItemPrice.Text), Convert.ToInt32(txtQuantity.Text));
        }

        private void txtItemPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtItemCode_Leave(object sender, EventArgs e)
        {
            if (!forAddItemDAO.ExistingItem(txtItemCode.Text,1))
            {
                DialogResult dialogbox = MessageBox.Show("This item is not in Database do you want to add it?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogbox != DialogResult.Yes)
                {
                    txtItemCode.Clear();
                }
            }
        }
    }
}
