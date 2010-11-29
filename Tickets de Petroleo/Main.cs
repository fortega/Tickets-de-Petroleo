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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            if (!Global.operador.Admin)
            {
                desactivaMenu();
            }
        }

        private void desactivaMenu()
        {
            operadoresToolStripMenuItem.Enabled = false;
            tabGroup.TabPages.Remove(tabIngresos);
        }

        private void abrir_empresaMain(object sender, EventArgs e)
        {
            EmpresaMain empresaForm = new EmpresaMain();
            empresaForm.ShowDialog();
        }

        private void abrir_camionesMain(object sender, EventArgs e)
        {
            CamionesMain camionesForm = new CamionesMain();
            camionesForm.ShowDialog();
        }

        private void abrir_choferesMain(object sender, EventArgs e)
        {
            ChoferesMain choferesMain = new ChoferesMain();
            choferesMain.ShowDialog();
        }

        private void abrir_operadoresMain(object sender, EventArgs e)
        {
            OperadoresMain operadoresForm = new OperadoresMain();
            operadoresForm.ShowDialog();
        }

        private void abrir_bombasMain(object sender, EventArgs e)
        {
            BombasMain bombasForm = new BombasMain();
            bombasForm.ShowDialog();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        
    }
}
