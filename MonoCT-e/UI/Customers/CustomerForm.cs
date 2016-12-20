using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MonoCT_e.UI.Utils;
using MonoCT_e.Utils;

namespace MonoCT_e.UI.Customers
{
    public partial class CustomerForm : UserControlUtil
    {
        bool error = false;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void cbTypeDocument_SelectedIndexChanged(object sender, EventArgs e)
        {
            tfDocument.EditValue = "";
            tfDocument.Text = "";
            string s = cbTypeDocument.EditValue.ToString();
            if (s.Equals("CNPJ/Pessoa Juridica"))
            {
                tfDocument.Properties.Mask.EditMask = "00.000.000/0000-00";
            }
            else
            {
                tfDocument.Properties.Mask.EditMask = "000.000.000-00";
            }
            tfDocument.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            tfDocument.Enabled = true;
            tfDocument.SelectAll();
            tfDocument.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            if (error)
                return;
        }

        private void tfDocument_Leave(object sender, EventArgs e)
        {
            string d = tfDocument.EditValue.ToString();
            if (!String.IsNullOrEmpty(d))
            {
                if (!Validations.isCPFCNPJ(d, false))
                {
                    lbErrorDocument.Visible = true;
                    error = true;
                }
                else
                {
                    lbErrorDocument.Visible = false;
                    error = false;
                }
            }
        }
    }
}
