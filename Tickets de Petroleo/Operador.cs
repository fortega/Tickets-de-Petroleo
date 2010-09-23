using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Tickets_de_Petroleo
{
    public class Operador
    {
        private string nombre;
        private bool admin;

        public Operador(string nombre, string passwd)
        {
            Database db = new Database("SELECT * FROM operadores WHERE operador_nombre = @nombre AND operador_passwd = @passwd");
            db.addParameter("nombre", System.Data.SqlDbType.VarChar, nombre);
            db.addParameter("passwd", System.Data.SqlDbType.VarChar, passwd);

            DataTable dt = db.getData();

            if (dt.Rows.Count == 1)
                setData(dt.Rows[0]);
            else
                throw new Exception("Nombre o Password incorrecto");
        }

        private Operador(string nombre, bool admin)
        {
            this.nombre = nombre;
            this.admin = admin;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public bool Admin
        {
            get { return admin; }
        }

        public override string ToString()
        {
            return (admin ? "+ " : "- ") + nombre;
        }

        public static Operador[] getTodos()
        {
            DataTable dt;
            using (Database db = new Database("SELECT * FROM operadores ORDER BY operador_nombre"))
            {
                dt = db.getData();
            }

            Operador[] r = new Operador[dt.Rows.Count];

            for (int i = 0; i < r.Length; i++)
            {
                r[i] = new Operador((string)dt.Rows[i]["operador_nombre"],
                    (bool)dt.Rows[i]["operador_admin"]);
            }

            return r;
        }

        private void setData(DataRow dr)
        {
            this.nombre = (string)dr["operador_nombre"];
            this.admin = (bool)dr["operador_admin"];
        }
    }
}
