using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SimpleLogin
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
            //Application.Run(new Login());
            //var login = new Login();
            //if (login.ShowDialog() == DialogResult.OK)
            //{
            //    // successfully login
            //    // do something...
            //}
            //else
            //{
                
            //}

            var login = new LoginForm();
            if (login.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            Application.Run(new HomeView());
        }
    }
}
