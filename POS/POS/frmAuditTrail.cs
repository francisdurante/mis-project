using System;
using System.Windows.Forms;
using POS.Globals;

namespace POS
{
    public partial class frmAuditTrail : Form
    {
        public frmAuditTrail()
        {
            InitializeComponent();
            GlobalsCodeDAO.auditTrailListView = this;
        }

        private void frmAuditTrail_Load(object sender, EventArgs e)
        {
            GlobalsCodeDAO.toRetrieveAuditTrail(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GlobalsCodeDAO.toRetrieveAuditTrail(txtSearch.Text);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
