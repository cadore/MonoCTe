namespace MonoCT_e.UI
{
    partial class DesktopForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNewCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewVehicle = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchVehicle = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewDriver = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchDriver = new DevExpress.XtraBars.BarButtonItem();
            this.lbBusinessInfo = new DevExpress.XtraBars.BarStaticItem();
            this.lbUserInfo = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.AutoSizeItems = true;
            this.ribbon.Enabled = false;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnNewCustomer,
            this.btnSearchCustomer,
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnNewVehicle,
            this.btnSearchVehicle,
            this.btnNewDriver,
            this.btnSearchDriver,
            this.lbBusinessInfo,
            this.lbUserInfo});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(969, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Caption = "Novo  Cliente";
            this.btnNewCustomer.Id = 1;
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNewCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewCustomer_ItemClick);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Caption = "Buscar Clientes";
            this.btnSearchCustomer.Id = 2;
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSearchCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSearchCustomer_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Emitir Novo CT-e";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Gerenciar CT-e";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnNewVehicle
            // 
            this.btnNewVehicle.Caption = "Novo  Veiculo";
            this.btnNewVehicle.Id = 5;
            this.btnNewVehicle.Name = "btnNewVehicle";
            this.btnNewVehicle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNewVehicle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewVehicle_ItemClick);
            // 
            // btnSearchVehicle
            // 
            this.btnSearchVehicle.Caption = "Buscar Veiculos";
            this.btnSearchVehicle.Id = 6;
            this.btnSearchVehicle.Name = "btnSearchVehicle";
            this.btnSearchVehicle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSearchVehicle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSearchVehicle_ItemClick);
            // 
            // btnNewDriver
            // 
            this.btnNewDriver.Caption = "Novo  Motorista";
            this.btnNewDriver.Id = 7;
            this.btnNewDriver.Name = "btnNewDriver";
            this.btnNewDriver.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNewDriver.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewDriver_ItemClick);
            // 
            // btnSearchDriver
            // 
            this.btnSearchDriver.Caption = "Buscar  Motoristas";
            this.btnSearchDriver.Id = 8;
            this.btnSearchDriver.Name = "btnSearchDriver";
            this.btnSearchDriver.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSearchDriver.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSearchDriver_ItemClick);
            // 
            // lbBusinessInfo
            // 
            this.lbBusinessInfo.Caption = "Cadore Tecnologia";
            this.lbBusinessInfo.Id = 9;
            this.lbBusinessInfo.Name = "lbBusinessInfo";
            this.lbBusinessInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lbUserInfo
            // 
            this.lbUserInfo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lbUserInfo.Caption = "Cadore Tecnologia";
            this.lbUserInfo.Id = 10;
            this.lbUserInfo.Name = "lbUserInfo";
            this.lbUserInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "CT-e";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Emissões";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Cadastros";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNewCustomer);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSearchCustomer);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Clientes";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btnNewVehicle);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSearchVehicle);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Veiculos";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.btnNewDriver);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSearchDriver);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Motoristas";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.lbBusinessInfo);
            this.ribbonStatusBar.ItemLinks.Add(this.lbUserInfo);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 457);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(969, 31);
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 144);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(969, 313);
            this.tabControl.TabIndex = 5;
            this.tabControl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tabControl_ControlAdded);
            this.tabControl.Resize += new System.EventHandler(this.tabControl_Resize);
            // 
            // DesktopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 488);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.KeyPreview = true;
            this.Name = "DesktopForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Mono CT-e - Cadore Tecnologia v1.00 vCTe2.00";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.DesktopForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnNewCustomer;
        private DevExpress.XtraBars.BarButtonItem btnSearchCustomer;
        public DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnNewVehicle;
        private DevExpress.XtraBars.BarButtonItem btnSearchVehicle;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnNewDriver;
        private DevExpress.XtraBars.BarButtonItem btnSearchDriver;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarStaticItem lbBusinessInfo;
        private DevExpress.XtraBars.BarStaticItem lbUserInfo;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
    }
}