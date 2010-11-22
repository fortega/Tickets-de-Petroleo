using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tickets_de_Petroleo
{
    class Empresa
    {
        private int rut;
        private string nombre;

        public Empresa(int rut, string nombre)
        {
            this.rut = rut;
            this.nombre = nombre;
        }

        public int Rut
        {
            get { return rut; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public void Crear()
        {
            string sql = "INSERT INTO empresas (rut, nombre) values (@rut,@nombre)";
            Database db = new Database(sql);
            db.addParameter("@rut", System.Data.SqlDbType.Int, rut);
            db.addParameter("@nombre", System.Data.SqlDbType.VarChar, nombre);
            db.execute();
        }

        public void Guardar()
        {
            string sql = "UPDATE empresas SET nombre = @nombre WHERE rut = @rut";
            Database db = new Database(sql);
            db.addParameter("@rut", System.Data.SqlDbType.Int, rut);
            db.addParameter("@nombre", System.Data.SqlDbType.VarChar, nombre);
            db.execute();
        }

        public void Borrar()
        {
            string sql = "DELETE FROM empresas WHERE rut = @rut";
            Database db = new Database(sql);
            db.addParameter("@rut", System.Data.SqlDbType.Int, rut);
            db.execute();
        }

        public static Empresa[] Todos
        {
            get
            {
                string sql = "SELECT * FROM empresas ORDER BY nombre";
                DataTable dt;
                using(Database db = new Database(sql)){
                    dt = db.getData();
                }

                List<Empresa> resultado = new List<Empresa>();
                foreach (DataRow dr in dt.Rows)
                {
                    resultado.Add(new Empresa((int)dr["empresa_rut"],(string)dr["empresa_nombre"]));
                }

                return resultado.ToArray();
            }
        }
    }
}
