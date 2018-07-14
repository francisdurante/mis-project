using System;
using System.Windows.Forms;
using POS.forItemLists;

namespace POS
{
    public partial class frmItemList : Form
    {
        public frmItemList()
        {
            InitializeComponent();
            forItemListDAO.itemListListView = this;
        }

        private void frmItemList_Load(object sender, EventArgs e)
        {
            forItemListDAO.toRetrieveItems();
        }

        private void txtSearchCode_TextChanged(object sender, EventArgs e)
        {
            forItemListDAO.toSearchItem(txtSearchCode.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
