namespace Tickets_de_Petroleo
{
    partial class CamionCrear
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
            this.lblPatente = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.ddlEmpresa = new System.Windows.Forms.ComboBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
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
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(16, 37);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(47, 13);
            this.lblPatente.TabIndex = 1;
            this.lblPatente.Text = "Patente:";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(69, 60);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // ddlEmpresa
            // 
            this.ddlEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEmpresa.FormattingEnabled = true;
            this.ddlEmpresa.Location = new System.Drawing.Point(69, 6);
            this.ddlEmpresa.Name = "ddlEmpresa";
            this.ddlEmpresa.Size = new System.Drawing.Size(121, 21);
            this.ddlEmpresa.TabIndex = 3;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(69, 34);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(121, 20);
            this.txtPatente.TabIndex = 4;
            // 
            // CamionCrear
            // 
            this.AcceptButton = this.btnCrear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 93);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.ddlEmpresa);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.lblEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CamionCrear";
            this.Text = "Crear Camion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ComboBox ddlEmpresa;
        private System.Windows.Forms.TextBox txtPatente;
    }
}