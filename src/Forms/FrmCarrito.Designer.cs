namespace pet4sitter
{
    partial class FrmCarrito
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolverPago = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRealizar = new System.Windows.Forms.Button();
            this.lblDescripcionTarjeta = new System.Windows.Forms.Label();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.btnEditarPago = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblDescripcionLocalizacion = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblResumen = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblLocalizacion = new System.Windows.Forms.Label();
            this.lblNumTarjeta = new System.Windows.Forms.Label();
            this.fLPanelCarrito = new pet4sitter.Clases.BufferedFlowLayoutPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.fLPanelCarrito.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(98)))));
            this.panel3.Controls.Add(this.fLPanelCarrito);
            this.panel3.Location = new System.Drawing.Point(189, 73);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 539);
            this.panel3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.btnVolverPago);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(888, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 577);
            this.panel1.TabIndex = 10;
            // 
            // btnVolverPago
            // 
            this.btnVolverPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverPago.Location = new System.Drawing.Point(93, 533);
            this.btnVolverPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolverPago.Name = "btnVolverPago";
            this.btnVolverPago.Size = new System.Drawing.Size(189, 32);
            this.btnVolverPago.TabIndex = 52;
            this.btnVolverPago.Text = "Volver";
            this.btnVolverPago.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblNumTarjeta);
            this.panel4.Controls.Add(this.lblLocalizacion);
            this.panel4.Controls.Add(this.btnRealizar);
            this.panel4.Controls.Add(this.lblDescripcionTarjeta);
            this.panel4.Controls.Add(this.lblMetodo);
            this.panel4.Controls.Add(this.btnEditarPago);
            this.panel4.Controls.Add(this.btnEditar);
            this.panel4.Controls.Add(this.lblDescripcionLocalizacion);
            this.panel4.Location = new System.Drawing.Point(24, 27);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(317, 486);
            this.panel4.TabIndex = 45;
            // 
            // btnRealizar
            // 
            this.btnRealizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizar.Location = new System.Drawing.Point(69, 434);
            this.btnRealizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(189, 32);
            this.btnRealizar.TabIndex = 47;
            this.btnRealizar.Text = "Realizar Pedido";
            this.btnRealizar.UseVisualStyleBackColor = true;
            // 
            // lblDescripcionTarjeta
            // 
            this.lblDescripcionTarjeta.AutoSize = true;
            this.lblDescripcionTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionTarjeta.Location = new System.Drawing.Point(28, 274);
            this.lblDescripcionTarjeta.Name = "lblDescripcionTarjeta";
            this.lblDescripcionTarjeta.Size = new System.Drawing.Size(185, 22);
            this.lblDescripcionTarjeta.TabIndex = 51;
            this.lblDescripcionTarjeta.Text = "Descripcion Tarjeta";
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodo.Location = new System.Drawing.Point(28, 171);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(161, 22);
            this.lblMetodo.TabIndex = 50;
            this.lblMetodo.Text = "Metodo de Pago:";
            // 
            // btnEditarPago
            // 
            this.btnEditarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPago.Location = new System.Drawing.Point(211, 206);
            this.btnEditarPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarPago.Name = "btnEditarPago";
            this.btnEditarPago.Size = new System.Drawing.Size(91, 32);
            this.btnEditarPago.TabIndex = 49;
            this.btnEditarPago.Text = "Editar";
            this.btnEditarPago.UseVisualStyleBackColor = true;
            this.btnEditarPago.Click += new System.EventHandler(this.btnEditarPago_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(166, 123);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(136, 32);
            this.btnEditar.TabIndex = 48;
            this.btnEditar.Text = "Editar Direccion";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblDescripcionLocalizacion
            // 
            this.lblDescripcionLocalizacion.AutoSize = true;
            this.lblDescripcionLocalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionLocalizacion.Location = new System.Drawing.Point(19, 33);
            this.lblDescripcionLocalizacion.Name = "lblDescripcionLocalizacion";
            this.lblDescripcionLocalizacion.Size = new System.Drawing.Size(231, 22);
            this.lblDescripcionLocalizacion.TabIndex = 9;
            this.lblDescripcionLocalizacion.Text = "Descripcion Localización";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(671, 619);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(148, 22);
            this.lblSubtotal.TabIndex = 10;
            this.lblSubtotal.Text = "Subtotal: XXXX";
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.Location = new System.Drawing.Point(197, 41);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(160, 22);
            this.lblResumen.TabIndex = 49;
            this.lblResumen.Text = "Resumen Carrito";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(692, 31);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(172, 32);
            this.btnEliminar.TabIndex = 48;
            this.btnEliminar.Text = "Eliminar Carrito";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblLocalizacion
            // 
            this.lblLocalizacion.AutoSize = true;
            this.lblLocalizacion.Location = new System.Drawing.Point(32, 84);
            this.lblLocalizacion.Name = "lblLocalizacion";
            this.lblLocalizacion.Size = new System.Drawing.Size(0, 16);
            this.lblLocalizacion.TabIndex = 52;
            // 
            // lblNumTarjeta
            // 
            this.lblNumTarjeta.AutoSize = true;
            this.lblNumTarjeta.Location = new System.Drawing.Point(32, 222);
            this.lblNumTarjeta.Name = "lblNumTarjeta";
            this.lblNumTarjeta.Size = new System.Drawing.Size(44, 16);
            this.lblNumTarjeta.TabIndex = 53;
            this.lblNumTarjeta.Text = "label1";
            // 
            // fLPanelCarrito
            // 
            this.fLPanelCarrito.AutoScroll = true;
            this.fLPanelCarrito.BackColor = System.Drawing.Color.DarkSlateGray;
            this.fLPanelCarrito.Controls.Add(this.lblInfo);
            this.fLPanelCarrito.Location = new System.Drawing.Point(12, 21);
            this.fLPanelCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.fLPanelCarrito.Name = "fLPanelCarrito";
            this.fLPanelCarrito.Size = new System.Drawing.Size(647, 491);
            this.fLPanelCarrito.TabIndex = 51;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.White;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(3, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 39);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Visible = false;
            // 
            // FrmCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1479, 734);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCarrito";
            this.Text = "FrmCarrito";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCarrito_FormClosed);
            this.Load += new System.EventHandler(this.FrmCarrito_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.fLPanelCarrito.ResumeLayout(false);
            this.fLPanelCarrito.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDescripcionLocalizacion;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnEditarPago;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Button btnVolverPago;
        private System.Windows.Forms.Label lblDescripcionTarjeta;
        private System.Windows.Forms.Label lblMetodo;
        private Clases.BufferedFlowLayoutPanel fLPanelCarrito;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNumTarjeta;
        private System.Windows.Forms.Label lblLocalizacion;
    }
}