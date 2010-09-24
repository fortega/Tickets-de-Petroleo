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

            if (!operador.Admin)
            {
                desactivaMenu();
            }
        }

        private void desactivaMenu()
        {
            menu.Enabled = false;
        }

        private void abrir_empresaMain(object sender, EventArgs e)
        {
            EmpresaMain empresaForm = new EmpresaMain(operador);
            empresaForm.ShowDialog();
        }

        private void abrir_camionesMain(object sender, EventArgs e)
        {
            CamionesMain camionesForm = new CamionesMain(operador);
            camionesForm.ShowDialog();
        }

        private void abrir_choferesMain(object sender, EventArgs e)
        {
            ChoferesMain choferesMain = new ChoferesMain(operador);
            choferesMain.ShowDialog();
        }

        private void abrir_operadoresMain(object sender, EventArgs e)
        {
            OperadoresMain operadoresForm = new OperadoresMain(operador);
            operadoresForm.ShowDialog();
        }

        private void abrir_bombasMain(object sender, EventArgs e)
        {
            BombasMain bombasForm = new BombasMain(operador);
            bombasForm.ShowDialog();

        }
    }
}
