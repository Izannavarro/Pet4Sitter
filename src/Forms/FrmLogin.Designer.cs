using System.Drawing;

namespace pet4sitter
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblWelcomeLogin = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblLinePassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblForgPass = new System.Windows.Forms.Label();
            this.btnContinueWGoogle = new System.Windows.Forms.Button();
            this.lblReportarBug = new System.Windows.Forms.Label();
            this.pictureBoxContinueGoogle = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContinueGoogle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeLogin
            // 
            this.lblWelcomeLogin.AutoSize = true;
            this.lblWelcomeLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 25.25F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeLogin.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeLogin.Location = new System.Drawing.Point(419, 18);
            this.lblWelcomeLogin.Margin = new System.Windows.Forms.Padding(0);
            this.lblWelcomeLogin.Name = "lblWelcomeLogin";
            this.lblWelcomeLogin.Size = new System.Drawing.Size(228, 44);
            this.lblWelcomeLogin.TabIndex = 0;
            this.lblWelcomeLogin.Text = "Iniciar sesión";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(305, 73);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(94, 13);
            this.lblMail.TabIndex = 1;
            this.lblMail.Text = "Introduce tu email:";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(170)))), ((int)(((byte)(110)))));
            this.txtMail.Location = new System.Drawing.Point(308, 89);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(432, 27);
            this.txtMail.TabIndex = 2;
            this.txtMail.Text = "Introduce email";
            this.txtMail.Enter += new System.EventHandler(this.txtMail_Enter);
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(170)))), ((int)(((byte)(110)))));
            this.txtPass.Location = new System.Drawing.Point(308, 158);
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
            this.lblPass.AutoSize = true;
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(305, 142);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(123, 13);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Introduce tu contraseña:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 335);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pet4sitter.Properties.Resources.pet4sitterLogo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.Color.White;
            this.lblLine.Location = new System.Drawing.Point(308, 109);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(432, 2);
            this.lblLine.TabIndex = 6;
            // 
            // lblLinePassword
            // 
            this.lblLinePassword.BackColor = System.Drawing.Color.White;
            this.lblLinePassword.ForeColor = System.Drawing.Color.White;
            this.lblLinePassword.Location = new System.Drawing.Point(308, 178);
            this.lblLinePassword.Name = "lblLinePassword";
            this.lblLinePassword.Size = new System.Drawing.Size(432, 2);
            this.lblLinePassword.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(308, 211);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(432, 28);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(308, 245);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(432, 28);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Regístrate";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblForgPass
            // 
            this.lblForgPass.AutoSize = true;
            this.lblForgPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgPass.ForeColor = System.Drawing.Color.White;
            this.lblForgPass.Location = new System.Drawing.Point(305, 188);
            this.lblForgPass.Name = "lblForgPass";
            this.lblForgPass.Size = new System.Drawing.Size(149, 13);
            this.lblForgPass.TabIndex = 2;
            this.lblForgPass.Text = "¿Has olvidado tu contraseña?";
            this.lblForgPass.Click += new System.EventHandler(this.lblForgPass_Click);
            this.lblForgPass.MouseEnter += new System.EventHandler(this.lblForgPass_MouseEnter);
            this.lblForgPass.MouseLeave += new System.EventHandler(this.lblForgPass_MouseLeave);
            // 
            // btnContinueWGoogle
            // 
            this.btnContinueWGoogle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinueWGoogle.Location = new System.Drawing.Point(308, 279);
            this.btnContinueWGoogle.Name = "btnContinueWGoogle";
            this.btnContinueWGoogle.Size = new System.Drawing.Size(432, 28);
            this.btnContinueWGoogle.TabIndex = 11;
            this.btnContinueWGoogle.Text = "Continuar con google";
            this.btnContinueWGoogle.UseVisualStyleBackColor = true;
            this.btnContinueWGoogle.Click += new System.EventHandler(this.btnIniciarSesionGoogle_Click);
            this.btnContinueWGoogle.Leave += new System.EventHandler(this.btnContinueWGoogle_Leave);
            this.btnContinueWGoogle.MouseLeave += new System.EventHandler(this.btnContinueWGoogle_Leave);
            this.btnContinueWGoogle.MouseHover += new System.EventHandler(this.btnContinueWGoogle_MouseHover);
            // 
            // lblReportarBug
            // 
            this.lblReportarBug.AutoSize = true;
            this.lblReportarBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportarBug.ForeColor = System.Drawing.Color.White;
            this.lblReportarBug.Location = new System.Drawing.Point(709, 316);
            this.lblReportarBug.Name = "lblReportarBug";
            this.lblReportarBug.Size = new System.Drawing.Size(70, 13);
            this.lblReportarBug.TabIndex = 13;
            this.lblReportarBug.Text = "Reportar Bug";
            this.lblReportarBug.Click += new System.EventHandler(this.lblReportarBug_Click);
            // 
            // pictureBoxContinueGoogle
            // 
            this.pictureBoxContinueGoogle.BackColor = System.Drawing.Color.White;
            this.pictureBoxContinueGoogle.Image = global::pet4sitter.Properties.Resources.google_icon_icons_com_62736;
            this.pictureBoxContinueGoogle.Location = new System.Drawing.Point(445, 282);
            this.pictureBoxContinueGoogle.Name = "pictureBoxContinueGoogle";
            this.pictureBoxContinueGoogle.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxContinueGoogle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxContinueGoogle.TabIndex = 12;
            this.pictureBoxContinueGoogle.TabStop = false;
            this.pictureBoxContinueGoogle.Click += new System.EventHandler(this.pictureBoxContinueGoogle_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.lblReportarBug);
            this.Controls.Add(this.pictureBoxContinueGoogle);
            this.Controls.Add(this.btnContinueWGoogle);
            this.Controls.Add(this.lblForgPass);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLinePassword);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblWelcomeLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblLinePassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblForgPass;
        private System.Windows.Forms.Button btnContinueWGoogle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxContinueGoogle;
        private System.Windows.Forms.Label lblReportarBug;
    }
}