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
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblChofer = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.ddlChofer = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
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
            this.menu.Size = new System.Drawing.Size(606, 24);
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
            this.mantenedoresToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.mantenedoresToolStripMenuItem.Text = "Mantenedores";
            // 
            // transportistasToolStripMenuItem
            // 
            this.transportistasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem,
            this.camionesToolStripMenuItem1,
            this.choferesToolStripMenuItem1});
            this.transportistasToolStripMenuItem.Name = "transportistasToolStripMenuItem";
            this.transportistasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.transportistasToolStripMenuItem.Text = "Transportistas";
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.asdToolStripMenuItem.Text = "Empresas";
            this.asdToolStripMenuItem.Click += new System.EventHandler(this.abrir_empresaMain);
            // 
            // camionesToolStripMenuItem1
            // 
            this.camionesToolStripMenuItem1.Name = "camionesToolStripMenuItem1";
            this.camionesToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.camionesToolStripMenuItem1.Text = "Camiones";
            this.camionesToolStripMenuItem1.Click += new System.EventHandler(this.abrir_camionesMain);
            // 
            // choferesToolStripMenuItem1
            // 
            this.choferesToolStripMenuItem1.Name = "choferesToolStripMenuItem1";
            this.choferesToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.choferesToolStripMenuItem1.Text = "Choferes";
            this.choferesToolStripMenuItem1.Click += new System.EventHandler(this.abrir_choferesMain);
            // 
            // operadoresToolStripMenuItem
            // 
            this.operadoresToolStripMenuItem.Name = "operadoresToolStripMenuItem";
            this.operadoresToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.operadoresToolStripMenuItem.Text = "Operadores";
            this.operadoresToolStripMenuItem.Click += new System.EventHandler(this.abrir_operadoresMain);
            // 
            // bombasToolStripMenuItem
            // 
            this.bombasToolStripMenuItem.Name = "bombasToolStripMenuItem";
            this.bombasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.bombasToolStripMenuItem.Text = "Bombas";
            this.bombasToolStripMenuItem.Click += new System.EventHandler(this.abrir_bombasMain);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(51, 60);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(47, 13);
            this.lblPatente.TabIndex = 1;
            this.lblPatente.Text = "Patente:";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(47, 86);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lblEmpresa.TabIndex = 2;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Location = new System.Drawing.Point(57, 112);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(41, 13);
            this.lblChofer.TabIndex = 3;
            this.lblChofer.Text = "Chofer:";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(63, 139);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(35, 13);
            this.lblLitros.TabIndex = 4;
            this.lblLitros.Text = "Litros:";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(104, 57);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(121, 20);
            this.txtPatente.TabIndex = 5;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(104, 83);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(202, 20);
            this.txtEmpresa.TabIndex = 6;
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(104, 136);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(202, 20);
            this.txtLitros.TabIndex = 8;
            // 
            // ddlChofer
            // 
            this.ddlChofer.FormattingEnabled = true;
            this.ddlChofer.Location = new System.Drawing.Point(104, 109);
            this.ddlChofer.Name = "ddlChofer";
            this.ddlChofer.Size = new System.Drawing.Size(202, 21);
            this.ddlChofer.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(231, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(231, 162);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 11;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 421);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.ddlChofer);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblChofer);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
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
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.ComboBox ddlChofer;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCrear;
    }
}