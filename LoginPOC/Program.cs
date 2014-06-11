using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LoginPOC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login_Dialog_Form1());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login_Dialog_Form1 login = new Login_Dialog_Form1();
            if (login.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            Application.Run(new LandingView());
        }
    }
}
