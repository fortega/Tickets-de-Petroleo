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
    public partial class EmpresaCrear : Form
    {
        bool editar = false;
        public EmpresaCrear()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        public EmpresaCrear(int rut, string nombre) :
            this()
        {
            editar = true;
            txtRut.Value = rut;
            txtNombre.Text = nombre;

            this.Text = "Editar Empresa";
            btnCrear.Text = "Editar";

            txtRut.Enabled = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                int rut = int.Parse(txtRut.Value.ToString());
                string nombre = txtNombre.Text;

                Empresa empresa = new Empresa(rut, nombre);

                if (editar)
                    empresa.Guardar();
                else
                    empresa.Crear();

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
