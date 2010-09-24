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

        private Form bombasForm, camionesForm, choferesForm, empresaForm, operadoresForm;

        public Main(Operador operador)
        {
            this.operador = operador;

            InitializeComponent();

            if (operador.Admin)
            {
                abrirFormsHijos();
            }
            else
            {
                desactivaMenu();
            }
        }

        private void abrirFormsHijos()
        {
            this.bombasForm = new BombasMain(operador);
            this.bombasForm.MdiParent = this;

            this.camionesForm = new CamionesMain(operador);
            this.camionesForm.MdiParent = this;

            this.choferesForm = new ChoferesMain(operador);
            this.choferesForm.MdiParent = this;

            this.empresaForm = new EmpresaMain(operador);
            this.empresaForm.MdiParent = this;

            this.operadoresForm = new OperadoresMain(operador);
            this.operadoresForm.MdiParent = this;
        }

        private void desactivaMenu()
        {
            menu.Enabled = false;
        }

        private void abrir_empresaMain(object sender, EventArgs e)
        {
            empresaForm.Show();
        }

        private void abrir_camionesMain(object sender, EventArgs e)
        {
            camionesForm.Show();
        }

        private void abrir_choferesMain(object sender, EventArgs e)
        {
            operadoresForm.Show();
        }

        private void abrir_operadoresMain(object sender, EventArgs e)
        {
            operadoresForm.Show();
        }
    }
}
