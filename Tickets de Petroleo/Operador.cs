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
        const int minNombre = 5, minPasswd = 4;
        private string nombre, passwd;
        private bool admin;

        public Operador(string nombre, string passwd, bool admin)
        {
            this.nombre = nombre;
            this.passwd = passwd;
            this.admin = admin;
        }

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

        public static Operador[] Todos
        {
            get
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
        }

        public void Crear()
        {
            if (nombre.Length < minNombre)
                throw new Exception(string.Concat("Nombre debe tener al menos ", minNombre, " caracteres"));
            else if (passwd.Length < minPasswd)
                throw new Exception(string.Concat("Passwd debe tener al menos ", minPasswd, " caracteres"));
            else
            {
                string sql = "INSERT INTO operadores (operador_nombre, operador_passwd, operador_admin) VALUES (@nombre,@passwd,@admin)";
                Database db = new Database(sql);
                db.addParameter("@nombre", SqlDbType.VarChar, nombre);
                db.addParameter("@passwd", SqlDbType.VarChar, passwd);
                db.addParameter("@admin", SqlDbType.Bit, admin);
                db.execute();
            }
        }

        public void Guardar()
        {
            if (passwd.Length < minPasswd)
                throw new Exception(string.Concat("Passwd debe tener al menos ", minPasswd, " caracteres"));
            else
            {
                string sql = "UPDATE operadores SET operador_passwd = @passw, operador_admin = @admin WHERE operador_nombre = @nombre";
                Database db = new Database(sql);
                db.addParameter("@nombre", SqlDbType.VarChar, nombre);
                db.addParameter("@passwd", SqlDbType.VarChar, passwd);
                db.addParameter("@admin", SqlDbType.Bit, admin);
                db.execute();
            }
        }

        public void Borrar()
        {
            string sql = "DELETE FROM operadores WHERE operador_nombre = @nombre";
            Database db = new Database(sql);
            db.addParameter("@nombre", SqlDbType.VarChar, nombre);
            db.execute();
        }

        private void setData(DataRow dr)
        {
            this.nombre = (string)dr["operador_nombre"];
            this.nombre = (string)dr["operador_passwd"];
            this.admin = (bool)dr["operador_admin"];
        }

    }
}
