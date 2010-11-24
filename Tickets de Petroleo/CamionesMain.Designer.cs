namespace Tickets_de_Petroleo
{
    partial class CamionesMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.gv = new System.Windows.Forms.DataGridView();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.ColumnCount = 2;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.layout.Controls.Add(this.gv, 0, 0);
            this.layout.Controls.Add(this.pnlBotones, 1, 0);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 1;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout.Size = new System.Drawing.Size(544, 474);
            this.layout.TabIndex = 1;
            // 
            // gv
            // 
            this.gv.AllowUserToAddRows = false;
            this.gv.AllowUserToDeleteRows = false;
            this.gv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv.DefaultCellStyle = dataGridViewCellStyle8;
            this.gv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv.Location = new System.Drawing.Point(3, 3);
            this.gv.MultiSelect = false;
            this.gv.Name = "gv";
            this.gv.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv.Size = new System.Drawing.Size(448, 468);
            this.gv.TabIndex = 0;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnBorrar);
            this.pnlBotones.Controls.Add(this.btnEditar);
            this.pnlBotones.Controls.Add(this.btnCrear);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotones.Location = new System.Drawing.Point(457, 3);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(84, 468);
            this.pnlBotones.TabIndex = 1;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(4, 70);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(4, 40);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(4, 10);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // CamionesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 474);
            this.Controls.Add(this.layout);
            this.Name = "CamionesMain";
            this.Text = "CamionesMain";
            this.layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCrear;
    }
}