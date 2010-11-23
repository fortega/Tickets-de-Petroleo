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
        public EmpresaCrear()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                int rut = int.Parse(txtRut.Text);
                string nombre = txtNombre.Text;

                Empresa empresa = new Empresa(rut, nombre);
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
