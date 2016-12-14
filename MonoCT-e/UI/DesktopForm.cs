using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using MonoCT_e.UI.Utils;
using MonoCT_e.UI.Customers;
using MonoCT_e.UI.Business;
using MonoCT_e.UI.Vehicles;

namespace MonoCT_e.UI
{
    public partial class DesktopForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static long idCurrentBusiness { get; private set; }

        TabControlUtil tabUtil;
        public DesktopForm()
        {
            InitializeComponent();
            tabUtil = new TabControlUtil(this);
            UserControlUtil.desk = this;
            //ribbon.Enabled = false;
            AddTab(new StartBusiness(), "Selecionar Emitente", false);
        }
        public static void setCurrentBusiness(long _id)
        {
            idCurrentBusiness = _id;
        }
        public void AddTab(XtraUserControl userControl, string titleTab, bool newTab)
        {
            tabUtil.AddTab(userControl, titleTab, newTab);
        }

        public void AddTabAndCloseCurrent(XtraUserControl userControl, string titleTab, bool newTab)
        {
            tabUtil.CloseSelectedPage();
            tabUtil.AddTab(userControl, titleTab, newTab);
        }

        public void CloseCurrentTab()
        {
            tabUtil.CloseSelectedPage();
        }

        private void tabControl_ControlAdded(object sender, ControlEventArgs e)
        {
            if (tabUtil != null)
                tabUtil.CenterControlsInPanel();
        }

        private void tabControl_Resize(object sender, EventArgs e)
        {
            if (tabUtil != null)
                tabUtil.CenterControlsInPanel();
        }

        private void btnNewCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(new CustomerForm(), "Novo Cliente", false);
        }

        private void btnSearchCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnNewVehicle_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(new VehicleForm(), "Novo Veiculo", false);
        }
    }
}