namespace Tickets_de_Petroleo
{
    partial class EgresoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.egLblLitros = new System.Windows.Forms.Label();
            this.txtLitros = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.egLblBomba = new System.Windows.Forms.Label();
            this.egLblEmpresa = new System.Windows.Forms.Label();
            this.egLblChofer = new System.Windows.Forms.Label();
            this.ddlBomba = new System.Windows.Forms.ComboBox();
            this.ddlChofer = new System.Windows.Forms.ComboBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.egLblPatente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtLitros)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Enabled = false;
            this.txtEmpresa.Location = new System.Drawing.Point(70, 98);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(250, 20);
            this.txtEmpresa.TabIndex = 15;
            this.txtEmpresa.TabStop = false;
            // 
            // egLblLitros
            // 
            this.egLblLitros.AutoSize = true;
            this.egLblLitros.Location = new System.Drawing.Point(29, 126);
            this.egLblLitros.Name = "egLblLitros";
            this.egLblLitros.Size = new System.Drawing.Size(35, 13);
            this.egLblLitros.TabIndex = 21;
            this.egLblLitros.Text = "Litros:";
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(70, 124);
            this.txtLitros.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.txtLitros.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(250, 20);
            this.txtLitros.TabIndex = 17;
            this.txtLitros.ThousandsSeparator = true;
            this.txtLitros.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCrear
            // 
            this.btnCrear.Enabled = false;
            this.btnCrear.Location = new System.Drawing.Point(70, 150);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 19;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // egLblBomba
            // 
            this.egLblBomba.AutoSize = true;
            this.egLblBomba.Location = new System.Drawing.Point(21, 19);
            this.egLblBomba.Name = "egLblBomba";
            this.egLblBomba.Size = new System.Drawing.Size(43, 13);
            this.egLblBomba.TabIndex = 20;
            this.egLblBomba.Text = "Bomba:";
            // 
            // egLblEmpresa
            // 
            this.egLblEmpresa.AutoSize = true;
            this.egLblEmpresa.Location = new System.Drawing.Point(13, 101);
            this.egLblEmpresa.Name = "egLblEmpresa";
            this.egLblEmpresa.Size = new System.Drawing.Size(51, 13);
            this.egLblEmpresa.TabIndex = 18;
            this.egLblEmpresa.Text = "Empresa:";
            // 
            // egLblChofer
            // 
            this.egLblChofer.AutoSize = true;
            this.egLblChofer.Location = new System.Drawing.Point(23, 73);
            this.egLblChofer.Name = "egLblChofer";
            this.egLblChofer.Size = new System.Drawing.Size(41, 13);
            this.egLblChofer.TabIndex = 16;
            this.egLblChofer.Text = "Chofer:";
            // 
            // ddlBomba
            // 
            this.ddlBomba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlBomba.FormattingEnabled = true;
            this.ddlBomba.Location = new System.Drawing.Point(70, 16);
            this.ddlBomba.Name = "ddlBomba";
            this.ddlBomba.Size = new System.Drawing.Size(250, 21);
            this.ddlBomba.TabIndex = 12;
            // 
            // ddlChofer
            // 
            this.ddlChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlChofer.Enabled = false;
            this.ddlChofer.FormattingEnabled = true;
            this.ddlChofer.Location = new System.Drawing.Point(70, 70);
            this.ddlChofer.Name = "ddlChofer";
            this.ddlChofer.Size = new System.Drawing.Size(250, 21);
            this.ddlChofer.TabIndex = 14;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(70, 43);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(250, 20);
            this.txtPatente.TabIndex = 13;
            this.txtPatente.TextChanged += new System.EventHandler(this.checkPatente);
            // 
            // egLblPatente
            // 
            this.egLblPatente.AutoSize = true;
            this.egLblPatente.Location = new System.Drawing.Point(17, 46);
            this.egLblPatente.Name = "egLblPatente";
            this.egLblPatente.Size = new System.Drawing.Size(47, 13);
            this.egLblPatente.TabIndex = 11;
            this.egLblPatente.Text = "Patente:";
            // 
            // EgresoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.egLblLitros);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.egLblBomba);
            this.Controls.Add(this.egLblEmpresa);
            this.Controls.Add(this.egLblChofer);
            this.Controls.Add(this.ddlBomba);
            this.Controls.Add(this.ddlChofer);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.egLblPatente);
            this.Name = "EgresoControl";
            this.Size = new System.Drawing.Size(334, 185);
            ((System.ComponentModel.ISupportInitialize)(this.txtLitros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label egLblLitros;
        private System.Windows.Forms.NumericUpDown txtLitros;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label egLblBomba;
        private System.Windows.Forms.Label egLblEmpresa;
        private System.Windows.Forms.Label egLblChofer;
        private System.Windows.Forms.ComboBox ddlBomba;
        private System.Windows.Forms.ComboBox ddlChofer;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label egLblPatente;
    }
}
