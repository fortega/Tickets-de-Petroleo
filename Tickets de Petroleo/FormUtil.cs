using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tickets_de_Petroleo
{
    public class FormUtil
    {
        public static void SeleccionaEmpresa(ref ComboBox cb, Empresa empresa)
        {
            int i = 0;
            foreach (Empresa item in cb.Items)
            {
                if (empresa.Rut == item.Rut)
                    break;
                i++;
            }
            cb.SelectedIndex = i;
        }
    }
}
