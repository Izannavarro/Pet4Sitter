namespace pet4sitter
{
    partial class FrmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracion));
            this.lblConfiguracionAvanzada = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblPrivacidad = new System.Windows.Forms.Label();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ptbVolver = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConfiguracionAvanzada
            // 
            this.lblConfiguracionAvanzada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfiguracionAvanzada.AutoSize = true;
            this.lblConfiguracionAvanzada.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracionAvanzada.Location = new System.Drawing.Point(142, 35);
            this.lblConfiguracionAvanzada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfiguracionAvanzada.Name = "lblConfiguracionAvanzada";
            this.lblConfiguracionAvanzada.Size = new System.Drawing.Size(341, 31);
            this.lblConfiguracionAvanzada.TabIndex = 0;
            this.lblConfiguracionAvanzada.Text = "Configuracion Avanzada:";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(2, 0);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIdioma.Size = new System.Drawing.Size(71, 24);
            this.lblIdioma.TabIndex = 1;
            this.lblIdioma.Text = "Idioma:";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.Location = new System.Drawing.Point(2, 0);
            this.lblTema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(64, 24);
            this.lblTema.TabIndex = 2;
            this.lblTema.Text = "Tema:";
            // 
            // lblPrivacidad
            // 
            this.lblPrivacidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrivacidad.AutoSize = true;
            this.lblPrivacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivacidad.Location = new System.Drawing.Point(138, 301);
            this.lblPrivacidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrivacidad.Name = "lblPrivacidad";
            this.lblPrivacidad.Size = new System.Drawing.Size(282, 24);
            this.lblPrivacidad.TabIndex = 4;
            this.lblPrivacidad.Text = "Politica de Privacidad de Datos...";
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.Location = new System.Drawing.Point(2, 0);
            this.lblEliminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(173, 24);
            this.lblEliminar.TabIndex = 5;
            this.lblEliminar.Text = "Eliminar Mi Cuenta:";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.cmbIdioma.Location = new System.Drawing.Point(77, 2);
            this.cmbIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(115, 21);
            this.cmbIdioma.TabIndex = 7;
            this.cmbIdioma.SelectedIndexChanged += new System.EventHandler(this.cmbIdioma_SelectedIndexChanged);
            // 
            // cmbTema
            // 
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Items.AddRange(new object[] {
            "Claro",
            "Oscuro"});
            this.cmbTema.Location = new System.Drawing.Point(70, 2);
            this.cmbTema.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(122, 21);
            this.cmbTema.TabIndex = 8;
            this.cmbTema.SelectedIndexChanged += new System.EventHandler(this.cmbTema_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(179, 2);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 26);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblIdioma, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbIdioma, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(76, 127);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(215, 27);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lblTema, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbTema, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(340, 127);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(214, 27);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.btnEliminar, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblEliminar, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(142, 196);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(319, 31);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // ptbVolver
            // 
            this.ptbVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbVolver.Image = global::pet4sitter.Properties.Resources.lgo;
            this.ptbVolver.Location = new System.Drawing.Point(500, 18);
            this.ptbVolver.Margin = new System.Windows.Forms.Padding(2);
            this.ptbVolver.Name = "ptbVolver";
            this.ptbVolver.Size = new System.Drawing.Size(65, 64);
            this.ptbVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbVolver.TabIndex = 15;
            this.ptbVolver.TabStop = false;
            this.ptbVolver.Click += new System.EventHandler(this.ptbVolver_Click);
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ptbVolver);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblPrivacidad);
            this.Controls.Add(this.lblConfiguracionAvanzada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfiguracion";
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfiguracionAvanzada;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblPrivacidad;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.ComboBox cmbTema;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox ptbVolver;
    }
}