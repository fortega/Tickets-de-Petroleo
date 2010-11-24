using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tickets_de_Petroleo
{
    public class Empresa
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
            string sql = "INSERT INTO empresas (empresa_rut, empresa_nombre) values (@rut,@nombre)";
            Database db = new Database(sql);
            db.addParameter("@rut", System.Data.SqlDbType.Int, rut);
            db.addParameter("@nombre", System.Data.SqlDbType.VarChar, nombre);
            db.execute();
        }

        public void Guardar()
        {
            string sql = "UPDATE empresas SET empresa_nombre = @nombre WHERE empresa_rut = @rut";
            Database db = new Database(sql);
            db.addParameter("@rut", System.Data.SqlDbType.Int, rut);
            db.addParameter("@nombre", System.Data.SqlDbType.VarChar, nombre);
            db.execute();
        }

        public void Borrar()
        {
            string sql = "DELETE FROM empresas WHERE empresa_rut = @rut";
            Database db = new Database(sql);
            db.addParameter("@rut", System.Data.SqlDbType.Int, rut);
            db.execute();
        }

        public override string ToString()
        {
            return string.Concat(nombre, " / " + rut);
        }

        public static Empresa[] Todos
        {
            get
            {
                string sql = "SELECT * FROM empresas ORDER BY empresa_nombre";
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
