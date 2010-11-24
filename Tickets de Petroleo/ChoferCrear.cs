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
    public partial class ChoferCrear : Form
    {
        private bool edicion = false;
        public ChoferCrear()
        {
            this.DialogResult = DialogResult.Abort;
            InitializeComponent();
            CargarEmpresas();
        }

        public ChoferCrear(Empresa empresa, int rut, string nombre)
            : this()
        {
            this.edicion = true;

            txtRut.Value = rut;
            txtRut.Enabled = false;
            txtNombre.Text = nombre;

            seleccionaEmpresa(empresa);

            this.Text = "Editar Chofer";
            btnCrear.Text = "Editar";
        }

        public ChoferCrear(Chofer chofer)
            : this(chofer.Empresa, chofer.Rut, chofer.Nombre)
        {
        }

        private void seleccionaEmpresa(Empresa empresa)
        {
            FormUtil.SeleccionaEmpresa(ref ddlEmpresas, empresa);
        }

        public void CargarEmpresas()
        {
            ddlEmpresas.Items.Clear();
            Empresa[] empresas = Empresa.Todos;
            ddlEmpresas.Items.AddRange(empresas);
            ddlEmpresas.SelectedIndex = 0;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Empresa empresa = (Empresa)ddlEmpresas.SelectedItem;
                int rut = int.Parse(txtRut.Value.ToString());
                string nombre = txtNombre.Text.Trim();

                Chofer chofer = new Chofer(empresa, rut, nombre);
                if (edicion)
                    chofer.Guardar();
                else
                    chofer.Crear();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
