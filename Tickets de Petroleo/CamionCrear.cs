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
    public partial class CamionCrear : Form
    {
        private bool edicion = false;
        public CamionCrear()
        {
            this.DialogResult = DialogResult.Abort;
            InitializeComponent();
            CargarEmpresas();
        }

        public CamionCrear(Camion camion) :
            this(camion.Empresa, camion.Patente)
        {
        }

        public CamionCrear(Empresa empresa, string patente) :
            this()
        {
            seleccionaEmpresa(empresa);


            txtPatente.Text = patente;
            txtPatente.Enabled = false;

            edicion = true;

            this.Text = "Editar Camion";
            btnCrear.Text = "Editar";
        }

        private void seleccionaEmpresa(Empresa empresa)
        {
            int i = 0;
            foreach (Empresa item in ddlEmpresa.Items)
            {
                if (empresa.Rut == item.Rut)
                    break;
                i++;
            }
            ddlEmpresa.SelectedIndex = i;
        }

        private void CargarEmpresas()
        {
            ddlEmpresa.Items.Clear();

            Empresa[] empresas = Empresa.Todos;
            ddlEmpresa.Items.AddRange(empresas);

            ddlEmpresa.SelectedIndex = 0;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Empresa empresa = (Empresa)ddlEmpresa.SelectedItem;
                string patente = txtPatente.Text.Trim();

                Camion camion = new Camion(empresa, patente);

                if (edicion)
                    camion.Guardar();
                else
                    camion.Crear();

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
