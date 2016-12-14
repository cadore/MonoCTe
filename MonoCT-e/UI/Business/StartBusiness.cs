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
    public partial class StartBusiness : UserControlUtil
    {
        public StartBusiness()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Program.Exit(0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BusinessForm bf = new BusinessForm();
            DialogResult rs = bf.ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
