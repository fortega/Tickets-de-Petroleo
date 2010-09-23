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
    public partial class Main : Form
    {
        private Operador operador;
        public Main(Operador operador)
        {
            this.operador = operador;
            InitializeComponent();
        }

        private void abrir_empresaMain(object sender, EventArgs e)
        {
            Mantenedores.EmpresaMain empresaForm = new Tickets_de_Petroleo.Mantenedores.EmpresaMain(operador);
            empresaForm.ShowDialog();
        }

        private void abrir_camionesMain(object sender, EventArgs e)
        {
            Mantenedores.CamionesMain camionesForm = new Tickets_de_Petroleo.Mantenedores.CamionesMain(operador);
            camionesForm.ShowDialog();
        }

        private void abrir_choferesMain(object sender, EventArgs e)
        {
            Mantenedores.OperadoresMain operadoresForm = new Tickets_de_Petroleo.Mantenedores.OperadoresMain(operador);
            operadoresForm.ShowDialog();
        }

        private void abrir_operadoresMain(object sender, EventArgs e)
        {
            Mantenedores.OperadoresMain operadoresForm = new Tickets_de_Petroleo.Mantenedores.OperadoresMain(operador);
            operadoresForm.ShowDialog();
        }
    }
}
