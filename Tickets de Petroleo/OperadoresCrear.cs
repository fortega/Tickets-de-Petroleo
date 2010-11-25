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
    public partial class OperadoresCrear : Form
    {
        bool edicion = false;
        public OperadoresCrear()
        {
            this.DialogResult = DialogResult.Abort;
            InitializeComponent();
        }

        public OperadoresCrear(Operador operador)
            : this(operador.Nombre, "", operador.Admin)
        {
        }

        public OperadoresCrear(string nombre, string passwd, bool admin) : this()
        {
            edicion = true;

            txtNombre.Text = nombre;
            txtNombre.Enabled = false;
            txtPasswd.Text = passwd;
            chkAdmin.Checked = admin;

            this.Text = "Editar Operador";
            btnCrear.Text = "Editar";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string passwd = txtPasswd.Text.Trim();
                bool admin = chkAdmin.Checked;

                Operador operador = new Operador(nombre, passwd, admin);
                if (edicion)
                    operador.Guardar();
                else
                    operador.Crear();

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
