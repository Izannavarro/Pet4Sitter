using System.Drawing;

namespace pet4sitter
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.lblWelcomeLogin = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblLinePassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnContinueWGoogle = new System.Windows.Forms.Button();
            this.pictureBoxContinueGoogle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContinueGoogle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeLogin
            // 
            this.lblWelcomeLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcomeLogin.AutoSize = true;
            this.lblWelcomeLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 25.25F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeLogin.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeLogin.Location = new System.Drawing.Point(461, 64);
            this.lblWelcomeLogin.Margin = new System.Windows.Forms.Padding(0);
            this.lblWelcomeLogin.Name = "lblWelcomeLogin";
            this.lblWelcomeLogin.Size = new System.Drawing.Size(181, 44);
            this.lblWelcomeLogin.TabIndex = 0;
            this.lblWelcomeLogin.Text = "Regístrate";
            // 
            // lblMail
            // 
            this.lblMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMail.AutoSize = true;
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(344, 204);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(94, 13);
            this.lblMail.TabIndex = 1;
            this.lblMail.Text = "Introduce tu email:";
            // 
            // txtMail
            // 
            this.txtMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtMail.ForeColor = System.Drawing.Color.Gray;
            this.txtMail.Location = new System.Drawing.Point(347, 221);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(432, 27);
            this.txtMail.TabIndex = 3;
            this.txtMail.Text = "Introduce email";
            this.txtMail.Enter += new System.EventHandler(this.txtMail_Enter);
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtPass.ForeColor = System.Drawing.Color.Gray;
            this.txtPass.Location = new System.Drawing.Point(347, 289);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(432, 27);
            this.txtPass.TabIndex = 4;
            this.txtPass.Text = "Introduce contraseña";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // lblPass
            // 
            this.lblPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPass.AutoSize = true;
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(344, 274);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(123, 13);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Introduce tu contraseña:";
            // 
            // lblLine
            // 
            this.lblLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLine.BackColor = System.Drawing.Color.Gray;
            this.lblLine.Location = new System.Drawing.Point(347, 240);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(432, 2);
            this.lblLine.TabIndex = 6;
            // 
            // lblLinePassword
            // 
            this.lblLinePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLinePassword.BackColor = System.Drawing.Color.Gray;
            this.lblLinePassword.Location = new System.Drawing.Point(347, 309);
            this.lblLinePassword.Name = "lblLinePassword";
            this.lblLinePassword.Size = new System.Drawing.Size(432, 2);
            this.lblLinePassword.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Location = new System.Drawing.Point(345, 438);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(432, 28);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Volver a Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnContinueWGoogle
            // 
            this.btnContinueWGoogle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnContinueWGoogle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinueWGoogle.Location = new System.Drawing.Point(345, 471);
            this.btnContinueWGoogle.Name = "btnContinueWGoogle";
            this.btnContinueWGoogle.Size = new System.Drawing.Size(432, 28);
            this.btnContinueWGoogle.TabIndex = 8;
            this.btnContinueWGoogle.Text = "Regístrate con google";
            this.btnContinueWGoogle.UseVisualStyleBackColor = true;
            this.btnContinueWGoogle.Click += new System.EventHandler(this.btnIniciarSesionGoogle_Click);
            this.btnContinueWGoogle.Leave += new System.EventHandler(this.btnContinueWGoogle_Leave);
            this.btnContinueWGoogle.MouseLeave += new System.EventHandler(this.btnContinueWGoogle_Leave);
            this.btnContinueWGoogle.MouseHover += new System.EventHandler(this.btnContinueWGoogle_MouseHover);
            // 
            // pictureBoxContinueGoogle
            // 
            this.pictureBoxContinueGoogle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxContinueGoogle.BackColor = System.Drawing.Color.White;
            this.pictureBoxContinueGoogle.Image = global::pet4sitter.Properties.Resources.google_icon_icons_com_62736;
            this.pictureBoxContinueGoogle.Location = new System.Drawing.Point(482, 474);
            this.pictureBoxContinueGoogle.Name = "pictureBoxContinueGoogle";
            this.pictureBoxContinueGoogle.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxContinueGoogle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxContinueGoogle.TabIndex = 12;
            this.pictureBoxContinueGoogle.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(202, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 2);
            this.label1.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(202, 155);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 27);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(199, 139);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(408, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 2);
            this.label2.TabIndex = 18;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtApellido.ForeColor = System.Drawing.Color.Gray;
            this.txtApellido.Location = new System.Drawing.Point(408, 155);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(226, 27);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.Text = "Apellido:";
            this.txtApellido.Enter += new System.EventHandler(this.txtApellido_Enter);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(404, 139);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 16;
            this.lblApellido.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(685, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 2);
            this.label3.TabIndex = 22;
            // 
            // txtDni
            // 
            this.txtDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtDni.ForeColor = System.Drawing.Color.Gray;
            this.txtDni.Location = new System.Drawing.Point(685, 155);
            this.txtDni.MaxLength = 9;
            this.txtDni.Multiline = true;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(226, 27);
            this.txtDni.TabIndex = 2;
            this.txtDni.Text = "DNI:";
            this.txtDni.Enter += new System.EventHandler(this.txtDni_Enter);
            this.txtDni.Leave += new System.EventHandler(this.txtDni_Leave);
            // 
            // lblDni
            // 
            this.lblDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDni.AutoSize = true;
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(682, 139);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 20;
            this.lblDni.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(346, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(432, 2);
            this.label4.TabIndex = 25;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtDireccion.ForeColor = System.Drawing.Color.Gray;
            this.txtDireccion.Location = new System.Drawing.Point(346, 346);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(432, 27);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.Text = "Introduce dirección";
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(343, 330);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(113, 13);
            this.lblDireccion.TabIndex = 23;
            this.lblDireccion.Text = "Introduce tu dirección:";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistro.Location = new System.Drawing.Point(345, 404);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(432, 28);
            this.btnRegistro.TabIndex = 6;
            this.btnRegistro.Text = "Regístrate";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1109, 596);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBoxContinueGoogle);
            this.Controls.Add(this.btnContinueWGoogle);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLinePassword);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblWelcomeLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1125, 635);
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRegister_FormClosed);
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContinueGoogle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeLogin;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblLinePassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnContinueWGoogle;
        private System.Windows.Forms.PictureBox pictureBoxContinueGoogle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnRegistro;
    }
}