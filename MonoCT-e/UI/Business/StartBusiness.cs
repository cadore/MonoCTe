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
            search();
            //this.Size = new Size(desk.tabControl.Size.Width + 300, desk.tabControl.Size.Height + 200);
        }       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Program.Exit(0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            showBusinessForm(null);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            business b = ((business)bdgBusiness.Current);
            if (b != null)
            {
                showBusinessForm(b);
            }
        }

        private void showBusinessForm(business b)
        {
            BusinessForm bf = new BusinessForm(b);
            DialogResult rs = bf.ShowDialog();
            if (rs == DialogResult.OK)
                search();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            business b = ((business)bdgBusiness.Current);
            if (b != null)
            {
                Singleton.setCurrentBusiness(b);
                desk.showInfoBusiness();
                desk.ribbon.Enabled = true;
                desk.CloseCurrentTab();
            }
        }

        private void search(int type = 0)
        {
            if(type == 0)
                bdgBusiness.DataSource = business.Fetch("ORDER BY corporate_name");
            else if(type == 1)
                bdgBusiness.DataSource = business.Fetch("WHERE cnpj=@0", tfCnpj.Text);
            else if (type == 2)
            {
                bdgBusiness.DataSource = business.Fetch("SELECT * FROM business WHERE corporate_name ILIKE @0"
                + " UNION SELECT * FROM business WHERE fantasy_name ILIKE @0 ORDER BY corporate_name, fantasy_name",
                business.Concat(tfName.Text));
            }
        }

        private void tfCnpj_EditValueChanged(object sender, EventArgs e)
        {
            tfName.Text = "";
            int lenth = tfCnpj.Text.Replace("_", "").Replace(".", "").Replace("/", "").Replace("-", "").Length;
            if (lenth == 14)
                search(1);
            else if (lenth == 0)
                search();
        }

        private void tfName_EditValueChanged(object sender, EventArgs e)
        {
            tfCnpj.Text = "";
            int lenth = tfName.Text.Length;
            if (lenth >= 3)
                search(2);
            else
                search();
        }
    }
}
