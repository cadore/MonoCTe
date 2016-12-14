using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using MonoCT_e.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoCT_e
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Office 2013"); //Office 2013 //The Asphalt World
            //verefyProcesses();
            //SplashScreenManager.ShowForm(null, typeof(SplashScreenForm), false, false, false);
            //Application.Run(new DesktopForm());
            //initializeCfg();
            login();
        }

        private static void login()
        {
            LoginForm lf = new LoginForm();
            DialogResult dr = lf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Application.Run(new DesktopForm());
            }
            else
            {
                Exit(1);
            }
        }
        public static void Exit(int exit)
        {
            Environment.Exit(exit);
        }
    }
}
