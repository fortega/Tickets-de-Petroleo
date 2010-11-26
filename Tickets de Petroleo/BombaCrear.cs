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
    public partial class BombaCrear : Form
    {
        private short idBomba = 0;
        private bool edicion = false;
        public BombaCrear()
        {
            this.DialogResult = DialogResult.Abort;
            InitializeComponent();
        }

        public BombaCrear(Bomba bomba)
            : this(bomba.ID, bomba.Nombre)
        { }

        public BombaCrear(short id, string nombre)
            : this()
        {
            this.edicion = true;

            this.idBomba = id;
            txtNombre.Text = nombre;

            this.Text = "Editar Bomba";
            btnCrear.Text = "Editar";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                Bomba bomba = new Bomba(idBomba,nombre);

                if (edicion)
                    bomba.Guardar();
                else
                    bomba.Crear();

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
