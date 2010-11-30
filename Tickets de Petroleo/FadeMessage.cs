using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tickets_de_Petroleo
{
    public partial class FadeMessage : Form
    {
        public FadeMessage(string mensaje)
        {
            InitializeComponent();
            
            lblMensaje.Text = mensaje;
            timer.Interval = Properties.Settings.Default.fadeMessageInterval;
            timer.Start();
        }

        private void cerrar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
