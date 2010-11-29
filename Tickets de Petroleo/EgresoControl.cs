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
    public partial class EgresoControl : UserControl
    {
        private Camion camion;
        public EgresoControl()
        {
            InitializeComponent();

            cargarBomas();
        }

        private void cargarBomas()
        {
            Bomba[] bombas = Bomba.Todos;
            ddlBomba.Items.Clear();
            ddlBomba.Items.AddRange(bombas);
            ddlBomba.SelectedIndex = 0;
        }

        private void checkPatente(object sender, EventArgs e)
        {
            bool patenteOk = false;
            Limpiar();
            if (RegexValidator.Validate(Camion.validaPatente, txtPatente.Text))
            {
                camion = Camion.getFromPatente(txtPatente.Text);
                if (camion != null)
                {
                    patenteOk = true;

                    txtEmpresa.Text = camion.Empresa.Nombre;
                    cargarChoferes(ref ddlChofer, camion.Empresa);
                }
            }
            activaItems(patenteOk);
        }

        private void Limpiar()
        {
            ddlChofer.Items.Clear();
            txtEmpresa.Text = "";
        }
        private void cargarChoferes(ref ComboBox ddl, Empresa empresa)
        {
            Chofer[] choferes = Chofer.getFromEmpresa(empresa);
            ddl.Items.AddRange(choferes);
            ddl.SelectedIndex = 0;
        }

        private void activaItems(bool activar)
        {
            egBtnCrear.Enabled = activar;
            ddlChofer.Enabled = activar;
        }

        private void egBtnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Egreso egreso = new Egreso(
                    (Bomba)ddlBomba.SelectedItem,
                    camion,
                    (Chofer)ddlChofer.SelectedItem,
                    Global.operador,
                    float.Parse(txtLitros.Value.ToString()));
                egreso.Crear();

                MessageBox.Show(string.Concat("Ingresado con ID ", egreso.ID));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
    }
}
