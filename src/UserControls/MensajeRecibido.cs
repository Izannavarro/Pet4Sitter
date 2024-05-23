using pet4sitter.Clases;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace pet4sitter.Forms
{
    public partial class MensajeRecibido : UserControl
    {
        private const int MinHeight = 80;

        public MensajeRecibido()
        {
            InitializeComponent();
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; lblMensajeRecibido.Text = value; AddHeightText(); }
        }

        private Image _icon;
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; 
                pcbIcon.Image = _icon; }
        }

        void AddHeightText()
        {
            lblMensajeRecibido.AutoSize = false;
            lblMensajeRecibido.Height = Utiles.ObtenerAlturaTexto(lblMensajeRecibido);

            int newHeight = lblMensajeRecibido.Top + lblMensajeRecibido.Height + 10;
            this.Height = Math.Max(newHeight, MinHeight);
        }

        private void MensajeRecibido_Load(object sender, EventArgs e)
        {
            AddHeightText();
        }
    }
}
