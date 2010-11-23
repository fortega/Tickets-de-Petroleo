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
    public partial class EmpresaMain : Form
    {
        private Operador operador;
        public EmpresaMain(Operador operador)
        {
            this.operador = operador;
            InitializeComponent();

            CargarDatos();
        }

        private void CargarDatos()
        {
            Empresa[] empresas = Empresa.Todos;
            gv.DataSource = empresas;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            EmpresaCrear frm = new EmpresaCrear();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Empresa seleccion = (Empresa)gv.SelectedRows[0].DataBoundItem;
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
    }
}
