using System;
using System.Windows.Forms;
using POS.Globals;
using POS.foLogin;

namespace POS
{
    public partial class frmParameters : Form
    {
        public frmParameters()
        {
            InitializeComponent();
            GlobalsCodeDAO.parametersDetail = this;
        }

        private void frmParameters_Load(object sender, EventArgs e)
        {
            GlobalsCodeDAO.toRetrieveParameters();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GlobalsCodeDAO.toSaveParameters();
            GlobalsCodeDAO.toSaveInAuditTrail("toSaveParameters", forLoginVO.getUserLoggedIn.ToString(), forLoginVO.getUserLoggedIn.ToString(), DateTime.Now, "frmParameters");
        }
    }
}
