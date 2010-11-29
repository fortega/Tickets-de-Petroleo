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
    public partial class OperadoresMain : Form
    {
        public OperadoresMain()
        {
            InitializeComponent();
            CargarDatos();
        }

        public void CargarDatos()
        {
            Operador[] operadores = Operador.Todos;
            gv.DataSource = operadores;

            btnEditar.Enabled = btnBorrar.Enabled = (operadores.Length > 0 & Global.operador.Admin);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Operador seleccion = (Operador)gv.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show("Desea borrar \"" + seleccion.Nombre + "\"?",
                "Confirmacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                seleccion.Borrar();
                CargarDatos();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            OperadoresCrear frm = new OperadoresCrear();
            if (frm.ShowDialog() == DialogResult.OK)
                CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Operador seleccion = (Operador)gv.SelectedRows[0].DataBoundItem;
            OperadoresCrear frm = new OperadoresCrear(seleccion);
            if (frm.ShowDialog() == DialogResult.OK)
                CargarDatos();
        }
    }
}
