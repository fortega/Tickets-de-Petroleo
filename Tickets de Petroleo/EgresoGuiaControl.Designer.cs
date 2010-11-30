namespace Tickets_de_Petroleo
{
    partial class EgresoGuiaControl
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
            this.lblEgreso = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.txtLitros = new System.Windows.Forms.NumericUpDown();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtEgreso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtLitros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEgreso
            // 
            this.lblEgreso.AutoSize = true;
            this.lblEgreso.Location = new System.Drawing.Point(16, 16);
            this.lblEgreso.Name = "lblEgreso";
            this.lblEgreso.Size = new System.Drawing.Size(40, 13);
            this.lblEgreso.TabIndex = 0;
            this.lblEgreso.Text = "Ticket:";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(21, 42);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(35, 13);
            this.lblLitros.TabIndex = 2;
            this.lblLitros.Text = "Litros:";
            // 
            // txtLitros
            // 
            this.txtLitros.DecimalPlaces = 1;
            this.txtLitros.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtLitros.Location = new System.Drawing.Point(62, 40);
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
            this.txtLitros.Size = new System.Drawing.Size(200, 20);
            this.txtLitros.TabIndex = 3;
            this.txtLitros.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(62, 67);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar Ticket";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtEgreso
            // 
            this.txtEgreso.Location = new System.Drawing.Point(62, 13);
            this.txtEgreso.Name = "txtEgreso";
            this.txtEgreso.Size = new System.Drawing.Size(200, 20);
            this.txtEgreso.TabIndex = 1;
            // 
            // EgresoGuiaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.txtEgreso);
            this.Controls.Add(this.lblEgreso);
            this.Name = "EgresoGuiaControl";
            this.Size = new System.Drawing.Size(278, 107);
            ((System.ComponentModel.ISupportInitialize)(this.txtLitros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEgreso;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.NumericUpDown txtLitros;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtEgreso;
    }
}
