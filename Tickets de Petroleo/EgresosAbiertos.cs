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
    public partial class EgresosAbiertos : Form
    {
        public EgresosAbiertos()
        {
            InitializeComponent();

            CargarGV();
        }

        private void CargarGV()
        {
            string sql = @"select egreso_id as ID,
                bomba_nombre as Bomba,
                empresa_nombre as Empresa,
                chofer_nombre as Chofer,
                camion_patente as Camion,
                egreso_hora as Hora,
                egreso_litros as Litros
                from egresos_abiertos
                order by Empresa,Chofer";
            using (Database db = new Database(sql))
            {
                DataTable dt = db.getData();
                gv.DataSource = dt;
            }
        }
    }
}
