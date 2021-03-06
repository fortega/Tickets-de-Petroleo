﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tickets_de_Petroleo
{
    public class Egreso
    {
        private DateTime hora;
        private Bomba bomba;
        private Camion camion;
        private Chofer chofer;
        private float litros_egreso, litros_guia;
        private Operador operador;
        private long id;

        public Egreso(Bomba bomba, Camion camion, Chofer chofer, Operador operador, float litros_egreso)
        {
            this.bomba = bomba;
            this.camion = camion;
            this.chofer = chofer;
            this.operador = operador;
            this.litros_egreso = litros_egreso;
        }

        public long ID
        {
            get { return id; }
        }

        public void Crear()
        {
            string sql = @"egreso_crear";
            using (Database db = new Database(sql, CommandType.StoredProcedure))
            {
                db.addParameter("@empresa", System.Data.SqlDbType.Int, camion.Empresa.Rut);
                db.addParameter("@chofer", System.Data.SqlDbType.Int, chofer.Rut);
                db.addParameter("@patente", System.Data.SqlDbType.Char, camion.Patente);
                db.addParameter("@operador", System.Data.SqlDbType.VarChar, operador.Nombre);
                db.addParameter("@litros", System.Data.SqlDbType.Float, litros_egreso);
                db.addParameter("@bomba", System.Data.SqlDbType.SmallInt, bomba.ID);

                DataTable dt = db.getData();

                id = (long)dt.Rows[0]["egreso_id"];
                hora = (DateTime)dt.Rows[0]["egreso_hora"];
            }
        }

        public static void Cerrar(long egreso_id, float litros_guia)
        {
            string sql = "egreso_cerrar";
            using (Database db = new Database(sql, CommandType.StoredProcedure))
            {
                db.addParameter("@id", SqlDbType.BigInt, egreso_id);
                db.addParameter("@litros", SqlDbType.Float, litros_guia);
                db.addParameter("@operador", SqlDbType.VarChar, Global.operador.Nombre);

                db.execute();
            }
        }

        public void Imprimir(IImpresora impresora)
        {
            impresora.CambiaAlineacion(Alineacion.Centro);
            impresora.ImprimeLinea("Consorcio Santa Marta S.A.");
            impresora.ImprimeLinea("Ticket de petroleo");
            impresora.Lineas(1);

            impresora.CambiaAlineacion(Alineacion.Izquierda);
            impresora.ImprimeLinea(string.Concat("Folio: ", id));
            impresora.ImprimeLinea(string.Concat("Fecha: ", hora.ToString("dd/MMM/YY HH:mm:ss")));
            impresora.ImprimeLinea(string.Concat("Litros (max): ", litros_egreso.ToString("0.0")));
            impresora.Lineas(1);

            impresora.ImprimeLinea(string.Concat("Empresa: ", camion.Empresa.Nombre));
            impresora.ImprimeLinea(string.Concat("Camion: ", camion.Patente));
            impresora.ImprimeLinea(string.Concat("Chofer: ", chofer.Nombre));
            impresora.Lineas(1);

            impresora.ImprimeCodigoBarra(id.ToString());
            impresora.CorteCompleto();
        }
    }
}
