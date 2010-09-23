using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Tickets_de_Petroleo
{
    public class Operador
    {
        private string nombre;
        private bool admin;

        public Operador(string nombre, string passwd)
        {
            
        }

        public Operador(string nombre, bool admin)
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
            return nombre;
        }
    }
}
