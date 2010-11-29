namespace Tickets_de_Petroleo
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mantenedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.choferesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.operadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bombasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabGroup = new System.Windows.Forms.TabControl();
            this.tabEgresos = new System.Windows.Forms.TabPage();
            this.tabIngresos = new System.Windows.Forms.TabPage();
            this.tabCierre = new System.Windows.Forms.TabPage();
            this.inLblBomba = new System.Windows.Forms.Label();
            this.inNLitros = new System.Windows.Forms.NumericUpDown();
            this.btnLitros = new System.Windows.Forms.Button();
            this.egresoControl1 = new Tickets_de_Petroleo.EgresoControl();
            this.menu.SuspendLayout();
            this.tabGroup.SuspendLayout();
            this.tabEgresos.SuspendLayout();
            this.tabIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inNLitros)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedoresToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(369, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // mantenedoresToolStripMenuItem
            // 
            this.mantenedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transportistasToolStripMenuItem,
            this.operadoresToolStripMenuItem,
            this.bombasToolStripMenuItem});
            this.mantenedoresToolStripMenuItem.Name = "mantenedoresToolStripMenuItem";
            this.mantenedoresToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.mantenedoresToolStripMenuItem.Text = "Mantenedores";
            // 
            // transportistasToolStripMenuItem
            // 
            this.transportistasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem,
            this.camionesToolStripMenuItem1,
            this.choferesToolStripMenuItem1});
            this.transportistasToolStripMenuItem.Name = "transportistasToolStripMenuItem";
            this.transportistasToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.transportistasToolStripMenuItem.Text = "Transportistas";
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.asdToolStripMenuItem.Text = "Empresas";
            this.asdToolStripMenuItem.Click += new System.EventHandler(this.abrir_empresaMain);
            // 
            // camionesToolStripMenuItem1
            // 
            this.camionesToolStripMenuItem1.Name = "camionesToolStripMenuItem1";
            this.camionesToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.camionesToolStripMenuItem1.Text = "Camiones";
            this.camionesToolStripMenuItem1.Click += new System.EventHandler(this.abrir_camionesMain);
            // 
            // choferesToolStripMenuItem1
            // 
            this.choferesToolStripMenuItem1.Name = "choferesToolStripMenuItem1";
            this.choferesToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.choferesToolStripMenuItem1.Text = "Choferes";
            this.choferesToolStripMenuItem1.Click += new System.EventHandler(this.abrir_choferesMain);
            // 
            // operadoresToolStripMenuItem
            // 
            this.operadoresToolStripMenuItem.Name = "operadoresToolStripMenuItem";
            this.operadoresToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.operadoresToolStripMenuItem.Text = "Operadores";
            this.operadoresToolStripMenuItem.Click += new System.EventHandler(this.abrir_operadoresMain);
            // 
            // bombasToolStripMenuItem
            // 
            this.bombasToolStripMenuItem.Name = "bombasToolStripMenuItem";
            this.bombasToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.bombasToolStripMenuItem.Text = "Bombas";
            this.bombasToolStripMenuItem.Click += new System.EventHandler(this.abrir_bombasMain);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tabGroup
            // 
            this.tabGroup.Controls.Add(this.tabEgresos);
            this.tabGroup.Controls.Add(this.tabCierre);
            this.tabGroup.Controls.Add(this.tabIngresos);
            this.tabGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGroup.Location = new System.Drawing.Point(0, 24);
            this.tabGroup.Name = "tabGroup";
            this.tabGroup.SelectedIndex = 0;
            this.tabGroup.Size = new System.Drawing.Size(369, 238);
            this.tabGroup.TabIndex = 12;
            // 
            // tabEgresos
            // 
            this.tabEgresos.Controls.Add(this.egresoControl1);
            this.tabEgresos.Location = new System.Drawing.Point(4, 22);
            this.tabEgresos.Name = "tabEgresos";
            this.tabEgresos.Padding = new System.Windows.Forms.Padding(3);
            this.tabEgresos.Size = new System.Drawing.Size(361, 212);
            this.tabEgresos.TabIndex = 0;
            this.tabEgresos.Text = "Egresos";
            this.tabEgresos.UseVisualStyleBackColor = true;
            // 
            // tabIngresos
            // 
            this.tabIngresos.Controls.Add(this.btnLitros);
            this.tabIngresos.Controls.Add(this.inNLitros);
            this.tabIngresos.Controls.Add(this.inLblBomba);
            this.tabIngresos.Location = new System.Drawing.Point(4, 22);
            this.tabIngresos.Name = "tabIngresos";
            this.tabIngresos.Padding = new System.Windows.Forms.Padding(3);
            this.tabIngresos.Size = new System.Drawing.Size(661, 475);
            this.tabIngresos.TabIndex = 1;
            this.tabIngresos.Text = "Ingresos";
            this.tabIngresos.UseVisualStyleBackColor = true;
            // 
            // tabCierre
            // 
            this.tabCierre.Location = new System.Drawing.Point(4, 22);
            this.tabCierre.Name = "tabCierre";
            this.tabCierre.Size = new System.Drawing.Size(661, 475);
            this.tabCierre.TabIndex = 2;
            this.tabCierre.Text = "Cierre";
            this.tabCierre.UseVisualStyleBackColor = true;
            // 
            // inLblBomba
            // 
            this.inLblBomba.AutoSize = true;
            this.inLblBomba.Location = new System.Drawing.Point(124, 87);
            this.inLblBomba.Name = "inLblBomba";
            this.inLblBomba.Size = new System.Drawing.Size(43, 13);
            this.inLblBomba.TabIndex = 0;
            this.inLblBomba.Text = "Bomba:";
            // 
            // inNLitros
            // 
            this.inNLitros.Location = new System.Drawing.Point(173, 85);
            this.inNLitros.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.inNLitros.Name = "inNLitros";
            this.inNLitros.Size = new System.Drawing.Size(120, 20);
            this.inNLitros.TabIndex = 1;
            this.inNLitros.ThousandsSeparator = true;
            // 
            // btnLitros
            // 
            this.btnLitros.Location = new System.Drawing.Point(173, 112);
            this.btnLitros.Name = "btnLitros";
            this.btnLitros.Size = new System.Drawing.Size(75, 23);
            this.btnLitros.TabIndex = 2;
            this.btnLitros.Text = "Cargar";
            this.btnLitros.UseVisualStyleBackColor = true;
            // 
            // egresoControl1
            // 
            this.egresoControl1.Location = new System.Drawing.Point(8, 6);
            this.egresoControl1.Name = "egresoControl1";
            this.egresoControl1.Size = new System.Drawing.Size(334, 185);
            this.egresoControl1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 262);
            this.Controls.Add(this.tabGroup);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tabGroup.ResumeLayout(false);
            this.tabEgresos.ResumeLayout(false);
            this.tabIngresos.ResumeLayout(false);
            this.tabIngresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inNLitros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mantenedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem choferesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bombasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TabControl tabGroup;
        private System.Windows.Forms.TabPage tabEgresos;
        private System.Windows.Forms.TabPage tabIngresos;
        private System.Windows.Forms.TabPage tabCierre;
        private System.Windows.Forms.Label inLblBomba;
        private System.Windows.Forms.NumericUpDown inNLitros;
        private System.Windows.Forms.Button btnLitros;
        private EgresoControl egresoControl1;
    }
}