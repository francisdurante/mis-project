using System;
using System.Windows.Forms;
using POS.forMainPOS;
using POS.forTransaction;
using POS.Globals;
using POS.foLogin;

namespace POS
{
    public partial class frmAmountRender : Form
    {
        public frmAmountRender()
        {
            InitializeComponent();
        }
        public static frmMainPOS POSListView { get; set; }

        private void txtAmountGiven_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmAmountRender_Load(object sender, EventArgs e)
        {
            lblTotalAmountContent.Text = forMainPOSVO.getTotalAmount.ToString();
        }

        private void txtAmountGiven_TextChanged(object sender, EventArgs e)
        {
            if (txtAmountGiven.Text == "")
            {
                txtAmountGiven.Text = "0";
            }
            lblChangeContent.Text = (Convert.ToDouble(txtAmountGiven.Text) - Convert.ToDouble(lblTotalAmountContent.Text)).ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string[] itemCode = { };
            int[] qty = {};
            double[] totalAmount = {};
            if(Convert.ToDouble(lblTotalAmountContent.Text) > Convert.ToDouble(txtAmountGiven.Text))
            {
                MessageBox.Show("The Total Amount is Bigger than Given Amount!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                itemCode = new string[POSListView.lvItemList.Items.Count];
                qty = new int[POSListView.lvItemList.Items.Count];
                totalAmount = new double[POSListView.lvItemList.Items.Count];

                for (int x = 0; x < POSListView.lvItemList.Items.Count; x++)
                {
                    ListViewItem item = POSListView.lvItemList.Items[x];
                    itemCode[x] = item.SubItems[0].Text;
                    qty[x] = Convert.ToInt32(item.SubItems[2].Text);
                    totalAmount[x] = Convert.ToDouble(item.SubItems[4].Text);
                }

                if (forTransactionDAO.toPostTransactionsGetTransactionID(itemCode, forTransactionVO.getTransactionCode, Convert.ToDouble(lblTotalAmountContent.Text)))
                {
                    if(forTransactionDAO.toPostTransactionDetails(itemCode, qty, totalAmount))
                    {
                        forTransactionDAO.toDeductInInventory(itemCode, qty);
                        MessageBox.Show("Transaction Saved Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GlobalsCodeDAO.toSaveInAuditTrail("Transaction : " + forTransactionVO.getTransactionCode, forLoginVO.getUserLoggedIn.ToString(), forLoginVO.getUserLoggedIn.ToString(), DateTime.Now, "frmMainPOS");
                        Close();
                        POSListView.lvItemList.Items.Clear();
                        POSListView.lblTotalContent.Text = "0.00";
                        POSListView.grandTotal = 0.00;
                        POSListView.lblTransactionNumberContent.Text = GlobalsCodeDAO.ifExistingTransactionCode(GlobalsCodeDAO.toGenerateTransactionCode(10));
                    }
                }
            }
        }
    }
}
