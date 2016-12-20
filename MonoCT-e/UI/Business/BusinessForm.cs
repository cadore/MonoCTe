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

namespace MonoCT_e.UI.Business
{
    public partial class BusinessForm : DevExpress.XtraEditors.XtraForm
    {
        bool error = false;
        bool IsNew = false;
        public BusinessForm(business b)
        {
            InitializeComponent();
            bdgStates.DataSource = state.Fetch("ORDER BY name");
            //bdgCity.DataSource = city.Fetch("ORDER BY name");

            address ad = null;
            if (b == null)
            {
                IsNew = true;
                b = new business();
                ad = new address();
            }
            else
            {
                ad = address.SingleOrDefault(b.address_id);
            }
            bdgBusiness.DataSource = b;
            bdgAddress.DataSource = ad;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validatorTabPrincipal.Validate())
            {
                tab.SelectedTabPageIndex = 0;
                return;
            }
            if (!validatorSystem.Validate())
            {
                tab.SelectedTabPageIndex = 2;
                return;
            }

            if (IsNew)
                if (!Unique.CnpjBusinessIsUnique(((business)bdgBusiness.Current)))
                {
                    tab.SelectedTabPageIndex = 0;
                    tfCnpj.SelectAll();
                    tfCnpj.Focus();
                    XtraMessageBox.Show("CNPJ ja encontra-se cadastrado, verifique!");
                    return;
                }

            if (error)
                return;

            try
            {
                business b = ((business)bdgBusiness.Current);
                address a = ((address)bdgAddress.Current);
                a.Save();
                b.address_id = a.id;
                b.Save();
                XtraMessageBox.Show(String.Format("Emitente {0} com sucesso!{1}",
                    IsNew ? "cadastrado" : "atualizado",
                    IsNew ? "\n\nFavor encaminhar o certificado digital para o email 'cadore.servicos@gmail.com'\nContendo o nome do cliente/escritório e CNPJ do emitente!" : ""));
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("{0}\n\n{1}", ex.Message, ex.InnerException));
            }
        }

        private void tfCnpj_Leave(object sender, EventArgs e)
        {
            try
            {
                string d = tfCnpj.EditValue.ToString();
                if (!String.IsNullOrEmpty(d))
                {
                    if (!Validations.isCPFCNPJ(d, false))
                    {
                        lbErrorCnpj.Visible = true;
                        error = true;
                    }
                    else
                    {
                        lbErrorCnpj.Visible = false;
                        error = false;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("{0}\n\n{1}", ex.Message, ex.InnerException));
            }
        }

        private void cbState_EditValueChanged(object sender, EventArgs e)
        {
            if (cbState.EditValue != null && Convert.ToInt64(cbState.EditValue) > 0)
            {
                bdgCity.DataSource = city.Fetch("WHERE state_id=@0 ORDER BY name", cbState.EditValue);
            }
        }
    }
}
