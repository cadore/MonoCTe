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

namespace MonoCT_e.UI.Business
{
    public partial class BusinessForm : DevExpress.XtraEditors.XtraForm
    {
        public BusinessForm()
        {
            InitializeComponent();
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
        }
    }
}
