namespace pet4sitter
{
    partial class FrmTienda
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.ptbImagenProducto = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ptbFlechaAbajo = new System.Windows.Forms.PictureBox();
            this.ptbFlechaArriba = new System.Windows.Forms.PictureBox();
            this.btnFlechaAbajo = new System.Windows.Forms.Button();
            this.btnFlechaArriba = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbBusqueda = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenProducto)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFlechaAbajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFlechaArriba)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(98)))));
            this.panel3.Controls.Add(this.dgvProductos);
            this.panel3.Location = new System.Drawing.Point(360, 128);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 537);
            this.panel3.TabIndex = 5;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(21, 20);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(605, 490);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.btnAñadir);
            this.panel1.Controls.Add(this.ptbImagenProducto);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(1020, 128);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 537);
            this.panel1.TabIndex = 6;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Location = new System.Drawing.Point(120, 501);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(136, 32);
            this.btnAñadir.TabIndex = 47;
            this.btnAñadir.Text = "Añadir Carrito";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // ptbImagenProducto
            // 
            this.ptbImagenProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ptbImagenProducto.Location = new System.Drawing.Point(24, 32);
            this.ptbImagenProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbImagenProducto.Name = "ptbImagenProducto";
            this.ptbImagenProducto.Size = new System.Drawing.Size(317, 150);
            this.ptbImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagenProducto.TabIndex = 46;
            this.ptbImagenProducto.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblCantidad);
            this.panel4.Controls.Add(this.lblId);
            this.panel4.Controls.Add(this.txtDescripcion);
            this.panel4.Controls.Add(this.lblNombre);
            this.panel4.Controls.Add(this.lblPrecio);
            this.panel4.Location = new System.Drawing.Point(24, 201);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(317, 294);
            this.panel4.TabIndex = 45;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(204, 14);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(21, 22);
            this.lblCantidad.TabIndex = 49;
            this.lblCantidad.Text = "a";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCantidad.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(65, 14);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 22);
            this.lblId.TabIndex = 48;
            this.lblId.Text = "a";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblId.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDescripcion.Location = new System.Drawing.Point(44, 147);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(237, 107);
            this.txtDescripcion.TabIndex = 13;
            this.txtDescripcion.Text = "";
            this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(94, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(99, 28);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "NOMBRE";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(113, 90);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(81, 28);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "PRECIO";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.ptbFlechaAbajo);
            this.panel5.Controls.Add(this.ptbFlechaArriba);
            this.panel5.Controls.Add(this.btnFlechaAbajo);
            this.panel5.Controls.Add(this.btnFlechaArriba);
            this.panel5.Location = new System.Drawing.Point(660, 10);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 42);
            this.panel5.TabIndex = 44;
            // 
            // ptbFlechaAbajo
            // 
            this.ptbFlechaAbajo.Image = global::pet4sitter.Properties.Resources.flecha__1_;
            this.ptbFlechaAbajo.Location = new System.Drawing.Point(255, 1);
            this.ptbFlechaAbajo.Name = "ptbFlechaAbajo";
            this.ptbFlechaAbajo.Size = new System.Drawing.Size(41, 39);
            this.ptbFlechaAbajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFlechaAbajo.TabIndex = 47;
            this.ptbFlechaAbajo.TabStop = false;
            // 
            // ptbFlechaArriba
            // 
            this.ptbFlechaArriba.Image = global::pet4sitter.Properties.Resources.flecha_arriba;
            this.ptbFlechaArriba.Location = new System.Drawing.Point(101, 1);
            this.ptbFlechaArriba.Name = "ptbFlechaArriba";
            this.ptbFlechaArriba.Size = new System.Drawing.Size(41, 39);
            this.ptbFlechaArriba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFlechaArriba.TabIndex = 46;
            this.ptbFlechaArriba.TabStop = false;
            // 
            // btnFlechaAbajo
            // 
            this.btnFlechaAbajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.btnFlechaAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlechaAbajo.Location = new System.Drawing.Point(201, 0);
            this.btnFlechaAbajo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFlechaAbajo.Name = "btnFlechaAbajo";
            this.btnFlechaAbajo.Size = new System.Drawing.Size(45, 42);
            this.btnFlechaAbajo.TabIndex = 44;
            this.btnFlechaAbajo.UseVisualStyleBackColor = false;
            this.btnFlechaAbajo.Click += new System.EventHandler(this.btnFlechaAbajo_Click);
            // 
            // btnFlechaArriba
            // 
            this.btnFlechaArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.btnFlechaArriba.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlechaArriba.Location = new System.Drawing.Point(42, 0);
            this.btnFlechaArriba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFlechaArriba.Name = "btnFlechaArriba";
            this.btnFlechaArriba.Size = new System.Drawing.Size(48, 42);
            this.btnFlechaArriba.TabIndex = 42;
            this.btnFlechaArriba.UseVisualStyleBackColor = false;
            this.btnFlechaArriba.Click += new System.EventHandler(this.btnFlechaArriba_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(17, 10);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(536, 41);
            this.txtBusqueda.TabIndex = 18;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(133)))), ((int)(((byte)(98)))));
            this.panel2.Controls.Add(this.ptbBusqueda);
            this.panel2.Controls.Add(this.txtBusqueda);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(360, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 63);
            this.panel2.TabIndex = 7;
            // 
            // ptbBusqueda
            // 
            this.ptbBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.ptbBusqueda.Image = global::pet4sitter.Properties.Resources.lupa;
            this.ptbBusqueda.Location = new System.Drawing.Point(572, 10);
            this.ptbBusqueda.Name = "ptbBusqueda";
            this.ptbBusqueda.Size = new System.Drawing.Size(42, 41);
            this.ptbBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBusqueda.TabIndex = 45;
            this.ptbBusqueda.TabStop = false;
            this.ptbBusqueda.Click += new System.EventHandler(this.ptbBusqueda_Click);
            // 
            // FrmTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1479, 734);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTienda";
            this.Text = "FrmTienda";
            this.Load += new System.EventHandler(this.FrmTienda_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenProducto)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFlechaAbajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFlechaArriba)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBusqueda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbImagenProducto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnFlechaAbajo;
        private System.Windows.Forms.Button btnFlechaArriba;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.PictureBox ptbFlechaAbajo;
        private System.Windows.Forms.PictureBox ptbFlechaArriba;
        private System.Windows.Forms.PictureBox ptbBusqueda;
        private System.Windows.Forms.Label lblCantidad;
    }
}