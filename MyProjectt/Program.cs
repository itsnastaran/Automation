using MyProjectt.AdminPanel;
using MyProjectt.Login;
using MyProjectt.User;
using MyProjectt.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectt
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
            Application.Run(new Frm_Login());
            switch (ListUserVariable.UserTypeCode)
            {
                case 1:
                    Frm_MainAdmin frm = new Frm_MainAdmin();
                    frm.ShowDialog();
                    break;

                case 2:
                    
                    Frm_MainUser FrmUser = new Frm_MainUser();
                    FrmUser.ShowDialog();
                    break;
                case 3:
                    
                    break;
                default:
                    System.Environment.Exit(1);
                    break;
            }
        }
    }
}
