using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tickets_de_Petroleo
{
    public class Camion
    {
        public const string validaPatente = "(\\w{2}\\d{4})|(\\w{4}\\d{2})";
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

        private bool patenteValida
        {
            get
            {
                return RegexValidator.Validate(validaPatente, patente);
            }
        }

        public void Crear()
        {
            if (patenteValida)
            {
                string sql = "INSERT INTO camiones (camion_patente, empresa_rut) VALUES (@patente, @rut)";
                Database db = new Database(sql);
                db.addParameter("@patente", System.Data.SqlDbType.VarChar, patente);
                db.addParameter("@rut", System.Data.SqlDbType.Int, empresa.Rut);
                db.execute();
            }else
                throw new Exception("Patente invalida. Debe seguir la forma \"AB1234\" o \"ABCD12\".");
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
                    DataTable dt = db.getData();
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

        public static Camion getFromPatente(string patente)
        {
            string sql = @"select e.empresa_nombre,c.empresa_rut,c.camion_patente from camiones c
                    inner join empresas e
                    on c.empresa_rut = e.empresa_rut
                    where c.camion_patente = @patente
                    order by e.empresa_nombre,c.camion_patente";
            Camion resultado = null;
            using (Database db = new Database(sql))
            {
                db.addParameter("@patente", SqlDbType.VarChar, patente);
                DataTable dt = db.getData();

                if (dt.Rows.Count == 1)
                {
                    DataRow dr = dt.Rows[0];
                    resultado = new Camion(new Empresa((int)dr["empresa_rut"], (string)dr["empresa_nombre"]),
                            (string)dr["camion_patente"]);
                }
            }
            return resultado;
        }
    }
}
