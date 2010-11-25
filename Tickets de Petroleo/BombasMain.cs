using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tickets_de_Petroleo
{
    public partial class BombasMain : Form
    {
        private Operador operador;
        public BombasMain(Operador operador)
        {
            this.operador = operador;
            InitializeComponent();
        }

        private void CargarDatos()
        {
            Bomba[] bombas = Bomba.Todos;
            gv.DataSource = bombas;
        }
    }
}
