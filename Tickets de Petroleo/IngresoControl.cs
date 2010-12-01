using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tickets_de_Petroleo
{
    public partial class IngresoControl : UserControl
    {
        public IngresoControl()
        {
            InitializeComponent();

            cargarBombas();
        }

        public void cargarBombas()
        {
            Bomba[] bombas = Bomba.Todos;

            ddlBombas.Items.Clear();
            ddlBombas.Items.AddRange(bombas);
            if(bombas.Length > 0)
                ddlBombas.SelectedIndex = 0;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Bomba bomba = (Bomba)ddlBombas.SelectedItem;
                float litros = (float)txtLitros.Value;

                Ingreso ingreso = new Ingreso(bomba, litros);
                ingreso.Crear();

                new FadeMessage(string.Concat("Ingresados ", litros, "lts en ", bomba.Nombre)).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
