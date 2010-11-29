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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEgresos = new System.Windows.Forms.TabPage();
            this.tagIngresos = new System.Windows.Forms.TabPage();
            this.tabCierre = new System.Windows.Forms.TabPage();
            this.menu.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.menu.Size = new System.Drawing.Size(669, 24);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEgresos);
            this.tabControl1.Controls.Add(this.tagIngresos);
            this.tabControl1.Controls.Add(this.tabCierre);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 501);
            this.tabControl1.TabIndex = 12;
            // 
            // tabEgresos
            // 
            this.tabEgresos.Location = new System.Drawing.Point(4, 22);
            this.tabEgresos.Name = "tabEgresos";
            this.tabEgresos.Padding = new System.Windows.Forms.Padding(3);
            this.tabEgresos.Size = new System.Drawing.Size(661, 475);
            this.tabEgresos.TabIndex = 0;
            this.tabEgresos.Text = "Egresos";
            this.tabEgresos.UseVisualStyleBackColor = true;
            // 
            // tagIngresos
            // 
            this.tagIngresos.Location = new System.Drawing.Point(4, 22);
            this.tagIngresos.Name = "tagIngresos";
            this.tagIngresos.Padding = new System.Windows.Forms.Padding(3);
            this.tagIngresos.Size = new System.Drawing.Size(192, 74);
            this.tagIngresos.TabIndex = 1;
            this.tagIngresos.Text = "Ingresos";
            this.tagIngresos.UseVisualStyleBackColor = true;
            // 
            // tabCierre
            // 
            this.tabCierre.Location = new System.Drawing.Point(4, 22);
            this.tabCierre.Name = "tabCierre";
            this.tabCierre.Size = new System.Drawing.Size(192, 74);
            this.tabCierre.TabIndex = 2;
            this.tabCierre.Text = "Cierre";
            this.tabCierre.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 525);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEgresos;
        private System.Windows.Forms.TabPage tagIngresos;
        private System.Windows.Forms.TabPage tabCierre;
    }
}