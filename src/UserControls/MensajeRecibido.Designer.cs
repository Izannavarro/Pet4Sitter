namespace pet4sitter.Forms
{
    partial class MensajeRecibido
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMensajeRecibido = new System.Windows.Forms.Label();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensajeRecibido
            // 
            this.lblMensajeRecibido.AutoEllipsis = true;
            this.lblMensajeRecibido.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblMensajeRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeRecibido.Location = new System.Drawing.Point(59, 0);
            this.lblMensajeRecibido.Name = "lblMensajeRecibido";
            this.lblMensajeRecibido.Size = new System.Drawing.Size(346, 62);
            this.lblMensajeRecibido.TabIndex = 0;
            this.lblMensajeRecibido.Text = "label1";
            // 
            // pcbIcon
            // 
            this.pcbIcon.Image = global::pet4sitter.Properties.Resources.google_icon;
            this.pcbIcon.Location = new System.Drawing.Point(8, 0);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(45, 40);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIcon.TabIndex = 1;
            this.pcbIcon.TabStop = false;
            // 
            // MensajeRecibido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.pcbIcon);
            this.Controls.Add(this.lblMensajeRecibido);
            this.Name = "MensajeRecibido";
            this.Size = new System.Drawing.Size(405, 62);
            this.Load += new System.EventHandler(this.MensajeRecibido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblMensajeRecibido;
        private System.Windows.Forms.PictureBox pcbIcon;
    }
}
