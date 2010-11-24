using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tickets_de_Petroleo
{
    public class Chofer
    {
        private Empresa empresa;
        private int rut;
        private string nombre;

        public Chofer(Empresa empresa, int rut, string nombre)
        {
            this.empresa = empresa;
            this.rut = rut;
            this.nombre = nombre;
        }

        public Empresa Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Rut
        {
            get { return rut; }
        }

        public void Crear()
        {
            string sql = "INSERT INTO choferes (empresa_rut,chofer_rut,chofer_nombre) VALUES (@empresa,@rut,@nombre)";
            Database db = new Database(sql);
            db.addParameter("@empresa", System.Data.SqlDbType.Int, empresa.Rut);
            db.addParameter("@rut", System.Data.SqlDbType.Int, rut);
            db.addParameter("@nombre", System.Data.SqlDbType.VarChar, nombre);
            db.execute();
        }

        public void Guardar()
        {
            string sql = "UPDATE choferes SET empresa_rut = @empresa ,chofer_nombre = @nombre WHERE chofer_rut = @rut";
            Database db = new Database(sql);
            db.addParameter("@empresa", System.Data.SqlDbType.Int, empresa.Rut);
            db.addParameter("@rut", System.Data.SqlDbType.Int, rut);
            db.addParameter("@nombre", System.Data.SqlDbType.VarChar, nombre);
            db.execute();
        }

        public void Borrar()
        {
            string sql = "DELETE FROM choferes WHERE chofer_rut = @rut";
            Database db = new Database(sql);
            db.addParameter("@empresa", System.Data.SqlDbType.Int, empresa.Rut);
            db.addParameter("@rut", System.Data.SqlDbType.Int, rut);
            db.addParameter("@nombre", System.Data.SqlDbType.VarChar, nombre);
            db.execute();
        }

        public static Chofer[] Todos
        {
            get
            {
                string sql = @"select e.empresa_rut,e.empresa_nombre,c.chofer_rut,c.chofer_nombre
                    from choferes c
                    inner join empresas e
                    on c.empresa_rut = e.empresa_rut
                    order by e.empresa_nombre,c.chofer_nombre";
                List<Chofer> resultado = new List<Chofer>();

                using (Database db = new Database(sql))
                {
                    DataTable dt = db.getData();

                    foreach (DataRow dr in dt.Rows)
                    {
                        resultado.Add(
                            new Chofer(
                                new Empresa((int)dr["empresa_rut"], (string)dr["empresa_nombre"]),
                            (int)dr["chofer_rut"], (string)dr["chofer_nombre"]));
                    }
                }
                return resultado.ToArray();
            }
        }
    }
}
