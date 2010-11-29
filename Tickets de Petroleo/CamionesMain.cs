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
    public partial class CamionesMain : Form
    {
        public CamionesMain()
        {
            InitializeComponent();

            CargarDatos();
        }

        public void CargarDatos()
        {
            Camion[] camiones = Camion.Todos;
            gv.DataSource = camiones;

            btnEditar.Enabled = btnBorrar.Enabled = (camiones.Length > 0 & Global.operador.Admin);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Camion seleccionado = (Camion)gv.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show("Desea borrar \"" + seleccionado.Patente + "\"?",
                "Borrar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                seleccionado.Borrar();
                CargarDatos();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CamionCrear frm = new CamionCrear();
            if (frm.ShowDialog() == DialogResult.OK)
                CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Camion seleccionado = (Camion)gv.SelectedRows[0].DataBoundItem;

            CamionCrear frm = new CamionCrear(seleccionado);
            if (frm.ShowDialog() == DialogResult.OK)
                CargarDatos();
        }
    }
}
