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
using DevExpress.XtraEditors.DXErrorProvider;

namespace MonoCT_e.UI.Vehicles
{
    public partial class VehicleForm : UserControlUtil
    {
        public VehicleForm()
        {
            InitializeComponent();
        }

        private void rgVehicleIsBusiness_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool b = Convert.ToBoolean(rgVehicleIsBusiness.EditValue);
            if (b)
            {
                cbCustomer.EditValue = null;
                cbCustomer.Enabled = false;

                this.validator.SetValidationRule(this.cbCustomer, null);
            }
            else
            {
                cbCustomer.Enabled = true;

                ConditionValidationRule cvr = new ConditionValidationRule();                
                cvr.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
                cvr.ErrorText = "Informe o proprietario";
                this.validator.SetValidationRule(this.cbCustomer, cvr);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
        }
    }
}
