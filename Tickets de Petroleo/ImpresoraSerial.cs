using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace Tickets_de_Petroleo
{
    public class ImpresoraSerial : IImpresora
    {
        SerialPort puerto;
        //StreamWriter sw;

        const int _baudRate = 9600, _dataBits = 8, _readTimeout = 250;
        const Parity _parity = Parity.None;
        const StopBits _stopBits = StopBits.One;
        //char escape = (char)27;
        char[] _chrIniciar = new char[] { (char)10, (char)27 };
        char[] _chrAlinIz = new char[] { (char)27, (char)97, (char)0 };
        char[] _chrAlinCn = new char[] { (char)27, (char)97, (char)1 };
        char[] _chrAlinDe = new char[] { (char)27, (char)97, (char)2 };
        char[] _chrCorteCom = new char[] { (char)29, (char)86, (char)0 };
        char[] _chrCortePar = new char[] { (char)29, (char)86, (char)1 };

        public ImpresoraSerial(string com)
        {
            puerto = new SerialPort(com, _baudRate, _parity, _dataBits, _stopBits);
            puerto.NewLine = new string(new char[] { (char)10 });
        }

        #region IImpresora Members

        public void Iniciar()
        {
            if (!puerto.IsOpen)
            {
                puerto.Open();
                //puerto.Write(_chrIniciar, 0, _chrIniciar.Length);
            }
        }

        public void Detener()
        {
            if (puerto.IsOpen)
                puerto.Close();
        }

        public void CambiaAlineacion(Alineacion alineacion)
        {
            switch (alineacion)
            {
                case Alineacion.Izquierda:
                    puerto.Write(_chrAlinIz, 0, _chrAlinIz.Length);
                    break;
                case Alineacion.Centro:
                    puerto.Write(_chrAlinCn, 0, _chrAlinCn.Length);
                    break;
                case Alineacion.Derecha:
                    puerto.Write(_chrAlinDe, 0, _chrAlinDe.Length);
                    break;
            }
        }

        public void Imprime(string texto)
        {
            puerto.Write(texto);
        }

        public void ImprimeLinea(string texto)
        {
            puerto.WriteLine(texto);
        }

        public void ImprimeCodigoBarra(string texto)
        {
            char[] txt = new char[texto.Length + 4];

            txt[0] = (char)29;
            txt[1] = (char)107;
            txt[2] = (char)72;
            txt[3] = (char)texto.Length;

            for (int i = 0; i < texto.Length; i++)
            {
                txt[i + 4] = texto[i];
            }
            puerto.Write(txt, 0, txt.Length);
        }

        public void CorteCompleto()
        {
            Lineas(4);
            puerto.Write(_chrCorteCom, 0, _chrCorteCom.Length);
        }

        public void CorteParcial()
        {
            Lineas(4);
            puerto.Write(_chrCortePar, 0, _chrCortePar.Length);
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            Detener();
        }

        #endregion

        public void Lineas(int lineas)
        {
            puerto.Write(new char[] { (char)27, (char)100, (char)lineas }, 0, 3);
        }
    }
}
