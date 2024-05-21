
namespace pet4sitter
{
    partial class FrmIAyuda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitlepet4sitter = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbLoading = new System.Windows.Forms.PictureBox();
            this.lblErrorWifi = new System.Windows.Forms.Label();
            this.pcbNoWifi = new System.Windows.Forms.PictureBox();
            this.lblIA = new System.Windows.Forms.Label();
            this.pcbAI = new System.Windows.Forms.PictureBox();
            this.lblYou = new System.Windows.Forms.Label();
            this.pcbUser = new System.Windows.Forms.PictureBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.linklabFAQ = new System.Windows.Forms.LinkLabel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtPrompt = new System.Windows.Forms.TextBox();
            this.cmbPrompts = new System.Windows.Forms.ComboBox();
            this.barraLateral1 = new pet4sitter.BarraLateral();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNoWifi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlepet4sitter
            // 
            this.lblTitlepet4sitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitlepet4sitter.AutoSize = true;
            this.lblTitlepet4sitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.4F, System.Drawing.FontStyle.Bold);
            this.lblTitlepet4sitter.Location = new System.Drawing.Point(631, 116);
            this.lblTitlepet4sitter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitlepet4sitter.Name = "lblTitlepet4sitter";
            this.lblTitlepet4sitter.Size = new System.Drawing.Size(128, 30);
            this.lblTitlepet4sitter.TabIndex = 3;
            this.lblTitlepet4sitter.Text = "pet4sitter";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(117, 337);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(683, 16);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "pet4sitter es un apartado de ayuda con IA y puede cometer errores, si quiere más " +
    "informacion puede ver nuestras ";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.pcbLoading);
            this.panel1.Controls.Add(this.lblErrorWifi);
            this.panel1.Controls.Add(this.pcbNoWifi);
            this.panel1.Controls.Add(this.lblIA);
            this.panel1.Controls.Add(this.pcbAI);
            this.panel1.Controls.Add(this.lblYou);
            this.panel1.Controls.Add(this.pcbUser);
            this.panel1.Controls.Add(this.lblAnswer);
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Controls.Add(this.linklabFAQ);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.txtPrompt);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Location = new System.Drawing.Point(187, 194);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 401);
            this.panel1.TabIndex = 5;
            // 
            // pcbLoading
            // 
            this.pcbLoading.BackColor = System.Drawing.Color.Transparent;
            this.pcbLoading.Image = global::pet4sitter.Properties.Resources.loading;
            this.pcbLoading.Location = new System.Drawing.Point(471, 145);
            this.pcbLoading.Margin = new System.Windows.Forms.Padding(4);
            this.pcbLoading.Name = "pcbLoading";
            this.pcbLoading.Size = new System.Drawing.Size(71, 60);
            this.pcbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLoading.TabIndex = 16;
            this.pcbLoading.TabStop = false;
            this.pcbLoading.Visible = false;
            // 
            // lblErrorWifi
            // 
            this.lblErrorWifi.AutoSize = true;
            this.lblErrorWifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblErrorWifi.ForeColor = System.Drawing.Color.Red;
            this.lblErrorWifi.Location = new System.Drawing.Point(245, 298);
            this.lblErrorWifi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorWifi.Name = "lblErrorWifi";
            this.lblErrorWifi.Size = new System.Drawing.Size(513, 24);
            this.lblErrorWifi.TabIndex = 15;
            this.lblErrorWifi.Text = "No tienes conexión a internet, revísalo o inténtalo más tarde.";
            this.lblErrorWifi.Visible = false;
            this.lblErrorWifi.Click += new System.EventHandler(this.lblErrorWifi_Click);
            // 
            // pcbNoWifi
            // 
            this.pcbNoWifi.Image = global::pet4sitter.Properties.Resources.no_wifi_red;
            this.pcbNoWifi.Location = new System.Drawing.Point(347, -13);
            this.pcbNoWifi.Margin = new System.Windows.Forms.Padding(4);
            this.pcbNoWifi.Name = "pcbNoWifi";
            this.pcbNoWifi.Size = new System.Drawing.Size(327, 298);
            this.pcbNoWifi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbNoWifi.TabIndex = 14;
            this.pcbNoWifi.TabStop = false;
            this.pcbNoWifi.Visible = false;
            // 
            // lblIA
            // 
            this.lblIA.AutoSize = true;
            this.lblIA.Location = new System.Drawing.Point(57, 185);
            this.lblIA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIA.Name = "lblIA";
            this.lblIA.Size = new System.Drawing.Size(22, 16);
            this.lblIA.TabIndex = 13;
            this.lblIA.Text = "IA:";
            // 
            // pcbAI
            // 
            this.pcbAI.Image = global::pet4sitter.Properties.Resources.roboy;
            this.pcbAI.Location = new System.Drawing.Point(9, 171);
            this.pcbAI.Margin = new System.Windows.Forms.Padding(4);
            this.pcbAI.Name = "pcbAI";
            this.pcbAI.Size = new System.Drawing.Size(45, 34);
            this.pcbAI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAI.TabIndex = 12;
            this.pcbAI.TabStop = false;
            // 
            // lblYou
            // 
            this.lblYou.AutoSize = true;
            this.lblYou.Location = new System.Drawing.Point(57, 54);
            this.lblYou.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(26, 16);
            this.lblYou.TabIndex = 10;
            this.lblYou.Text = "Tu:";
            // 
            // pcbUser
            // 
            this.pcbUser.Image = global::pet4sitter.Properties.Resources.piTestLogo;
            this.pcbUser.Location = new System.Drawing.Point(4, 34);
            this.pcbUser.Margin = new System.Windows.Forms.Padding(4);
            this.pcbUser.Name = "pcbUser";
            this.pcbUser.Size = new System.Drawing.Size(68, 57);
            this.pcbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUser.TabIndex = 11;
            this.pcbUser.TabStop = false;
            // 
            // lblAnswer
            // 
            this.lblAnswer.Location = new System.Drawing.Point(96, 185);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(865, 113);
            this.lblAnswer.TabIndex = 9;
            this.lblAnswer.Text = "test";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuestion.Location = new System.Drawing.Point(96, 54);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(865, 113);
            this.lblQuestion.TabIndex = 8;
            this.lblQuestion.Text = "test";
            // 
            // linklabFAQ
            // 
            this.linklabFAQ.AutoSize = true;
            this.linklabFAQ.Location = new System.Drawing.Point(821, 337);
            this.linklabFAQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklabFAQ.Name = "linklabFAQ";
            this.linklabFAQ.Size = new System.Drawing.Size(34, 16);
            this.linklabFAQ.TabIndex = 7;
            this.linklabFAQ.TabStop = true;
            this.linklabFAQ.Text = "FAQ";
            this.linklabFAQ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabFAQ_LinkClicked);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(792, 357);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(188, 41);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_ClickAsync);
            // 
            // txtPrompt
            // 
            this.txtPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.txtPrompt.Location = new System.Drawing.Point(4, 357);
            this.txtPrompt.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrompt.Multiline = true;
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(779, 40);
            this.txtPrompt.TabIndex = 5;
            // 
            // cmbPrompts
            // 
            this.cmbPrompts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPrompts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrompts.FormattingEnabled = true;
            this.cmbPrompts.Location = new System.Drawing.Point(187, 166);
            this.cmbPrompts.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPrompts.Name = "cmbPrompts";
            this.cmbPrompts.Size = new System.Drawing.Size(983, 24);
            this.cmbPrompts.TabIndex = 14;
            this.cmbPrompts.SelectedIndexChanged += new System.EventHandler(this.cmbPrompts_SelectedIndexChanged);
            // 
            // barraLateral1
            // 
            this.barraLateral1.BackColor = System.Drawing.Color.Transparent;
            this.barraLateral1.Location = new System.Drawing.Point(-7, -3);
            this.barraLateral1.Margin = new System.Windows.Forms.Padding(5);
            this.barraLateral1.Name = "barraLateral1";
            this.barraLateral1.Size = new System.Drawing.Size(415, 737);
            this.barraLateral1.TabIndex = 16;
            this.barraLateral1.Load += new System.EventHandler(this.barraLateral1_Load);
            // 
            // FrmIAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1241, 738);
            this.Controls.Add(this.barraLateral1);
            this.Controls.Add(this.cmbPrompts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitlepet4sitter);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1257, 579);
            this.Name = "FrmIAyuda";
            this.Text = "Pet4sitter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNoWifi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitlepet4sitter;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.LinkLabel linklabFAQ;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblYou;
        private System.Windows.Forms.Label lblIA;
        private System.Windows.Forms.PictureBox pcbAI;
        private System.Windows.Forms.PictureBox pcbUser;
        private System.Windows.Forms.ComboBox cmbPrompts;
        private System.Windows.Forms.PictureBox pcbNoWifi;
        private System.Windows.Forms.Label lblErrorWifi;
        private System.Windows.Forms.PictureBox pcbLoading;
        private BarraLateral barraLateral1;
    }
}

