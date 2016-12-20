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

namespace MonoCT_e.UI.Drivers
{
    public partial class DriverForm : UserControlUtil
    {
        bool error = false;
        public DriverForm(driver d)
        {
            InitializeComponent();
            if (d == null)
            {
                d = new driver() { business_id = Singleton.getCurrentBusiness().id };
                IsNew = true;
            }
            bdgDriver.DataSource = d;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!validator.Validate())
                return;
            if (error)
                return;
            try
            {
                driver d = ((driver)bdgDriver.Current);
                d.Save();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("{0}\n\n{1}", ex.Message, ex.InnerException));
            }
            finally
            {
                if (this.MessageToSave("Motorista"))
                    desk.AddTabAndCloseCurrent(new DriverForm(null), "Novo Motorista", false);
            }
        }

        private void tfCpf_Leave(object sender, EventArgs e)
        {
            string cpf = tfCpf.EditValue.ToString();

            if (!String.IsNullOrEmpty(cpf))
            {
                if (!Validations.isCPFCNPJ(cpf, false))
                {
                    lbErrorCPF.Visible = true;
                    tfCpf.ForeColor = Color.Red;
                    error = true;
                    return;
                }
            }
            error = false;
            lbErrorCPF.Visible = false;
            tfCpf.ForeColor = Color.Black;
        }
    }
}
