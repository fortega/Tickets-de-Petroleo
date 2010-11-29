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
    public partial class ChoferesMain : Form
    {
        public ChoferesMain()
        {
            InitializeComponent();

            CargarDatos();
        }

        private void CargarDatos()
        {
            Chofer[] choferes = Chofer.Todos;
            gv.DataSource = choferes;

            btnEditar.Enabled = btnBorrar.Enabled = (choferes.Length > 0 & Global.operador.Admin);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ChoferCrear frm = new ChoferCrear();
            if (frm.ShowDialog() == DialogResult.OK)
                CargarDatos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Chofer seleccionado = (Chofer)gv.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show("Desea borrar \"" + seleccionado.Nombre + "\"?",
                "Borrar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                seleccionado.Borrar();
                CargarDatos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Chofer seleccionado = (Chofer)gv.SelectedRows[0].DataBoundItem;
            ChoferCrear frm = new ChoferCrear(seleccionado);
            if (frm.ShowDialog() == DialogResult.OK)
                CargarDatos();
        }
    }
}
