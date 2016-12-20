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
        public VehicleForm(vehicle v)
        {
            InitializeComponent();
            if (v == null)
            {
                v = new vehicle() { business_id = Singleton.getCurrentBusiness().id };
                IsNew = true;
            }
            bdgVehicle.DataSource = v;
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

            try
            {
                vehicle v = ((vehicle)bdgVehicle.Current);
                v.Save();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("{0}\n\n{1}", ex.Message, ex.InnerException));
            }
            finally
            {
                if (this.MessageToSave("Veículo"))
                    desk.AddTabAndCloseCurrent(new VehicleForm(null), "Novo Veículo", false);
            }

        }
    }
}
