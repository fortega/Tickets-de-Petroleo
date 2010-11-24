namespace Tickets_de_Petroleo
{
    partial class ChoferCrear
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
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblRut = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.ddlEmpresas = new System.Windows.Forms.ComboBox();
            this.txtRut = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtRut)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(12, 9);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(36, 36);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(27, 13);
            this.lblRut.TabIndex = 1;
            this.lblRut.Text = "Rut:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // ddlEmpresas
            // 
            this.ddlEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEmpresas.FormattingEnabled = true;
            this.ddlEmpresas.Location = new System.Drawing.Point(69, 6);
            this.ddlEmpresas.Name = "ddlEmpresas";
            this.ddlEmpresas.Size = new System.Drawing.Size(121, 21);
            this.ddlEmpresas.TabIndex = 3;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(69, 34);
            this.txtRut.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtRut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(120, 20);
            this.txtRut.TabIndex = 4;
            this.txtRut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(69, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(69, 88);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // ChoferCrear
            // 
            this.AcceptButton = this.btnCrear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 117);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.ddlEmpresas);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRut);
            this.Controls.Add(this.lblEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChoferCrear";
            this.Text = "Crear Chofer";
            ((System.ComponentModel.ISupportInitialize)(this.txtRut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox ddlEmpresas;
        private System.Windows.Forms.NumericUpDown txtRut;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCrear;
    }
}