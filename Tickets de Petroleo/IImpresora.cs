using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets_de_Petroleo
{
    public enum Alineacion
    {
        Izquierda, Centro, Derecha
    }
    public interface IImpresora : IDisposable
    {
        void Iniciar();
        void Detener();
        void CambiaAlineacion(Alineacion alineacion);
        void Imprime(string texto);
        void ImprimeLinea(string texto);
        void ImprimeCodigoBarra(string texto);
        void CorteCompleto();
        void CorteParcial();
        void Lineas(int lineas);
    }
}
