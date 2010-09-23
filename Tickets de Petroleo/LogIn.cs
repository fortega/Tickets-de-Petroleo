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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Salir(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ingresar(object sender, EventArgs e)
        {
            try
            {
                Operador operador = new Operador(cbNombre.SelectedText, tbPasswd.Text);

                Main main = new Main(operador);
                main.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
