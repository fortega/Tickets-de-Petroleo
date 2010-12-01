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

            CargarBombas();
        }

        public void CargarBombas()
        {
            Bomba[] bombas = Bomba.Todos;
            ddlBomba.Items.Clear();
            ddlBomba.Items.AddRange(bombas);
            if(bombas.Length > 0)
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

        private void LimpiarTodo()
        {
            txtPatente.Text = "";
            Limpiar();
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
            btnCrear.Enabled = activar;
            ddlChofer.Enabled = activar;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Egreso egreso = new Egreso(
                    (Bomba)ddlBomba.SelectedItem,
                    camion,
                    (Chofer)ddlChofer.SelectedItem,
                    Global.operador,
                    (float)txtLitros.Value);
                egreso.Crear();

                new FadeMessage(string.Concat("Ingresado con ID ", egreso.ID)).ShowDialog();
                LimpiarTodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
    }
}
