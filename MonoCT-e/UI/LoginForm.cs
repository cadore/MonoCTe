using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MonoCT_e.UI
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
            lbErrorPasswd.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lbErrorPasswd.Visible = false;
            if (!validator.Validate())
                return;

            string user = tfUser.EditValue.ToString();
            string passwd = tfPassword.EditValue.ToString();

            if (false)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lbErrorPasswd.Visible = true;
                tfPassword.EditValue = "";
                tfUser.SelectAll();
                tfUser.Focus();
                return;
            }
        }
    }
}