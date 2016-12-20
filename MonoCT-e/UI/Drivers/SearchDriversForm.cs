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

namespace MonoCT_e.UI.Drivers
{
    public partial class SearchDriversForm : UserControlUtil
    {
        public SearchDriversForm()
        {
            InitializeComponent();
            search();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            driver d = ((driver)bdgDrivers.Current);
            if (d != null)
            {
                DriverForm df = new DriverForm(d);
                desk.AddTab(df, "Edição de Motorista", true);
            }
        }

        void search(int type = 0)
        {
            string sql = String.Format("SELECT * FROM drivers WHERE business_id={0}", Singleton.getCurrentBusiness().id);
            if (type == 0)
               sql += "";
            else if(type == 1)
                sql += String.Format(" AND cpf='{0}'", tfCpf.Text);
            else if (type == 2)
                sql += String.Format(" AND full_name ILIKE '{0}'", driver.Concat(tfFullName.Text));

            sql += " ORDER BY full_name";
            bdgDrivers.DataSource = driver.Fetch(sql);
            Console.WriteLine(sql);
        }

        private void tfCpf_EditValueChanged(object sender, EventArgs e)
        {
            int lenth = tfCpf.Text.Replace("_", "").Replace(".", "").Replace("-", "").Length;
            if (lenth == 11)
            {
                search(1);
                tfFullName.Text = "";
            }
            else
                search(0);
        }

        private void tfFullName_EditValueChanged(object sender, EventArgs e)
        {
            if (tfFullName.Text.Length >= 3)
            {
                tfCpf.Text = "";
                search(2);
            }
            else
                search(0);
        }
    }
}
