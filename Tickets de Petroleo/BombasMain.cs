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
        public BombasMain()
        {
            InitializeComponent();

            CargarDatos();
        }

        private void CargarDatos()
        {
            Bomba[] bombas = Bomba.Todos;
            gv.DataSource = bombas;

            btnBorrar.Enabled = btnEditar.Enabled = (bombas.Length > 0 & Global.operador.Admin);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            BombaCrear frm = new BombaCrear();
            if (frm.ShowDialog() == DialogResult.OK)
                CargarDatos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Bomba seleccion = (Bomba)gv.SelectedRows[0].DataBoundItem;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Bomba seleccion = (Bomba)gv.SelectedRows[0].DataBoundItem;
            BombaCrear frm = new BombaCrear(seleccion);
            if (frm.ShowDialog() == DialogResult.OK)
                CargarDatos();
        }
    }
}
