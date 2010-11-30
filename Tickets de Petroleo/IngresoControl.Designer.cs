namespace Tickets_de_Petroleo
{
    partial class IngresoControl
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
            this.lblBomba = new System.Windows.Forms.Label();
            this.ddlBombas = new System.Windows.Forms.ComboBox();
            this.lblLitros = new System.Windows.Forms.Label();
            this.txtLitros = new System.Windows.Forms.NumericUpDown();
            this.btnIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtLitros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBomba
            // 
            this.lblBomba.AutoSize = true;
            this.lblBomba.Location = new System.Drawing.Point(14, 17);
            this.lblBomba.Name = "lblBomba";
            this.lblBomba.Size = new System.Drawing.Size(43, 13);
            this.lblBomba.TabIndex = 0;
            this.lblBomba.Text = "Bomba:";
            // 
            // ddlBombas
            // 
            this.ddlBombas.FormattingEnabled = true;
            this.ddlBombas.Location = new System.Drawing.Point(63, 14);
            this.ddlBombas.Name = "ddlBombas";
            this.ddlBombas.Size = new System.Drawing.Size(121, 21);
            this.ddlBombas.TabIndex = 1;
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(22, 44);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(35, 13);
            this.lblLitros.TabIndex = 2;
            this.lblLitros.Text = "Litros:";
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(63, 42);
            this.txtLitros.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtLitros.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(120, 20);
            this.txtLitros.TabIndex = 3;
            this.txtLitros.ThousandsSeparator = true;
            this.txtLitros.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(63, 69);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // IngresoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.ddlBombas);
            this.Controls.Add(this.lblBomba);
            this.Name = "IngresoControl";
            this.Size = new System.Drawing.Size(202, 103);
            ((System.ComponentModel.ISupportInitialize)(this.txtLitros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBomba;
        private System.Windows.Forms.ComboBox ddlBombas;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.NumericUpDown txtLitros;
        private System.Windows.Forms.Button btnIngresar;
    }
}
