﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tickets_de_Petroleo
{
    public partial class CamionesMain : Form
    {
        private Operador operador;
        public CamionesMain(Operador operador)
        {
            this.operador = operador;
            InitializeComponent();

            CargarDatos();
        }

        public void CargarDatos()
        {
            Camion[] camiones = Camion.Todos;
            gv.DataSource = camiones;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Camion seleccionado = (Camion)gv.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show("Desea borrar \"" + seleccionado.Patente + "\"?",
                "Borrar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                seleccionado.Borrar();
                CargarDatos();
            }
        }
    }
}
