using GMap.NET.Internals;
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

namespace pet4sitter.Forms
{
    public partial class MensajeRecibido : UserControl
    {
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

    private string _icon;

    public string Icon
    {
        get { return _icon; }
        set { _icon = value; 
                //pcbIcon.Load(value); 
}
    }

        void AddHeightText()
        {
            MensajeRecibido mensajeRecibido = new MensajeRecibido();
            mensajeRecibido.BringToFront();
            lblMensajeRecibido.Height = Utiles.ObtenerAlturaTexto(lblMensajeRecibido);
            mensajeRecibido.Height = lblMensajeRecibido.Top + lblMensajeRecibido.Height;
            this.Height = mensajeRecibido.Bottom + 10;
        }

        private void MensajeRecibido_Load(object sender, EventArgs e)
        {
            AddHeightText();
        }
    }
}
