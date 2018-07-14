using System;
using System.Windows.Forms;
using POS.forInventoryCheck;

namespace POS
{
    public partial class frmInventoryCheck : Form
    {
        public frmInventoryCheck()
        {
            InitializeComponent();
            forInventoryCheckVO.frmInventoryCheckDetails = this;
        }

        private void frmInventoryCheck_Load(object sender, EventArgs e)
        {
            forInventoryCheckDAO.retrieveItem(txtSearch.Text);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                forInventoryCheckDAO.retrieveItem(txtSearch.Text);
            }
        }
    }
}
