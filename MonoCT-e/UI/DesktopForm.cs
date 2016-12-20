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
using MonoCT_e.UI.Drivers;
using DevExpress.XtraTab;
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace MonoCT_e.UI
{
    public partial class DesktopForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        TabControlUtil tabUtil;
        public DesktopForm()
        {
            InitializeComponent();            
            tabUtil = new TabControlUtil(this);
            UserControlUtil.desk = this;
            ribbonPages(false);
            SplashScreenManager.CloseForm(false, 500, this);
        }

        public void showInfoBusiness()
        {
            Thread.Sleep(700);
            business b = Singleton.getCurrentBusiness();
            string infoB = String.Format("Emitente: {0}-{1}   CNPJ: {2}   IE: {3}", b.id, b.corporate_name, b.cnpj, b.ie);
            lbBusinessInfo.Caption = infoB;
        }
        private void DesktopForm_Shown(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            DialogResult rs = lf.ShowDialog();
            if (rs == DialogResult.OK)
            {
                ribbonPages(true);
                AddTab(new StartBusiness(), "Selecionar Emitente", false);
                user u = Singleton.getCurrentUser();
                string infoU = String.Format("Bem vindo {0}, seu ultimo acesso foi em {1:dd/MM/yyyy} ás {1:HH:mm}",
                    u.full_name, u.last_acess);
                lbUserInfo.Caption = infoU;
                lbBusinessInfo.Caption = "Escolha um Emitente";

            }
            else
                Environment.Exit(0);
        }
        void ribbonPages(bool b)
        {
            ribbonPage2.Visible = b;
            ribbonPage1.Visible = b;
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
            resize();
        }

        private void resize()
        {
            if (tabUtil != null)
            {
                tabUtil.CenterControlsInPanel();
            }
        }

        private void tabControl_Resize(object sender, EventArgs e)
        {
            resize();
        }

        private void btnNewCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(new CustomerForm(), "Novo Cliente", false);
        }

        private void btnSearchCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(new SearchCustomersForm(), "Buscar Clientes", false);
        }

        private void btnNewVehicle_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(new VehicleForm(), "Novo Veiculo", false);
        }

        private void btnNewDriver_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(new DriverForm(null), "Novo Motoristas", false);
        }

        private void btnSearchDriver_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddTab(new SearchDriversForm(), "Buscar Motoristas", false);
        }

        private void btnSearchVehicle_ItemClick(object sender, ItemClickEventArgs e)
        {
            //AddTab(new SearchVehiclesForm(), "Buscar Veiculo", false);
        }
    }
}