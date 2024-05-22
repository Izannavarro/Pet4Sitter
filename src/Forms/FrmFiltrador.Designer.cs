namespace pet4sitter
{
    partial class FrmFiltrador
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
            this.lblFiltros = new System.Windows.Forms.Label();
            this.lblRango = new System.Windows.Forms.Label();
            this.nudDesde = new System.Windows.Forms.NumericUpDown();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.nudHasta = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.barraLateral1 = new pet4sitter.BarraLateral();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltros.ForeColor = System.Drawing.Color.White;
            this.lblFiltros.Location = new System.Drawing.Point(392, 92);
            this.lblFiltros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(308, 37);
            this.lblFiltros.TabIndex = 0;
            this.lblFiltros.Text = "Filtros de Cuidador";
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRango.ForeColor = System.Drawing.Color.White;
            this.lblRango.Location = new System.Drawing.Point(418, 145);
            this.lblRango.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(229, 29);
            this.lblRango.TabIndex = 8;
            this.lblRango.Text = "Rango de Precios:";
            this.lblRango.Click += new System.EventHandler(this.label4_Click);
            // 
            // nudDesde
            // 
            this.nudDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDesde.Location = new System.Drawing.Point(455, 230);
            this.nudDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudDesde.Name = "nudDesde";
            this.nudDesde.Size = new System.Drawing.Size(56, 28);
            this.nudDesde.TabIndex = 6;
            this.nudDesde.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.White;
            this.lblDesde.Location = new System.Drawing.Point(373, 231);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(76, 24);
            this.lblDesde.TabIndex = 9;
            this.lblDesde.Text = "Desde:";
            this.lblDesde.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.White;
            this.lblHasta.Location = new System.Drawing.Point(556, 232);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(68, 24);
            this.lblHasta.TabIndex = 10;
            this.lblHasta.Text = "Hasta:";
            this.lblHasta.Click += new System.EventHandler(this.label8_Click);
            // 
            // nudHasta
            // 
            this.nudHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHasta.Location = new System.Drawing.Point(626, 229);
            this.nudHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudHasta.Name = "nudHasta";
            this.nudHasta.Size = new System.Drawing.Size(56, 28);
            this.nudHasta.TabIndex = 11;
            this.nudHasta.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHasta.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(858, 204);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 29);
            this.label9.TabIndex = 15;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(291, 414);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(510, 39);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.White;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorrar.Location = new System.Drawing.Point(291, 458);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(510, 39);
            this.btnBorrar.TabIndex = 23;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(830, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 41);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // barraLateral1
            // 
            this.barraLateral1.BackColor = System.Drawing.Color.Transparent;
            this.barraLateral1.Location = new System.Drawing.Point(0, 0);
            this.barraLateral1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barraLateral1.Name = "barraLateral1";
            this.barraLateral1.Size = new System.Drawing.Size(311, 599);
            this.barraLateral1.TabIndex = 0;
            // 
            // FrmFiltrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1109, 596);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudHasta);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.lblRango);
            this.Controls.Add(this.nudDesde);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.barraLateral1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmFiltrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFiltrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFiltrador_FormClosed);
            this.Load += new System.EventHandler(this.FrmFiltrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Label lblRango;
        private System.Windows.Forms.NumericUpDown nudDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.NumericUpDown nudHasta;
        private System.Windows.Forms.Label label9;
        private BarraLateral barraLateral1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button button1;
    }
}