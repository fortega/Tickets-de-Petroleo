using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
