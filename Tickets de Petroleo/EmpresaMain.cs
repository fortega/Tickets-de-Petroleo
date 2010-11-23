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
    public partial class EmpresaMain : Form
    {
        private Operador operador;
        public EmpresaMain(Operador operador)
        {
            this.operador = operador;
            InitializeComponent();
        }

        private void CargarDatos()
        {
            //TODO
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            EmpresaCrear frm = new EmpresaCrear();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }
    }
}
