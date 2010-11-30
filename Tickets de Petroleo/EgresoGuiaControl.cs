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
    public partial class EgresoGuiaControl : UserControl
    {
        public EgresoGuiaControl()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                long num = long.Parse(txtEgreso.Text);
                Egreso.Cerrar(num, (float)txtLitros.Value);
                new FadeMessage(string.Concat("Egreso ", num, " cerrado")).ShowDialog();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            txtEgreso.Text = "";
        }
    }
}
