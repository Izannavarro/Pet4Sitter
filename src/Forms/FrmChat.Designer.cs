using pet4sitter.Clases;

namespace pet4sitter
{
    partial class FrmChat
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lblIdChat2 = new System.Windows.Forms.Label();
            this.lblIdChat1 = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.pcbImagen1 = new System.Windows.Forms.PictureBox();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.pcbImagen2 = new System.Windows.Forms.PictureBox();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.lblIdChat3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre3 = new System.Windows.Forms.Label();
            this.pcbImagen3 = new System.Windows.Forms.PictureBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.lblIdChat4 = new System.Windows.Forms.Label();
            this.lblNombre4 = new System.Windows.Forms.Label();
            this.pcbImagen4 = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.btnOpciones = new System.Windows.Forms.Button();
            this.lblNombreChatActivo = new System.Windows.Forms.Label();
            this.pcbImagen5 = new System.Windows.Forms.PictureBox();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.fLPanelChat = new pet4sitter.Clases.BufferedFlowLayoutPanel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.barraLateral1 = new pet4sitter.BarraLateral();
            this.btnIdioma = new System.Windows.Forms.Button();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.barraLateral1 = new pet4sitter.BarraLateral();
            this.panel3.SuspendLayout();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen1)).BeginInit();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen2)).BeginInit();
            this.pnl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen3)).BeginInit();
            this.pnl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen4)).BeginInit();
            this.pnl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen5)).BeginInit();
            this.pnl6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(98)))));
            this.panel3.Controls.Add(this.pnl1);
            this.panel3.Controls.Add(this.pnl2);
            this.panel3.Controls.Add(this.pnl3);
            this.panel3.Controls.Add(this.btnSiguiente);
            this.panel3.Controls.Add(this.pnl4);
            this.panel3.Controls.Add(this.btnAnterior);
            this.panel3.Location = new System.Drawing.Point(191, 26);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 630);
            this.panel3.TabIndex = 4;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.White;
            this.pnl1.Controls.Add(this.lblIdChat2);
            this.pnl1.Controls.Add(this.lblIdChat1);
            this.pnl1.Controls.Add(this.lblNombre1);
            this.pnl1.Controls.Add(this.pcbImagen1);
            this.pnl1.Location = new System.Drawing.Point(19, 17);
            this.pnl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(256, 127);
            this.pnl1.TabIndex = 12;
            this.pnl1.Click += new System.EventHandler(this.pnl1_Click);
            this.pnl1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl1_Paint);
            this.pnl1.MouseLeave += new System.EventHandler(this.pnl1_MouseLeave);
            this.pnl1.MouseHover += new System.EventHandler(this.pnl1_MouseHover);
            // 
            // lblIdChat2
            // 
            this.lblIdChat2.AutoSize = true;
            this.lblIdChat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdChat2.Location = new System.Drawing.Point(128, 214);
            this.lblIdChat2.Name = "lblIdChat2";
            this.lblIdChat2.Size = new System.Drawing.Size(0, 22);
            this.lblIdChat2.TabIndex = 11;
            this.lblIdChat2.Visible = false;
            // 
            // lblIdChat1
            // 
            this.lblIdChat1.AutoSize = true;
            this.lblIdChat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdChat1.Location = new System.Drawing.Point(120, 69);
            this.lblIdChat1.Name = "lblIdChat1";
            this.lblIdChat1.Size = new System.Drawing.Size(0, 22);
            this.lblIdChat1.TabIndex = 10;
            this.lblIdChat1.Visible = false;
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre1.Location = new System.Drawing.Point(121, 34);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(61, 22);
            this.lblNombre1.TabIndex = 9;
            this.lblNombre1.Text = "Name";
            // 
            // pcbImagen1
            // 
            this.pcbImagen1.BackColor = System.Drawing.Color.Gainsboro;
            this.pcbImagen1.Location = new System.Drawing.Point(15, 25);
            this.pcbImagen1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbImagen1.Name = "pcbImagen1";
            this.pcbImagen1.Size = new System.Drawing.Size(77, 76);
            this.pcbImagen1.TabIndex = 6;
            this.pcbImagen1.TabStop = false;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.White;
            this.pnl2.Controls.Add(this.lblNombre2);
            this.pnl2.Controls.Add(this.pcbImagen2);
            this.pnl2.Location = new System.Drawing.Point(16, 159);
            this.pnl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(259, 127);
            this.pnl2.TabIndex = 11;
            this.pnl2.Click += new System.EventHandler(this.pnl2_Click);
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre2.Location = new System.Drawing.Point(123, 37);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(61, 22);
            this.lblNombre2.TabIndex = 9;
            this.lblNombre2.Text = "Name";
            // 
            // pcbImagen2
            // 
            this.pcbImagen2.BackColor = System.Drawing.Color.Gainsboro;
            this.pcbImagen2.Location = new System.Drawing.Point(17, 25);
            this.pcbImagen2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbImagen2.Name = "pcbImagen2";
            this.pcbImagen2.Size = new System.Drawing.Size(77, 76);
            this.pcbImagen2.TabIndex = 5;
            this.pcbImagen2.TabStop = false;
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.White;
            this.pnl3.Controls.Add(this.lblIdChat3);
            this.pnl3.Controls.Add(this.label1);
            this.pnl3.Controls.Add(this.lblNombre3);
            this.pnl3.Controls.Add(this.pcbImagen3);
            this.pnl3.Location = new System.Drawing.Point(16, 302);
            this.pnl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(259, 127);
            this.pnl3.TabIndex = 10;
            this.pnl3.Click += new System.EventHandler(this.pnl3_Click);
            // 
            // lblIdChat3
            // 
            this.lblIdChat3.AutoSize = true;
            this.lblIdChat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdChat3.Location = new System.Drawing.Point(131, 79);
            this.lblIdChat3.Name = "lblIdChat3";
            this.lblIdChat3.Size = new System.Drawing.Size(0, 22);
            this.lblIdChat3.TabIndex = 12;
            this.lblIdChat3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 12;
            this.label1.Visible = false;
            // 
            // lblNombre3
            // 
            this.lblNombre3.AutoSize = true;
            this.lblNombre3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre3.Location = new System.Drawing.Point(123, 38);
            this.lblNombre3.Name = "lblNombre3";
            this.lblNombre3.Size = new System.Drawing.Size(61, 22);
            this.lblNombre3.TabIndex = 9;
            this.lblNombre3.Text = "Name";
            // 
            // pcbImagen3
            // 
            this.pcbImagen3.BackColor = System.Drawing.Color.Gainsboro;
            this.pcbImagen3.Location = new System.Drawing.Point(17, 25);
            this.pcbImagen3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbImagen3.Name = "pcbImagen3";
            this.pcbImagen3.Size = new System.Drawing.Size(77, 76);
            this.pcbImagen3.TabIndex = 5;
            this.pcbImagen3.TabStop = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(141, 587);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(92, 31);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // pnl4
            // 
            this.pnl4.BackColor = System.Drawing.Color.White;
            this.pnl4.Controls.Add(this.lblIdChat4);
            this.pnl4.Controls.Add(this.lblNombre4);
            this.pnl4.Controls.Add(this.pcbImagen4);
            this.pnl4.Location = new System.Drawing.Point(16, 446);
            this.pnl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(259, 127);
            this.pnl4.TabIndex = 9;
            this.pnl4.Click += new System.EventHandler(this.pnl4_Click);
            // 
            // lblIdChat4
            // 
            this.lblIdChat4.AutoSize = true;
            this.lblIdChat4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdChat4.Location = new System.Drawing.Point(131, 79);
            this.lblIdChat4.Name = "lblIdChat4";
            this.lblIdChat4.Size = new System.Drawing.Size(0, 22);
            this.lblIdChat4.TabIndex = 13;
            this.lblIdChat4.Visible = false;
            // 
            // lblNombre4
            // 
            this.lblNombre4.AutoSize = true;
            this.lblNombre4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre4.Location = new System.Drawing.Point(123, 36);
            this.lblNombre4.Name = "lblNombre4";
            this.lblNombre4.Size = new System.Drawing.Size(61, 22);
            this.lblNombre4.TabIndex = 9;
            this.lblNombre4.Text = "Name";
            // 
            // pcbImagen4
            // 
            this.pcbImagen4.BackColor = System.Drawing.Color.Gainsboro;
            this.pcbImagen4.Location = new System.Drawing.Point(17, 25);
            this.pcbImagen4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbImagen4.Name = "pcbImagen4";
            this.pcbImagen4.Size = new System.Drawing.Size(77, 76);
            this.pcbImagen4.TabIndex = 5;
            this.pcbImagen4.TabStop = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(59, 587);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(77, 31);
            this.btnAnterior.TabIndex = 6;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // pnl5
            // 
            this.pnl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(98)))));
            this.pnl5.Controls.Add(this.btnOpciones);
            this.pnl5.Controls.Add(this.lblNombreChatActivo);
            this.pnl5.Controls.Add(this.pcbImagen5);
            this.pnl5.Location = new System.Drawing.Point(508, 26);
            this.pnl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(728, 108);
            this.pnl5.TabIndex = 5;
            // 
            // btnOpciones
            // 
            this.btnOpciones.Location = new System.Drawing.Point(599, 25);
            this.btnOpciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(92, 60);
            this.btnOpciones.TabIndex = 14;
            this.btnOpciones.Text = "opciones";
            this.btnOpciones.UseVisualStyleBackColor = true;
            // 
            // lblNombreChatActivo
            // 
            this.lblNombreChatActivo.AutoSize = true;
            this.lblNombreChatActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreChatActivo.Location = new System.Drawing.Point(117, 41);
            this.lblNombreChatActivo.Name = "lblNombreChatActivo";
            this.lblNombreChatActivo.Size = new System.Drawing.Size(61, 22);
            this.lblNombreChatActivo.TabIndex = 8;
            this.lblNombreChatActivo.Text = "Name";
            // 
            // pcbImagen5
            // 
            this.pcbImagen5.BackColor = System.Drawing.Color.Gainsboro;
            this.pcbImagen5.Location = new System.Drawing.Point(20, 17);
            this.pcbImagen5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbImagen5.Name = "pcbImagen5";
            this.pcbImagen5.Size = new System.Drawing.Size(77, 76);
            this.pcbImagen5.TabIndex = 5;
            this.pcbImagen5.TabStop = false;
            // 
            // pnl6
            // 
            this.pnl6.BackColor = System.Drawing.Color.White;
            this.pnl6.Controls.Add(this.fLPanelChat);
            this.pnl6.Controls.Add(this.btnEnviar);
            this.pnl6.Controls.Add(this.txtMensaje);
            this.pnl6.Location = new System.Drawing.Point(508, 127);
            this.pnl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(728, 530);
            this.pnl6.TabIndex = 13;
            // 
            // fLPanelChat
            // 
            this.fLPanelChat.AutoScroll = true;
            this.fLPanelChat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.fLPanelChat.Location = new System.Drawing.Point(4, 14);
            this.fLPanelChat.Margin = new System.Windows.Forms.Padding(4);
            this.fLPanelChat.Name = "fLPanelChat";
            this.fLPanelChat.Size = new System.Drawing.Size(720, 432);
            this.fLPanelChat.TabIndex = 14;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(624, 462);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(77, 46);
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(31, 462);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(577, 45);
            this.txtMensaje.TabIndex = 0;
            // 
            // btnIdioma
            // 
            this.btnIdioma.Location = new System.Drawing.Point(1285, 185);
            this.btnIdioma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIdioma.Name = "btnIdioma";
            this.btnIdioma.Size = new System.Drawing.Size(116, 76);
            this.btnIdioma.TabIndex = 14;
            this.btnIdioma.Text = "button1";
            this.btnIdioma.UseVisualStyleBackColor = true;
            this.btnIdioma.Click += new System.EventHandler(this.btnIdioma_Click);
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // barraLateral1
            // 
            this.barraLateral1.BackColor = System.Drawing.Color.Transparent;
            this.barraLateral1.Location = new System.Drawing.Point(-4, 0);
            this.barraLateral1.Margin = new System.Windows.Forms.Padding(5);
            this.barraLateral1.Name = "barraLateral1";
            this.barraLateral1.Size = new System.Drawing.Size(415, 737);
            this.barraLateral1.TabIndex = 15;
            // 
            // FrmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1479, 734);
            this.Controls.Add(this.pnl5);
            this.Controls.Add(this.pnl6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.barraLateral1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmChat_FormClosed);
            this.Load += new System.EventHandler(this.FrmChat_Load);
            this.panel3.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen1)).EndInit();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen2)).EndInit();
            this.pnl3.ResumeLayout(false);
            this.pnl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen3)).EndInit();
            this.pnl4.ResumeLayout(false);
            this.pnl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen4)).EndInit();
            this.pnl5.ResumeLayout(false);
            this.pnl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen5)).EndInit();
            this.pnl6.ResumeLayout(false);
            this.pnl6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.PictureBox pcbImagen4;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.PictureBox pcbImagen1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.PictureBox pcbImagen2;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Label lblNombre3;
        private System.Windows.Forms.PictureBox pcbImagen3;
        private System.Windows.Forms.Label lblNombre4;
        private System.Windows.Forms.Label lblNombreChatActivo;
        private System.Windows.Forms.PictureBox pcbImagen5;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnOpciones;
        private BarraLateral barraLateral1;
        private System.Windows.Forms.Timer tmr;
        private BufferedFlowLayoutPanel fLPanelChat;
        private System.Windows.Forms.Label lblIdChat2;
        private System.Windows.Forms.Label lblIdChat1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdChat4;
        private System.Windows.Forms.Label lblIdChat3;
    }
}