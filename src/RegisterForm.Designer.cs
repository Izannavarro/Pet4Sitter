using System.Drawing;

namespace piTest
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.lblWelcomeLogin = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblLinePassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnContinueWGoogle = new System.Windows.Forms.Button();
            this.pictureBoxContinueGoogle = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContinueGoogle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeLogin
            // 
            this.lblWelcomeLogin.AutoSize = true;
            this.lblWelcomeLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.lblWelcomeLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 25.25F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeLogin.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeLogin.Location = new System.Drawing.Point(559, 22);
            this.lblWelcomeLogin.Margin = new System.Windows.Forms.Padding(0);
            this.lblWelcomeLogin.Name = "lblWelcomeLogin";
            this.lblWelcomeLogin.Size = new System.Drawing.Size(230, 55);
            this.lblWelcomeLogin.TabIndex = 0;
            this.lblWelcomeLogin.Text = "Regístrate";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(407, 90);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(114, 16);
            this.lblMail.TabIndex = 1;
            this.lblMail.Text = "Introduce tu email:";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtMail.ForeColor = System.Drawing.Color.Gray;
            this.txtMail.Location = new System.Drawing.Point(411, 110);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(576, 33);
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
            this.txtPass.ForeColor = System.Drawing.Color.Gray;
            this.txtPass.Location = new System.Drawing.Point(411, 194);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(576, 33);
            this.txtPass.TabIndex = 4;
            this.txtPass.Text = "Introduce contraseña";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(407, 175);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(148, 16);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Introduce tu contraseña:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBoxOutput);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 412);
            this.panel1.TabIndex = 5;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(36, 289);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(297, 104);
            this.textBoxOutput.TabIndex = 1;
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.Color.Gray;
            this.lblLine.Location = new System.Drawing.Point(411, 134);
            this.lblLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(576, 2);
            this.lblLine.TabIndex = 6;
            // 
            // lblLinePassword
            // 
            this.lblLinePassword.BackColor = System.Drawing.Color.Gray;
            this.lblLinePassword.Location = new System.Drawing.Point(411, 219);
            this.lblLinePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLinePassword.Name = "lblLinePassword";
            this.lblLinePassword.Size = new System.Drawing.Size(576, 2);
            this.lblLinePassword.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(411, 302);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(576, 34);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Volver a Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnContinueWGoogle
            // 
            this.btnContinueWGoogle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinueWGoogle.Location = new System.Drawing.Point(411, 343);
            this.btnContinueWGoogle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContinueWGoogle.Name = "btnContinueWGoogle";
            this.btnContinueWGoogle.Size = new System.Drawing.Size(576, 34);
            this.btnContinueWGoogle.TabIndex = 11;
            this.btnContinueWGoogle.Text = "Regístrate con google";
            this.btnContinueWGoogle.UseVisualStyleBackColor = true;
            this.btnContinueWGoogle.Click += new System.EventHandler(this.btnIniciarSesionGoogle_Click);
            this.btnContinueWGoogle.Leave += new System.EventHandler(this.btnContinueWGoogle_Leave);
            this.btnContinueWGoogle.MouseLeave += new System.EventHandler(this.btnContinueWGoogle_Leave);
            this.btnContinueWGoogle.MouseHover += new System.EventHandler(this.btnContinueWGoogle_MouseHover);
            // 
            // pictureBoxContinueGoogle
            // 
            this.pictureBoxContinueGoogle.BackColor = System.Drawing.Color.White;
            this.pictureBoxContinueGoogle.Image = global::piTest.Properties.Resources.google_icon_icons_com_62736;
            this.pictureBoxContinueGoogle.Location = new System.Drawing.Point(593, 347);
            this.pictureBoxContinueGoogle.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxContinueGoogle.Name = "pictureBoxContinueGoogle";
            this.pictureBoxContinueGoogle.Size = new System.Drawing.Size(31, 28);
            this.pictureBoxContinueGoogle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxContinueGoogle.TabIndex = 12;
            this.pictureBoxContinueGoogle.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::piTest.Properties.Resources.google_icon;
            this.pictureBox1.Location = new System.Drawing.Point(85, 112);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1040, 406);
            this.Controls.Add(this.pictureBoxContinueGoogle);
            this.Controls.Add(this.btnContinueWGoogle);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContinueGoogle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnContinueWGoogle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxContinueGoogle;
        private System.Windows.Forms.TextBox textBoxOutput;
    }
}