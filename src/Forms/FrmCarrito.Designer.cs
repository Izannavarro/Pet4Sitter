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
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valoracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolverPago = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRealizar = new System.Windows.Forms.Button();
            this.lblDescripcionTarjeta = new System.Windows.Forms.Label();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.btnEditarPago = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblDescripcionLocalizacion = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblResumen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(98)))));
            this.panel3.Controls.Add(this.dgvCarrito);
            this.panel3.Location = new System.Drawing.Point(142, 59);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 438);
            this.panel3.TabIndex = 6;
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cantidad,
            this.Precio,
            this.Descripcion,
            this.Valoracion});
            this.dgvCarrito.Location = new System.Drawing.Point(28, 18);
            this.dgvCarrito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.RowHeadersWidth = 51;
            this.dgvCarrito.RowTemplate.Height = 24;
            this.dgvCarrito.Size = new System.Drawing.Size(454, 398);
            this.dgvCarrito.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            // 
            // Valoracion
            // 
            this.Valoracion.HeaderText = "Valoracion";
            this.Valoracion.MinimumWidth = 6;
            this.Valoracion.Name = "Valoracion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.btnVolverPago);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(666, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 469);
            this.panel1.TabIndex = 10;
            // 
            // btnVolverPago
            // 
            this.btnVolverPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverPago.Location = new System.Drawing.Point(70, 433);
            this.btnVolverPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolverPago.Name = "btnVolverPago";
            this.btnVolverPago.Size = new System.Drawing.Size(142, 26);
            this.btnVolverPago.TabIndex = 52;
            this.btnVolverPago.Text = "Volver";
            this.btnVolverPago.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnRealizar);
            this.panel4.Controls.Add(this.lblDescripcionTarjeta);
            this.panel4.Controls.Add(this.lblMetodo);
            this.panel4.Controls.Add(this.btnEditarPago);
            this.panel4.Controls.Add(this.btnEditar);
            this.panel4.Controls.Add(this.lblDescripcionLocalizacion);
            this.panel4.Location = new System.Drawing.Point(18, 22);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 395);
            this.panel4.TabIndex = 45;
            // 
            // btnRealizar
            // 
            this.btnRealizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizar.Location = new System.Drawing.Point(52, 353);
            this.btnRealizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(142, 26);
            this.btnRealizar.TabIndex = 47;
            this.btnRealizar.Text = "Realizar Pedido";
            this.btnRealizar.UseVisualStyleBackColor = true;
            // 
            // lblDescripcionTarjeta
            // 
            this.lblDescripcionTarjeta.AutoSize = true;
            this.lblDescripcionTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionTarjeta.Location = new System.Drawing.Point(21, 211);
            this.lblDescripcionTarjeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcionTarjeta.Name = "lblDescripcionTarjeta";
            this.lblDescripcionTarjeta.Size = new System.Drawing.Size(155, 18);
            this.lblDescripcionTarjeta.TabIndex = 51;
            this.lblDescripcionTarjeta.Text = "Descripcion Tarjeta";
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodo.Location = new System.Drawing.Point(21, 139);
            this.lblMetodo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(137, 18);
            this.lblMetodo.TabIndex = 50;
            this.lblMetodo.Text = "Metodo de Pago:";
            // 
            // btnEditarPago
            // 
            this.btnEditarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPago.Location = new System.Drawing.Point(158, 167);
            this.btnEditarPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarPago.Name = "btnEditarPago";
            this.btnEditarPago.Size = new System.Drawing.Size(68, 26);
            this.btnEditarPago.TabIndex = 49;
            this.btnEditarPago.Text = "Editar";
            this.btnEditarPago.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(124, 84);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 26);
            this.btnEditar.TabIndex = 48;
            this.btnEditar.Text = "Editar Direccion";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // lblDescripcionLocalizacion
            // 
            this.lblDescripcionLocalizacion.AutoSize = true;
            this.lblDescripcionLocalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionLocalizacion.Location = new System.Drawing.Point(14, 27);
            this.lblDescripcionLocalizacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcionLocalizacion.Name = "lblDescripcionLocalizacion";
            this.lblDescripcionLocalizacion.Size = new System.Drawing.Size(198, 18);
            this.lblDescripcionLocalizacion.TabIndex = 9;
            this.lblDescripcionLocalizacion.Text = "Descripcion Localización";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(519, 28);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 26);
            this.btnEliminar.TabIndex = 48;
            this.btnEliminar.Text = "Eliminar Carrito";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(503, 503);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(124, 18);
            this.lblSubtotal.TabIndex = 10;
            this.lblSubtotal.Text = "Subtotal: XXXX";
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.Location = new System.Drawing.Point(148, 33);
            this.lblResumen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(136, 18);
            this.lblResumen.TabIndex = 49;
            this.lblResumen.Text = "Resumen Carrito";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 62);
            this.button1.TabIndex = 50;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1109, 596);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCarrito";
            this.Text = "FrmCarrito";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCarrito_FormClosed);
            this.Load += new System.EventHandler(this.FrmCarrito_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valoracion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDescripcionLocalizacion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnEditarPago;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Button btnVolverPago;
        private System.Windows.Forms.Label lblDescripcionTarjeta;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.Button button1;
    }
}