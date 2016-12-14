using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoCT_e.UI.Utils
{
    public class TabControlUtil
    {
        private DesktopForm desk = null;

        public TabControlUtil(DesktopForm d)
        {
            if (d == null)
            {
                throw new Exception("Obrigatório informar a Desktop atual, contate o Suporte");
            }
            desk = d;
        }
        public void AddTab(XtraUserControl userControl, string titleTab, bool newTab)
        {
            //estancia uma nova Tab passando os parametros
            XtraTabPage sysTabPage1 = new XtraTabPage();

            // mostra o botao de fechamento da Tab
            if (userControl.Name.Equals("WaringsPaymentsDayForm"))
                sysTabPage1.ShowCloseButton = DefaultBoolean.False;
            else
                sysTabPage1.ShowCloseButton = DefaultBoolean.True;

            //informa qual o Control
            sysTabPage1.Controls.Add((Control)userControl);

            //informa o nome do Control para comparações futuras
            sysTabPage1.Tag = userControl.Name;
            //informa o titulo da Tab
            sysTabPage1.Text = titleTab;

            // Inteiro necessario para saber se o Control ja existe na Tab
            int num = 0;

            // estancia um nova Tab caso ja exista o Control informado anteriormente e vincula a esta para usar futuramente
            XtraTabPage sysTabPage2 = new XtraTabPage();

            // verifica se ja existe
            foreach (XtraTabPage sysTabPage3 in desk.tabControl.TabPages)
            {
                // se existir vincula a Tab criada anteriormente, se nao existir nao faz nada
                if (sysTabPage3 == sysTabPage1 || sysTabPage3.Tag.Equals(sysTabPage1.Tag))
                {
                    ++num;
                    sysTabPage2 = sysTabPage3;
                }
            }

            // se o Control nao existir na Tab vincula ela, e da foco
            if (num == 0)
            {
                desk.tabControl.TabPages.Add(sysTabPage1);
                desk.tabControl.SelectedTabPage = sysTabPage1;
            }

            // caso existir mas newTab esteja TRUE remeve a atual e vincula a nova
            else if (newTab)
            {
                desk.tabControl.TabPages.Remove(sysTabPage2);
                desk.tabControl.TabPages.Add(sysTabPage1);
                desk.tabControl.SelectedTabPage = sysTabPage1;
            }

            // se existir e nao deseja vincular nova, apenas da foco
            else
                desk.tabControl.SelectedTabPage = sysTabPage2;
            //SplashScreenManager.CloseForm(false);
        }

        public void CloseSelectedPage()
        {
            if (desk.tabControl.TabPages.Count > 0)
                desk.tabControl.TabPages.Remove(desk.tabControl.SelectedTabPage);
        }

        private Point CenterUserControl(Control u)
        {
            // inicia um Point e executa o calculo da posição do Control
            Point point = new Point((desk.tabControl.ClientSize.Width - u.Width) / 2,
                (desk.tabControl.ClientSize.Height - u.Height) / 2 - 10);
            //retorna a posição
            return point;
        }

        // metodo responsavel por pegar todos os controls e centralizar
        public void CenterControlsInPanel()
        {
            // pega todas a TabPages 
            foreach (XtraTabPage cp in desk.tabControl.TabPages)
            {
                // pega os Controls da TabPage
                foreach (Control c in cp.Controls)
                {
                    // define o Location do Control, fornecido pelo metodo que calcula a posição
                    c.Location = CenterUserControl(c);
                }
            }
        }


    }
}
