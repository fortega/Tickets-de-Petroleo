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
                Application.Run(new Main(
                    new Operador(Properties.Settings.Default.autouser_nombre,
                        Properties.Settings.Default.autouser_passwd)));
            }
            else
            {
                Application.Run(new LogIn());
            }
        }
    }
}
