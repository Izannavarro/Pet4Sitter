namespace pet4sitter
{
    partial class MensajeEnviado
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMensajeEnviado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensajeEnviado
            // 
            this.lblMensajeEnviado.BackColor = System.Drawing.Color.SpringGreen;
            this.lblMensajeEnviado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeEnviado.Location = new System.Drawing.Point(72, 0);
            this.lblMensajeEnviado.Name = "lblMensajeEnviado";
            this.lblMensajeEnviado.Size = new System.Drawing.Size(465, 65);
            this.lblMensajeEnviado.TabIndex = 0;
            this.lblMensajeEnviado.Text = "label1";
            this.lblMensajeEnviado.Click += new System.EventHandler(this.lblMensajeEnviado_Click);
            // 
            // MensajeEnviado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.lblMensajeEnviado);
            this.Name = "MensajeEnviado";
            this.Size = new System.Drawing.Size(538, 65);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMensajeEnviado;
    }
}
