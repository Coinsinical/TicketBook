using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketBook
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            LoginControl loginControl = loginForm.Controls["form_container"].Controls["LoginControl"] as LoginControl;
            if (loginControl != null)
            {
                if (loginControl.RoleChoice == 1)
                {
                    Application.Run(new AdminForm());
                }
                else if (loginControl.RoleChoice == 0)
                {
                    Application.Run(new UserForm());
                }
                else
                {
                    Application.Run(new UserForm());
                }
            }
            
        }
    }
}
