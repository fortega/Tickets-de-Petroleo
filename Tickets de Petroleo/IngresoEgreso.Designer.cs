namespace Tickets_de_Petroleo
{
    partial class IngresoEgreso
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
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.gv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ddlBombas = new System.Windows.Forms.ComboBox();
            this.lblBomba = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSaldoTexto = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSaldoValor = new System.Windows.Forms.ToolStripStatusLabel();
            this.layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.ColumnCount = 1;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Controls.Add(this.gv, 0, 0);
            this.layout.Controls.Add(this.panel1, 0, 1);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 2;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layout.Size = new System.Drawing.Size(591, 442);
            this.layout.TabIndex = 0;
            // 
            // gv
            // 
            this.gv.AllowUserToAddRows = false;
            this.gv.AllowUserToDeleteRows = false;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv.Location = new System.Drawing.Point(3, 3);
            this.gv.Name = "gv";
            this.gv.ReadOnly = true;
            this.gv.Size = new System.Drawing.Size(585, 386);
            this.gv.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBomba);
            this.panel1.Controls.Add(this.ddlBombas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 44);
            this.panel1.TabIndex = 1;
            // 
            // ddlBombas
            // 
            this.ddlBombas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlBombas.FormattingEnabled = true;
            this.ddlBombas.Location = new System.Drawing.Point(56, 0);
            this.ddlBombas.Name = "ddlBombas";
            this.ddlBombas.Size = new System.Drawing.Size(121, 21);
            this.ddlBombas.TabIndex = 0;
            this.ddlBombas.SelectedIndexChanged += new System.EventHandler(this.cargarDatos);
            // 
            // lblBomba
            // 
            this.lblBomba.AutoSize = true;
            this.lblBomba.Location = new System.Drawing.Point(7, 3);
            this.lblBomba.Name = "lblBomba";
            this.lblBomba.Size = new System.Drawing.Size(43, 13);
            this.lblBomba.TabIndex = 1;
            this.lblBomba.Text = "Bomba:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSaldoTexto,
            this.lblSaldoValor});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(591, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSaldoTexto
            // 
            this.lblSaldoTexto.Name = "lblSaldoTexto";
            this.lblSaldoTexto.Size = new System.Drawing.Size(39, 17);
            this.lblSaldoTexto.Text = "Saldo:";
            // 
            // lblSaldoValor
            // 
            this.lblSaldoValor.Name = "lblSaldoValor";
            this.lblSaldoValor.Size = new System.Drawing.Size(13, 17);
            this.lblSaldoValor.Text = "0";
            // 
            // IngresoEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 442);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.layout);
            this.Name = "IngresoEgreso";
            this.Text = "IngresoEgreso";
            this.layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ddlBombas;
        private System.Windows.Forms.Label lblBomba;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSaldoTexto;
        private System.Windows.Forms.ToolStripStatusLabel lblSaldoValor;
    }
}