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
    public partial class IngresoEgreso : Form
    {
        public IngresoEgreso()
        {
            InitializeComponent();

            CargarBombas();
        }

        private void CargarBombas()
        {
            Bomba[] bombas = Bomba.Todos;

            ddlBombas.Items.Clear();
            ddlBombas.Items.AddRange(bombas);
            ddlBombas.Items.Add(new Bomba(0, "Todas"));

            ddlBombas.SelectedIndex = ddlBombas.Items.Count - 1;
        }

        private void cargarGV()
        {
            string sql = @"select bomba,dia,hora,operador,item,litros,final from egreso_ingreso
                where bomba = @bomba or @bomba = 'Todas'
                order by hora desc";

            Bomba bomba = (Bomba)ddlBombas.SelectedItem;
            using (Database db = new Database(sql))
            {
                db.addParameter("@bomba", SqlDbType.VarChar, bomba.Nombre);

                DataTable dt = db.getData();
                gv.DataSource = dt;
            }
        }

        private void cargarSaldo()
        {
            string sql = @"select sum(litros) as litros from egreso_ingreso
                where bomba = @bomba or @bomba = 'Todas'";

            Bomba bomba = (Bomba)ddlBombas.SelectedItem;
            using (Database db = new Database(sql))
            {
                db.addParameter("@bomba", SqlDbType.VarChar, bomba.Nombre);

                DataTable dt = db.getData();

                lblSaldoValor.Text = ((double)dt.Rows[0]["litros"]).ToString("#,0.0");
            }
        }

        private void cargarDatos(object sender, EventArgs e)
        {
            cargarGV();
            if(gv.RowCount > 0)
                cargarSaldo();
        }
    }
}
