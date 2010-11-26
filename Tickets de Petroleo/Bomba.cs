using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tickets_de_Petroleo
{
    public class Bomba
    {
        private short id;
        private string nombre;

        public Bomba(short id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public short ID
        {
            get { return id; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public void Crear()
        {
            string sql = "INSERT INTO bombas (bomba_nombre) VALUES (@nombre)";
            Database db = new Database(sql);
            db.addParameter("nombre", SqlDbType.VarChar, nombre);
            db.execute();
        }

        public void Guardar()
        {
            string sql = "UPDATE bombas SET bomba_nombre = @nombre WHERE bomba_id = @id";
            Database db = new Database(sql);
            db.addParameter("id", SqlDbType.SmallInt, id);
            db.addParameter("nombre", SqlDbType.VarChar, nombre);
            db.execute();
        }

        public void Borrar()
        {
            string sql = "DELETE from bombas  WHERE bomba_id = @id";
            Database db = new Database(sql);
            db.addParameter("id", SqlDbType.SmallInt, id);
            db.execute();
        }
        public static Bomba[] Todos
        {
            get
            {
                string sql = "SELECT * FROM bombas ORDER BY bomba_nombre";
                List<Bomba> result = new List<Bomba>();

                Database db = new Database(sql);
                DataTable dt = db.getData();
                foreach (DataRow dr in dt.Rows)
                {
                    result.Add(new Bomba((short)dr["bomba_id"], (string)dr["bomba_nombre"]));
                }
                return result.ToArray();
            }
        }       
    }
}
