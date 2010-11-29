using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tickets_de_Petroleo
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

            if (Properties.Settings.Default.autouser_active)
            {
                Global.operador = new Operador(Properties.Settings.Default.autouser_nombre,
                        Properties.Settings.Default.autouser_passwd);
                Application.Run(new Main());
            }
            else
            {
                Application.Run(new LogIn());
            }
        }
    }
}
