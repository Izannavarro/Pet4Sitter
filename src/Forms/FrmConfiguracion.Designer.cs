namespace piTest
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
            this.lblConfiguracionAvanzada = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblPrivacidad = new System.Windows.Forms.Label();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.lblDesactivar = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.lbl2pasos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConfiguracionAvanzada
            // 
            this.lblConfiguracionAvanzada.AutoSize = true;
            this.lblConfiguracionAvanzada.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracionAvanzada.Location = new System.Drawing.Point(179, 43);
            this.lblConfiguracionAvanzada.Name = "lblConfiguracionAvanzada";
            this.lblConfiguracionAvanzada.Size = new System.Drawing.Size(405, 38);
            this.lblConfiguracionAvanzada.TabIndex = 0;
            this.lblConfiguracionAvanzada.Text = "Configuracion Avanzada:";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(149, 123);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(92, 29);
            this.lblIdioma.TabIndex = 1;
            this.lblIdioma.Text = "Idioma:";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.Location = new System.Drawing.Point(439, 125);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(82, 29);
            this.lblTema.TabIndex = 2;
            this.lblTema.Text = "Tema:";
            // 
            // lblPrivacidad
            // 
            this.lblPrivacidad.AutoSize = true;
            this.lblPrivacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivacidad.Location = new System.Drawing.Point(181, 344);
            this.lblPrivacidad.Name = "lblPrivacidad";
            this.lblPrivacidad.Size = new System.Drawing.Size(365, 29);
            this.lblPrivacidad.TabIndex = 4;
            this.lblPrivacidad.Text = "Politica de Privacidad de Datos...";
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.Location = new System.Drawing.Point(200, 226);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(221, 29);
            this.lblEliminar.TabIndex = 5;
            this.lblEliminar.Text = "Eliminar Mi Cuenta:";
            // 
            // lblDesactivar
            // 
            this.lblDesactivar.AutoSize = true;
            this.lblDesactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesactivar.Location = new System.Drawing.Point(176, 286);
            this.lblDesactivar.Name = "lblDesactivar";
            this.lblDesactivar.Size = new System.Drawing.Size(245, 29);
            this.lblDesactivar.TabIndex = 6;
            this.lblDesactivar.Text = "Desactivar Mi Cuenta:";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.cmbIdioma.Location = new System.Drawing.Point(247, 130);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(161, 24);
            this.cmbIdioma.TabIndex = 7;
            this.cmbIdioma.SelectedIndexChanged += new System.EventHandler(this.cmbIdioma_SelectedIndexChanged);
            // 
            // cmbTema
            // 
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Items.AddRange(new object[] {
            "Claro",
            "Oscuro"});
            this.cmbTema.Location = new System.Drawing.Point(527, 132);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(161, 24);
            this.cmbTema.TabIndex = 8;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(444, 226);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 38);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivar.Location = new System.Drawing.Point(444, 285);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(123, 38);
            this.btnDesactivar.TabIndex = 10;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            // 
            // lbl2pasos
            // 
            this.lbl2pasos.AutoSize = true;
            this.lbl2pasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2pasos.Location = new System.Drawing.Point(97, 179);
            this.lbl2pasos.Name = "lbl2pasos";
            this.lbl2pasos.Size = new System.Drawing.Size(324, 29);
            this.lbl2pasos.TabIndex = 3;
            this.lbl2pasos.Text = "Autentificación en dos pasos:";
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDesactivar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cmbTema);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.lblDesactivar);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.lblPrivacidad);
            this.Controls.Add(this.lbl2pasos);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblConfiguracionAvanzada);
            this.Name = "FrmConfiguracion";
            this.Text = "FrmConfiguracion";
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfiguracionAvanzada;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblPrivacidad;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Label lblDesactivar;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.ComboBox cmbTema;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Label lbl2pasos;
    }
}