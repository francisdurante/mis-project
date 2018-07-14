using System;
using System.Windows.Forms;
using POS.forTransaction;
using POS.forOverride;
using POS.forMainPOS;
using POS.Globals;

namespace POS
{
    public partial class frmMainPOS : Form
    {
        public frmMainPOS()
        {
            InitializeComponent();
            forMainPOSDAO.mainPOSListView = this;
            frmAmountRender.POSListView = this;
        }

        public double grandTotal = 0.00;
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Equals("") || txtQuantity.Text.Equals("0"))
            {
                txtQuantity.Text = "1";
                txtQuantity.SelectionStart = txtQuantity.Text.Length;
            }
        }

        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (forTransactionDAO.toRetrieveItem(txtItemCode.Text))
                {
                    if (forTransactionVO.getItemQuantity > Convert.ToInt32(txtQuantity.Text))
                    {
                        double totalPrice = (forTransactionVO.getPriceAt) * (Convert.ToInt32(txtQuantity.Text));
                        ListViewItem lv = new ListViewItem(txtItemCode.Text);
                        lv.SubItems.Add(forTransactionVO.getItemName);
                        lv.SubItems.Add(txtQuantity.Text);
                        lv.SubItems.Add(forTransactionVO.getPriceAt.ToString());
                        lv.SubItems.Add(totalPrice.ToString());
                        lvItemList.Items.Add(lv);
                        grandTotal = grandTotal + totalPrice;

                        txtItemCode.Clear();
                        lblTotalContent.Text = grandTotal.ToString();
                        txtQuantity.Text = "1";
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("The item you trasact is out of stock\nPlease check the inventory\nDo you want to check?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if(dialog == DialogResult.Yes)
                        {
                            Form f = Application.OpenForms["frmInventoryCheck"];
                            if(f == null)
                            {
                                frmInventoryCheck fic = new frmInventoryCheck();
                                fic.MdiParent = MdiParent;
                                fic.Show();
                            }
                            else
                            {
                                MessageBox.Show("The Item Check Form is Already Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }
        
        private void lvItemList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvItemList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmItemList fil = new frmItemList();
                fil.MdiParent = MdiParent;
                fil.Show();
            }
            if (e.KeyCode == Keys.F2)
            {
                if (lvItemList.SelectedItems.Count != 0)
                {
                    forOverrideVO.setOverrideFor = "Item Void";
                    forOverrideVO.setOverrideNeedPosition = "SUPERVISOR";
                    forOverrideVO.setListviewItemIndex = lvItemList.FocusedItem.Index;
                    frmOverride fo = new frmOverride();
                    fo.Text = "Override Item Void";
                    fo.frmMainPOSListview = this;
                    fo.MdiParent = MdiParent;
                    fo.Show();
                }
                else
                {
                    MessageBox.Show("Please Select Item to Void!", "Item Void", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnInquireItem_Click(object sender, EventArgs e)
        {
            frmItemList fil = new frmItemList();
            fil.MdiParent = MdiParent;
            fil.Show();
        }

        private void btnItemVoid_Click(object sender, EventArgs e)
        {
            if (lvItemList.SelectedItems.Count != 0)
            {
                forOverrideVO.setOverrideFor = "Item Void";
                forOverrideVO.setOverrideNeedPosition = "SUPERVISOR";
                forOverrideVO.setListviewItemIndex = lvItemList.FocusedItem.Index;
                frmOverride fo = new frmOverride();
                fo.Text = "Override Item Void";
                fo.frmMainPOSListview = this;
                fo.MdiParent = MdiParent;
                fo.Show();
            }
            else
            {
                MessageBox.Show("Please Select Item to Void!", "Item Void", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void toVoidItem(int selectedItem)
        {
            ListViewItem item = lvItemList.SelectedItems[0];
            grandTotal = grandTotal - Convert.ToDouble(item.SubItems[4].Text);
            lblTotalContent.Text = grandTotal.ToString();
            lvItemList.SelectedItems[selectedItem].Remove();
        }

        private void frmMainPOS_Load(object sender, EventArgs e)
        {
            lblTransactionNumberContent.Text = GlobalsCodeDAO.ifExistingTransactionCode(GlobalsCodeDAO.toGenerateTransactionCode(10));
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if(lvItemList.Items.Count > 0)
            {
                forMainPOSVO.setTotalAmount = Convert.ToDouble(lblTotalContent.Text);
                forMainPOSVO.setTotalItemCount = lvItemList.Items.Count;
                forTransactionVO.setTransactionCode = lblTransactionNumberContent.Text;
                Form f = Application.OpenForms["frmAmountRender"];
                if (f == null)
                {
                    frmAmountRender far = new frmAmountRender();
                    far.MdiParent = MdiParent;
                    far.Show();
                }
                else
                {
                    MessageBox.Show("The Amount Render Form is Already Open!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No Item/s to be Transact!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
