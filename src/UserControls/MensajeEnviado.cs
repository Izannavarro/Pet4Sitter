using pet4sitter.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet4sitter
{
    public partial class MensajeEnviado : UserControl
    {
        public MensajeEnviado()
        {
            InitializeComponent();
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                lblMensajeEnviado.Text = value;
                AddHeightText();
            }
        }
        

        void AddHeightText()
        {
            MensajeEnviado mensajeEnviado = new MensajeEnviado();
            mensajeEnviado.BringToFront();
            lblMensajeEnviado.Height = Utiles.ObtenerAlturaTexto(lblMensajeEnviado);
            mensajeEnviado.Height = lblMensajeEnviado.Top + lblMensajeEnviado.Height;
            this.Height = mensajeEnviado.Bottom + 10;
        }

        private void lblMensajeEnviado_Click(object sender, EventArgs e)
        {

        }
    }
}
