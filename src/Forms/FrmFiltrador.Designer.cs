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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiltrador));
            this.lblFiltros = new System.Windows.Forms.Label();
            this.lblRango = new System.Windows.Forms.Label();
            this.nudDesde = new System.Windows.Forms.NumericUpDown();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.nudHasta = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cmbDistancia = new System.Windows.Forms.ComboBox();
            this.lblOrdenarPorDistancia = new System.Windows.Forms.Label();
            this.cmbDistanciaAscDesc = new System.Windows.Forms.ComboBox();
            this.cmbPrecioAscDesc = new System.Windows.Forms.ComboBox();
            this.lblOrdenarPrecio = new System.Windows.Forms.Label();
            this.cmbOrdenarPrecio = new System.Windows.Forms.ComboBox();
            this.barraLateral1 = new pet4sitter.BarraLateral();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltros
            // 
            this.lblFiltros.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.lblRango.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRango.AutoSize = true;
            this.lblRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRango.ForeColor = System.Drawing.Color.White;
            this.lblRango.Location = new System.Drawing.Point(418, 145);
            this.lblRango.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(229, 29);
            this.lblRango.TabIndex = 8;
            this.lblRango.Text = "Rango de Precios:";
            // 
            // nudDesde
            // 
            this.nudDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDesde.Location = new System.Drawing.Point(455, 230);
            this.nudDesde.Margin = new System.Windows.Forms.Padding(2);
            this.nudDesde.Name = "nudDesde";
            this.nudDesde.Size = new System.Drawing.Size(56, 28);
            this.nudDesde.TabIndex = 6;
            // 
            // lblDesde
            // 
            this.lblDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.White;
            this.lblDesde.Location = new System.Drawing.Point(373, 231);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(76, 24);
            this.lblDesde.TabIndex = 9;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.White;
            this.lblHasta.Location = new System.Drawing.Point(556, 232);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(68, 24);
            this.lblHasta.TabIndex = 10;
            this.lblHasta.Text = "Hasta:";
            // 
            // nudHasta
            // 
            this.nudHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHasta.Location = new System.Drawing.Point(626, 229);
            this.nudHasta.Margin = new System.Windows.Forms.Padding(2);
            this.nudHasta.Name = "nudHasta";
            this.nudHasta.Size = new System.Drawing.Size(56, 28);
            this.nudHasta.TabIndex = 11;
            this.nudHasta.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(291, 414);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(510, 39);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrar.BackColor = System.Drawing.Color.White;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorrar.Location = new System.Drawing.Point(291, 458);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(510, 39);
            this.btnBorrar.TabIndex = 23;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // cmbDistancia
            // 
            this.cmbDistancia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDistancia.FormattingEnabled = true;
            this.cmbDistancia.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbDistancia.Location = new System.Drawing.Point(580, 276);
            this.cmbDistancia.Name = "cmbDistancia";
            this.cmbDistancia.Size = new System.Drawing.Size(56, 21);
            this.cmbDistancia.TabIndex = 25;
            this.cmbDistancia.SelectedIndexChanged += new System.EventHandler(this.cmbDistancia_SelectedIndexChanged);
            // 
            // lblOrdenarPorDistancia
            // 
            this.lblOrdenarPorDistancia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrdenarPorDistancia.AutoSize = true;
            this.lblOrdenarPorDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenarPorDistancia.ForeColor = System.Drawing.Color.White;
            this.lblOrdenarPorDistancia.Location = new System.Drawing.Point(351, 273);
            this.lblOrdenarPorDistancia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrdenarPorDistancia.Name = "lblOrdenarPorDistancia";
            this.lblOrdenarPorDistancia.Size = new System.Drawing.Size(224, 24);
            this.lblOrdenarPorDistancia.TabIndex = 26;
            this.lblOrdenarPorDistancia.Text = "Ordenar Por distancia?";
            // 
            // cmbDistanciaAscDesc
            // 
            this.cmbDistanciaAscDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDistanciaAscDesc.FormattingEnabled = true;
            this.cmbDistanciaAscDesc.Items.AddRange(new object[] {
            "Menos a más",
            "Más a menos"});
            this.cmbDistanciaAscDesc.Location = new System.Drawing.Point(663, 276);
            this.cmbDistanciaAscDesc.Name = "cmbDistanciaAscDesc";
            this.cmbDistanciaAscDesc.Size = new System.Drawing.Size(94, 21);
            this.cmbDistanciaAscDesc.TabIndex = 27;
            // 
            // cmbPrecioAscDesc
            // 
            this.cmbPrecioAscDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPrecioAscDesc.FormattingEnabled = true;
            this.cmbPrecioAscDesc.Items.AddRange(new object[] {
            "Menos a más",
            "Más a menos"});
            this.cmbPrecioAscDesc.Location = new System.Drawing.Point(663, 310);
            this.cmbPrecioAscDesc.Name = "cmbPrecioAscDesc";
            this.cmbPrecioAscDesc.Size = new System.Drawing.Size(94, 21);
            this.cmbPrecioAscDesc.TabIndex = 30;
            this.cmbPrecioAscDesc.Visible = false;
            // 
            // lblOrdenarPrecio
            // 
            this.lblOrdenarPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrdenarPrecio.AutoSize = true;
            this.lblOrdenarPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenarPrecio.ForeColor = System.Drawing.Color.White;
            this.lblOrdenarPrecio.Location = new System.Drawing.Point(373, 306);
            this.lblOrdenarPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrdenarPrecio.Name = "lblOrdenarPrecio";
            this.lblOrdenarPrecio.Size = new System.Drawing.Size(201, 24);
            this.lblOrdenarPrecio.TabIndex = 29;
            this.lblOrdenarPrecio.Text = "Ordenar Por precio?";
            // 
            // cmbOrdenarPrecio
            // 
            this.cmbOrdenarPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbOrdenarPrecio.FormattingEnabled = true;
            this.cmbOrdenarPrecio.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbOrdenarPrecio.Location = new System.Drawing.Point(580, 310);
            this.cmbOrdenarPrecio.Name = "cmbOrdenarPrecio";
            this.cmbOrdenarPrecio.Size = new System.Drawing.Size(56, 21);
            this.cmbOrdenarPrecio.TabIndex = 28;
            this.cmbOrdenarPrecio.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenarPrecio_SelectedIndexChanged);
            // 
            // barraLateral1
            // 
            this.barraLateral1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barraLateral1.BackColor = System.Drawing.Color.Transparent;
            this.barraLateral1.Location = new System.Drawing.Point(0, 0);
            this.barraLateral1.Margin = new System.Windows.Forms.Padding(4);
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
            this.Controls.Add(this.cmbPrecioAscDesc);
            this.Controls.Add(this.lblOrdenarPrecio);
            this.Controls.Add(this.cmbOrdenarPrecio);
            this.Controls.Add(this.cmbDistanciaAscDesc);
            this.Controls.Add(this.lblOrdenarPorDistancia);
            this.Controls.Add(this.cmbDistancia);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1125, 635);
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
        private System.Windows.Forms.ComboBox cmbDistancia;
        private System.Windows.Forms.Label lblOrdenarPorDistancia;
        private System.Windows.Forms.ComboBox cmbDistanciaAscDesc;
        private System.Windows.Forms.ComboBox cmbPrecioAscDesc;
        private System.Windows.Forms.Label lblOrdenarPrecio;
        private System.Windows.Forms.ComboBox cmbOrdenarPrecio;
    }
}