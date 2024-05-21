namespace pet4sitter
{
    partial class FrmInicioAdmin
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
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnNoticias = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProductos
            // 
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(377, 46);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(277, 254);
            this.btnProductos.TabIndex = 48;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnNoticias
            // 
            this.btnNoticias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoticias.Location = new System.Drawing.Point(676, 46);
            this.btnNoticias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNoticias.Name = "btnNoticias";
            this.btnNoticias.Size = new System.Drawing.Size(277, 254);
            this.btnNoticias.TabIndex = 49;
            this.btnNoticias.Text = "Noticias";
            this.btnNoticias.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(676, 327);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(277, 254);
            this.btnCerrarSesion.TabIndex = 51;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(377, 327);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(277, 254);
            this.btnUsuarios.TabIndex = 50;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // FrmInicioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1479, 734);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnNoticias);
            this.Controls.Add(this.btnProductos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmInicioAdmin";
            this.Text = "FrmInicioAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmInicioAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FrmInicioAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnNoticias;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnUsuarios;
    }
}