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
            this.txtEgreso = new System.Windows.Forms.TextBox();
            this.lblLitros = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // txtEgreso
            // 
            this.txtEgreso.Location = new System.Drawing.Point(62, 13);
            this.txtEgreso.Name = "txtEgreso";
            this.txtEgreso.Size = new System.Drawing.Size(200, 20);
            this.txtEgreso.TabIndex = 1;
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(62, 40);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(62, 67);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar Ticket";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // EgresoGuiaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.txtEgreso);
            this.Controls.Add(this.lblEgreso);
            this.Name = "EgresoGuiaControl";
            this.Size = new System.Drawing.Size(278, 107);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEgreso;
        private System.Windows.Forms.TextBox txtEgreso;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnCerrar;
    }
}
