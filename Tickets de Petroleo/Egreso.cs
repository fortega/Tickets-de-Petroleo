﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tickets_de_Petroleo
{
    public class Egreso
    {
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
            string sql = @"INSERT INTO egresos(egreso_dia,egreso_hora,empresa_rut,chofer_rut,camion_patente,operador_nombre,egreso_litros,bomba_id) VALUES
(dbo.dia(current_timestamp),current_timestamp,@empresa,@chofer,@patente,@operador,@litros,@bomba); SELECT @@IDENTITY";
            using (Database db = new Database(sql))
            {
                db.addParameter("@empresa", System.Data.SqlDbType.Int, camion.Empresa.Rut);
                db.addParameter("@chofer", System.Data.SqlDbType.Int, chofer.Rut);
                db.addParameter("@patente", System.Data.SqlDbType.Char, camion.Patente);
                db.addParameter("@operador", System.Data.SqlDbType.VarChar, operador.Nombre);
                db.addParameter("@litros", System.Data.SqlDbType.Float, litros_egreso);
                db.addParameter("@bomba", System.Data.SqlDbType.SmallInt, bomba.ID);

                DataTable dt = db.getData();

                id = (long)dt.Rows[0][0];
            }
        }
        
    }
}
