using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tickets_de_Petroleo
{
    public partial class IngresoControl : UserControl
    {
        public IngresoControl()
        {
            InitializeComponent();
        }

        private void cargarBombas()
        {
            Bomba[] bombas = Bomba.Todos;

            ddlBombas.Items.Clear();
            ddlBombas.Items.AddRange(bombas);

            ddlBombas.SelectedIndex = 0;
        }
    }
}
