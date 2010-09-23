using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tickets_de_Petroleo.Mantenedores
{
    public partial class OperadoresMain : Form
    {
        private Operador operador;
        public OperadoresMain(Operador operador)
        {
            this.operador = operador;
            InitializeComponent();
        }
    }
}
