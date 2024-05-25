namespace pet4sitter
{
    partial class FrmPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfil));
            this.pcbProd1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblPrecioProd1 = new System.Windows.Forms.Label();
            this.lblProd1 = new System.Windows.Forms.Label();
            this.lblTePodriaInteresar = new System.Windows.Forms.Label();
            this.btnEditarPerfil = new System.Windows.Forms.Button();
            this.btnDarAlta = new System.Windows.Forms.Button();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblLocalizacion = new System.Windows.Forms.Label();
            this.btnDarseBaja = new System.Windows.Forms.Button();
            this.barraLateral1 = new pet4sitter.BarraLateral(this);
            this.btnPremium = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPrecioProd2 = new System.Windows.Forms.Label();
            this.lblProd2 = new System.Windows.Forms.Label();
            this.pcbProd2 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblPrecioProd3 = new System.Windows.Forms.Label();
            this.lblProd3 = new System.Windows.Forms.Label();
            this.pcbProd3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProd1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProd2)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProd3)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbProd1
            // 
            this.pcbProd1.BackColor = System.Drawing.Color.Gainsboro;
            this.pcbProd1.Location = new System.Drawing.Point(16, 16);
            this.pcbProd1.Margin = new System.Windows.Forms.Padding(2);
            this.pcbProd1.Name = "pcbProd1";
            this.pcbProd1.Size = new System.Drawing.Size(224, 152);
            this.pcbProd1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbProd1.TabIndex = 3;
            this.pcbProd1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(98)))));
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(146, 280);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 271);
            this.panel4.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblPrecioProd1);
            this.panel6.Controls.Add(this.lblProd1);
            this.panel6.Controls.Add(this.pcbProd1);
            this.panel6.Location = new System.Drawing.Point(14, 17);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(262, 247);
            this.panel6.TabIndex = 4;
            // 
            // lblPrecioProd1
            // 
            this.lblPrecioProd1.AutoSize = true;
            this.lblPrecioProd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProd1.Location = new System.Drawing.Point(20, 210);
            this.lblPrecioProd1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioProd1.Name = "lblPrecioProd1";
            this.lblPrecioProd1.Size = new System.Drawing.Size(16, 18);
            this.lblPrecioProd1.TabIndex = 7;
            this.lblPrecioProd1.Text = "0";
            // 
            // lblProd1
            // 
            this.lblProd1.AutoSize = true;
            this.lblProd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd1.Location = new System.Drawing.Point(20, 181);
            this.lblProd1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProd1.Name = "lblProd1";
            this.lblProd1.Size = new System.Drawing.Size(104, 18);
            this.lblProd1.TabIndex = 6;
            this.lblProd1.Text = "Sin producto";
            // 
            // lblTePodriaInteresar
            // 
            this.lblTePodriaInteresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTePodriaInteresar.AutoSize = true;
            this.lblTePodriaInteresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTePodriaInteresar.Location = new System.Drawing.Point(498, 236);
            this.lblTePodriaInteresar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTePodriaInteresar.Name = "lblTePodriaInteresar";
            this.lblTePodriaInteresar.Size = new System.Drawing.Size(218, 26);
            this.lblTePodriaInteresar.TabIndex = 9;
            this.lblTePodriaInteresar.Text = "Te podría interesar:";
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditarPerfil.BackColor = System.Drawing.Color.White;
            this.btnEditarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPerfil.Location = new System.Drawing.Point(817, 23);
            this.btnEditarPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(166, 44);
            this.btnEditarPerfil.TabIndex = 10;
            this.btnEditarPerfil.Text = "Editar Perfil";
            this.btnEditarPerfil.UseVisualStyleBackColor = false;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // btnDarAlta
            // 
            this.btnDarAlta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDarAlta.BackColor = System.Drawing.Color.White;
            this.btnDarAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarAlta.Location = new System.Drawing.Point(748, 77);
            this.btnDarAlta.Margin = new System.Windows.Forms.Padding(2);
            this.btnDarAlta.Name = "btnDarAlta";
            this.btnDarAlta.Size = new System.Drawing.Size(284, 46);
            this.btnDarAlta.TabIndex = 11;
            this.btnDarAlta.Text = "Ser Cuidador";
            this.btnDarAlta.UseVisualStyleBackColor = false;
            this.btnDarAlta.Click += new System.EventHandler(this.btnDarAlta_Click);
            // 
            // pcbImagen
            // 
            this.pcbImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbImagen.BackColor = System.Drawing.Color.Transparent;
            this.pcbImagen.Image = global::pet4sitter.Properties.Resources.usuario;
            this.pcbImagen.Location = new System.Drawing.Point(173, 23);
            this.pcbImagen.Margin = new System.Windows.Forms.Padding(2);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(202, 184);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagen.TabIndex = 12;
            this.pcbImagen.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(403, 32);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(265, 26);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Información del Usuario";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(403, 97);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(265, 26);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "Información del Usuario";
            // 
            // lblLocalizacion
            // 
            this.lblLocalizacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLocalizacion.AutoSize = true;
            this.lblLocalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalizacion.Location = new System.Drawing.Point(403, 161);
            this.lblLocalizacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalizacion.Name = "lblLocalizacion";
            this.lblLocalizacion.Size = new System.Drawing.Size(265, 26);
            this.lblLocalizacion.TabIndex = 16;
            this.lblLocalizacion.Text = "Información del Usuario";
            // 
            // btnDarseBaja
            // 
            this.btnDarseBaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDarseBaja.BackColor = System.Drawing.Color.White;
            this.btnDarseBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarseBaja.Location = new System.Drawing.Point(748, 77);
            this.btnDarseBaja.Margin = new System.Windows.Forms.Padding(2);
            this.btnDarseBaja.Name = "btnDarseBaja";
            this.btnDarseBaja.Size = new System.Drawing.Size(284, 46);
            this.btnDarseBaja.TabIndex = 17;
            this.btnDarseBaja.Text = "Darse Baja Cuidador";
            this.btnDarseBaja.UseVisualStyleBackColor = false;
            this.btnDarseBaja.Visible = false;
            this.btnDarseBaja.Click += new System.EventHandler(this.btnDarseBaja_Click);
            // 
            // barraLateral1
            // 
            this.barraLateral1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barraLateral1.BackColor = System.Drawing.Color.Transparent;
            this.barraLateral1.Location = new System.Drawing.Point(0, -2);
            this.barraLateral1.Margin = new System.Windows.Forms.Padding(4);
            this.barraLateral1.Name = "barraLateral1";
            this.barraLateral1.Size = new System.Drawing.Size(311, 599);
            this.barraLateral1.TabIndex = 14;
            // 
            // btnPremium
            // 
            this.btnPremium.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPremium.BackColor = System.Drawing.Color.White;
            this.btnPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremium.Location = new System.Drawing.Point(817, 139);
            this.btnPremium.Margin = new System.Windows.Forms.Padding(2);
            this.btnPremium.Name = "btnPremium";
            this.btnPremium.Size = new System.Drawing.Size(166, 46);
            this.btnPremium.TabIndex = 18;
            this.btnPremium.Text = "Premium";
            this.btnPremium.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(98)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(473, 280);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 271);
            this.panel3.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lblPrecioProd2);
            this.panel5.Controls.Add(this.lblProd2);
            this.panel5.Controls.Add(this.pcbProd2);
            this.panel5.Location = new System.Drawing.Point(14, 17);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 247);
            this.panel5.TabIndex = 4;
            // 
            // lblPrecioProd2
            // 
            this.lblPrecioProd2.AutoSize = true;
            this.lblPrecioProd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProd2.Location = new System.Drawing.Point(20, 210);
            this.lblPrecioProd2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioProd2.Name = "lblPrecioProd2";
            this.lblPrecioProd2.Size = new System.Drawing.Size(16, 18);
            this.lblPrecioProd2.TabIndex = 8;
            this.lblPrecioProd2.Text = "0";
            // 
            // lblProd2
            // 
            this.lblProd2.AutoSize = true;
            this.lblProd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd2.Location = new System.Drawing.Point(20, 181);
            this.lblProd2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProd2.Name = "lblProd2";
            this.lblProd2.Size = new System.Drawing.Size(104, 18);
            this.lblProd2.TabIndex = 6;
            this.lblProd2.Text = "Sin producto";
            // 
            // pcbProd2
            // 
            this.pcbProd2.BackColor = System.Drawing.Color.Gainsboro;
            this.pcbProd2.Location = new System.Drawing.Point(16, 16);
            this.pcbProd2.Margin = new System.Windows.Forms.Padding(2);
            this.pcbProd2.Name = "pcbProd2";
            this.pcbProd2.Size = new System.Drawing.Size(224, 152);
            this.pcbProd2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbProd2.TabIndex = 3;
            this.pcbProd2.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(98)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(799, 280);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(288, 271);
            this.panel7.TabIndex = 20;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.lblPrecioProd3);
            this.panel8.Controls.Add(this.lblProd3);
            this.panel8.Controls.Add(this.pcbProd3);
            this.panel8.Location = new System.Drawing.Point(14, 17);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(262, 247);
            this.panel8.TabIndex = 4;
            // 
            // lblPrecioProd3
            // 
            this.lblPrecioProd3.AutoSize = true;
            this.lblPrecioProd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProd3.Location = new System.Drawing.Point(28, 210);
            this.lblPrecioProd3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioProd3.Name = "lblPrecioProd3";
            this.lblPrecioProd3.Size = new System.Drawing.Size(16, 18);
            this.lblPrecioProd3.TabIndex = 9;
            this.lblPrecioProd3.Text = "0";
            // 
            // lblProd3
            // 
            this.lblProd3.AutoSize = true;
            this.lblProd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd3.Location = new System.Drawing.Point(20, 181);
            this.lblProd3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProd3.Name = "lblProd3";
            this.lblProd3.Size = new System.Drawing.Size(104, 18);
            this.lblProd3.TabIndex = 6;
            this.lblProd3.Text = "Sin producto";
            // 
            // pcbProd3
            // 
            this.pcbProd3.BackColor = System.Drawing.Color.Gainsboro;
            this.pcbProd3.Location = new System.Drawing.Point(16, 16);
            this.pcbProd3.Margin = new System.Windows.Forms.Padding(2);
            this.pcbProd3.Name = "pcbProd3";
            this.pcbProd3.Size = new System.Drawing.Size(224, 152);
            this.pcbProd3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbProd3.TabIndex = 3;
            this.pcbProd3.TabStop = false;
            // 
            // FrmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1109, 596);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnPremium);
            this.Controls.Add(this.lblLocalizacion);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.btnDarAlta);
            this.Controls.Add(this.btnEditarPerfil);
            this.Controls.Add(this.lblTePodriaInteresar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.barraLateral1);
            this.Controls.Add(this.btnDarseBaja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1125, 635);
            this.Name = "FrmPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPerfil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPerfil_FormClosed);
            this.Load += new System.EventHandler(this.FrmPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbProd1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProd2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProd3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbProd1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblProd1;
        private System.Windows.Forms.Label lblTePodriaInteresar;
        private System.Windows.Forms.Button btnEditarPerfil;
        private System.Windows.Forms.Button btnDarAlta;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.Label lblNombre;
        private BarraLateral barraLateral1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblLocalizacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDarseBaja;
        private System.Windows.Forms.Button btnPremium;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblProd2;
        private System.Windows.Forms.PictureBox pcbProd2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblProd3;
        private System.Windows.Forms.PictureBox pcbProd3;
        private System.Windows.Forms.Label lblPrecioProd1;
        private System.Windows.Forms.Label lblPrecioProd2;
        private System.Windows.Forms.Label lblPrecioProd3;
    }
}