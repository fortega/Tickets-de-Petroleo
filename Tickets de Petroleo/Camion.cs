using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tickets_de_Petroleo
{
    class Camion
    {
        private Empresa empresa;
        private string patente;

        public Camion(Empresa empresa, string patente)
        {
            this.empresa = empresa;
            this.patente = patente;
        }

        public Empresa Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public string Patente
        {
            get { return patente; }
        }

        public void Crear()
        {
            string sql = "INSERT INTO camiones (camion_patente, empresa_rut) VALUES (@patente, @rut)";
            Database db = new Database(sql);
            db.addParameter("@patente", System.Data.SqlDbType.VarChar, patente);
            db.addParameter("@rut", System.Data.SqlDbType.Int, empresa.Rut);
            db.execute();
        }

        public void Guardar()
        {
            string sql = "UPDATE camiones SET empresa_rut = @rut WHERE camion_patente = @patente";
            Database db = new Database(sql);
            db.addParameter("@patente", System.Data.SqlDbType.VarChar, patente);
            db.addParameter("@rut", System.Data.SqlDbType.Int, empresa.Rut);
            db.execute();
        }

        public void Borrar()
        {
            string sql = "DELETE FROM camiones WHERE camion_patente = @patente";
            Database db = new Database(sql);
            db.addParameter("@patente", System.Data.SqlDbType.VarChar, patente);
            db.execute();
        }

        public static Camion[] Todos
        {
            get
            {
                string sql = @"select e.empresa_nombre,c.empresa_rut,c.camion_patente from camiones c
                    inner join empresas e
                    on c.empresa_rut = e.empresa_rut
                    order by e.empresa_nombre,c.camion_patente";

                List<Camion> resultado = new List<Camion>();
                using(Database db = new Database(sql))
                {
                    DataTable dt = new DataTable();
                    foreach (DataRow dr in dt.Rows)
                    {
                        resultado.Add(
                            new Camion(new Empresa((int)dr["empresa_rut"],(string)dr["empresa_nombre"]),
                            (string)dr["camion_patente"]));
                    }
                }
                return resultado.ToArray();
            }
        }
    }
}
