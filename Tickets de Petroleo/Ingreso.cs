using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tickets_de_Petroleo
{
    public class Ingreso
    {
        private Bomba bomba;
        private float litros;

        public Ingreso(Bomba bomba, float litros)
        {
            this.bomba = bomba;
            this.litros = litros;
        }

        public void Crear()
        {
            string sql = "ingreso_crear";
            using (Database db = new Database(sql, System.Data.CommandType.StoredProcedure))
            {
                db.addParameter("@bomba", System.Data.SqlDbType.SmallInt, bomba.ID);
                db.addParameter("@litros", System.Data.SqlDbType.Float, litros);
                db.addParameter("@operador", System.Data.SqlDbType.VarChar, Global.operador.Nombre);

                db.execute();
            }
        }
    }
}
