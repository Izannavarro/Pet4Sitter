
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIAyuda));
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
            this.barraLateral1 = new pet4sitter.BarraLateral(this);
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
            this.lblTitlepet4sitter.Location = new System.Drawing.Point(562, 92);
            this.lblTitlepet4sitter.Name = "lblTitlepet4sitter";
            this.lblTitlepet4sitter.Size = new System.Drawing.Size(111, 25);
            this.lblTitlepet4sitter.TabIndex = 3;
            this.lblTitlepet4sitter.Text = "pet4sitter";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(88, 274);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(543, 13);
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
            this.panel1.Location = new System.Drawing.Point(229, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 326);
            this.panel1.TabIndex = 5;
            // 
            // pcbLoading
            // 
            this.pcbLoading.BackColor = System.Drawing.Color.Transparent;
            this.pcbLoading.Image = global::pet4sitter.Properties.Resources.loading;
            this.pcbLoading.Location = new System.Drawing.Point(353, 118);
            this.pcbLoading.Name = "pcbLoading";
            this.pcbLoading.Size = new System.Drawing.Size(53, 49);
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
            this.lblErrorWifi.Location = new System.Drawing.Point(184, 242);
            this.lblErrorWifi.Name = "lblErrorWifi";
            this.lblErrorWifi.Size = new System.Drawing.Size(404, 18);
            this.lblErrorWifi.TabIndex = 15;
            this.lblErrorWifi.Text = "No tienes conexión a internet, revísalo o inténtalo más tarde.";
            this.lblErrorWifi.Visible = false;
            this.lblErrorWifi.Click += new System.EventHandler(this.lblErrorWifi_Click);
            // 
            // pcbNoWifi
            // 
            this.pcbNoWifi.Image = global::pet4sitter.Properties.Resources.no_wifi_red;
            this.pcbNoWifi.Location = new System.Drawing.Point(260, -11);
            this.pcbNoWifi.Name = "pcbNoWifi";
            this.pcbNoWifi.Size = new System.Drawing.Size(245, 242);
            this.pcbNoWifi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbNoWifi.TabIndex = 14;
            this.pcbNoWifi.TabStop = false;
            this.pcbNoWifi.Visible = false;
            // 
            // lblIA
            // 
            this.lblIA.AutoSize = true;
            this.lblIA.Location = new System.Drawing.Point(43, 150);
            this.lblIA.Name = "lblIA";
            this.lblIA.Size = new System.Drawing.Size(20, 13);
            this.lblIA.TabIndex = 13;
            this.lblIA.Text = "IA:";
            // 
            // pcbAI
            // 
            this.pcbAI.Image = global::pet4sitter.Properties.Resources.roboy;
            this.pcbAI.Location = new System.Drawing.Point(7, 139);
            this.pcbAI.Name = "pcbAI";
            this.pcbAI.Size = new System.Drawing.Size(34, 28);
            this.pcbAI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAI.TabIndex = 12;
            this.pcbAI.TabStop = false;
            // 
            // lblYou
            // 
            this.lblYou.AutoSize = true;
            this.lblYou.Location = new System.Drawing.Point(43, 44);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(23, 13);
            this.lblYou.TabIndex = 10;
            this.lblYou.Text = "Tu:";
            // 
            // pcbUser
            // 
            this.pcbUser.Image = global::pet4sitter.Properties.Resources.piTestLogo;
            this.pcbUser.Location = new System.Drawing.Point(3, 28);
            this.pcbUser.Name = "pcbUser";
            this.pcbUser.Size = new System.Drawing.Size(51, 46);
            this.pcbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUser.TabIndex = 11;
            this.pcbUser.TabStop = false;
            // 
            // lblAnswer
            // 
            this.lblAnswer.Location = new System.Drawing.Point(72, 150);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(649, 92);
            this.lblAnswer.TabIndex = 9;
            this.lblAnswer.Text = "test";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuestion.Location = new System.Drawing.Point(72, 44);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(649, 92);
            this.lblQuestion.TabIndex = 8;
            this.lblQuestion.Text = "test";
            // 
            // linklabFAQ
            // 
            this.linklabFAQ.AutoSize = true;
            this.linklabFAQ.Location = new System.Drawing.Point(616, 274);
            this.linklabFAQ.Name = "linklabFAQ";
            this.linklabFAQ.Size = new System.Drawing.Size(28, 13);
            this.linklabFAQ.TabIndex = 7;
            this.linklabFAQ.TabStop = true;
            this.linklabFAQ.Text = "FAQ";
            this.linklabFAQ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabFAQ_LinkClicked);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(594, 290);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(141, 33);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_ClickAsync);
            // 
            // txtPrompt
            // 
            this.txtPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.txtPrompt.Location = new System.Drawing.Point(3, 290);
            this.txtPrompt.Multiline = true;
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(585, 33);
            this.txtPrompt.TabIndex = 5;
            // 
            // cmbPrompts
            // 
            this.cmbPrompts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPrompts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrompts.FormattingEnabled = true;
            this.cmbPrompts.Location = new System.Drawing.Point(229, 133);
            this.cmbPrompts.Name = "cmbPrompts";
            this.cmbPrompts.Size = new System.Drawing.Size(738, 21);
            this.cmbPrompts.TabIndex = 14;
            this.cmbPrompts.SelectedIndexChanged += new System.EventHandler(this.cmbPrompts_SelectedIndexChanged);
            // 
            // barraLateral1
            // 
            this.barraLateral1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barraLateral1.BackColor = System.Drawing.Color.Transparent;
            this.barraLateral1.Location = new System.Drawing.Point(1, -2);
            this.barraLateral1.Margin = new System.Windows.Forms.Padding(4);
            this.barraLateral1.Name = "barraLateral1";
            this.barraLateral1.Size = new System.Drawing.Size(311, 599);
            this.barraLateral1.TabIndex = 16;
            this.barraLateral1.Load += new System.EventHandler(this.barraLateral1_Load);
            // 
            // FrmIAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1109, 596);
            this.Controls.Add(this.cmbPrompts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitlepet4sitter);
            this.Controls.Add(this.barraLateral1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1125, 635);
            this.Name = "FrmIAyuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet4sitter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIAyuda_FormClosed);
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

