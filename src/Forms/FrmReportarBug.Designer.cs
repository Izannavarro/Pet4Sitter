namespace pet4sitter.Forms
{
    partial class FrmReportarBug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportarBug));
            this.lblReportarBug = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronicoUsuario = new System.Windows.Forms.Label();
            this.lblDetallesDelBug = new System.Windows.Forms.Label();
            this.txtCuerpoMensaje = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnVolverALogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReportarBug
            // 
            this.lblReportarBug.AutoSize = true;
            this.lblReportarBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportarBug.ForeColor = System.Drawing.Color.White;
            this.lblReportarBug.Location = new System.Drawing.Point(180, 9);
            this.lblReportarBug.Name = "lblReportarBug";
            this.lblReportarBug.Size = new System.Drawing.Size(410, 33);
            this.lblReportarBug.TabIndex = 0;
            this.lblReportarBug.Text = "Reporta un bug de pet4sitter";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(409, 88);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(231, 20);
            this.txtMail.TabIndex = 1;
            // 
            // lblCorreoElectronicoUsuario
            // 
            this.lblCorreoElectronicoUsuario.AutoSize = true;
            this.lblCorreoElectronicoUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblCorreoElectronicoUsuario.Location = new System.Drawing.Point(148, 91);
            this.lblCorreoElectronicoUsuario.Name = "lblCorreoElectronicoUsuario";
            this.lblCorreoElectronicoUsuario.Size = new System.Drawing.Size(258, 13);
            this.lblCorreoElectronicoUsuario.TabIndex = 2;
            this.lblCorreoElectronicoUsuario.Text = "Correo Electrónico del usuario (serás recompensado):";
            // 
            // lblDetallesDelBug
            // 
            this.lblDetallesDelBug.AutoSize = true;
            this.lblDetallesDelBug.ForeColor = System.Drawing.Color.Black;
            this.lblDetallesDelBug.Location = new System.Drawing.Point(148, 139);
            this.lblDetallesDelBug.Name = "lblDetallesDelBug";
            this.lblDetallesDelBug.Size = new System.Drawing.Size(86, 13);
            this.lblDetallesDelBug.TabIndex = 3;
            this.lblDetallesDelBug.Text = "Detalles del bug:";
            // 
            // txtCuerpoMensaje
            // 
            this.txtCuerpoMensaje.Location = new System.Drawing.Point(151, 166);
            this.txtCuerpoMensaje.Multiline = true;
            this.txtCuerpoMensaje.Name = "txtCuerpoMensaje";
            this.txtCuerpoMensaje.Size = new System.Drawing.Size(489, 145);
            this.txtCuerpoMensaje.TabIndex = 4;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(151, 317);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(489, 35);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar BUG a pet4sitter";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnVolverALogin
            // 
            this.btnVolverALogin.Location = new System.Drawing.Point(151, 358);
            this.btnVolverALogin.Name = "btnVolverALogin";
            this.btnVolverALogin.Size = new System.Drawing.Size(489, 35);
            this.btnVolverALogin.TabIndex = 6;
            this.btnVolverALogin.Text = "Volver a login";
            this.btnVolverALogin.UseVisualStyleBackColor = true;
            this.btnVolverALogin.Click += new System.EventHandler(this.btnVolverALogin_Click);
            // 
            // FrmReportarBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverALogin);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtCuerpoMensaje);
            this.Controls.Add(this.lblDetallesDelBug);
            this.Controls.Add(this.lblCorreoElectronicoUsuario);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblReportarBug);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportarBug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReportarBug";
            this.Load += new System.EventHandler(this.FrmReportarBug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReportarBug;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblCorreoElectronicoUsuario;
        private System.Windows.Forms.Label lblDetallesDelBug;
        private System.Windows.Forms.TextBox txtCuerpoMensaje;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnVolverALogin;
    }
}