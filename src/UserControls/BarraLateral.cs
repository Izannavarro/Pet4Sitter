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
    public partial class BarraLateral : UserControl
    {
        private Form formActual;
        public BarraLateral()
        {
            InitializeComponent();
        }
        public BarraLateral(Form formActual)
        {
            InitializeComponent();
            this.formActual = formActual;
        }
        
        private void HoverBarraLateral()
        {
            pnlBarraLateral.Size = new Size(310, 635);
            pnlBarraLateral.BringToFront();
            this.BringToFront();
        }

        private void LeaveBarraLateral()
        {
            pnlBarraLateral.Size = new Size(100, 635);
            pnlBarraLateral.SendToBack();
            this.SendToBack();
        }

        private void pnlBarraLateral_MouseLeave(object sender, EventArgs e)
        {
            LeaveBarraLateral();
        }

        private void pnlBarraLateral_MouseHover(object sender, EventArgs e)
        {
            HoverBarraLateral();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            HoverBarraLateral();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            HoverBarraLateral();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            HoverBarraLateral();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            HoverBarraLateral();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            HoverBarraLateral();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            HoverBarraLateral();
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            HoverBarraLateral();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            LeaveBarraLateral();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            LeaveBarraLateral();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            LeaveBarraLateral();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            LeaveBarraLateral();
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            LeaveBarraLateral();
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            LeaveBarraLateral();
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            LeaveBarraLateral();
        }

        private void BarraLateral_MouseHover(object sender, EventArgs e)
        {
            HoverBarraLateral();
        }

        private void BarraLateral_MouseLeave(object sender, EventArgs e)
        {
            LeaveBarraLateral();
        }

        private void LblBúsqueda_MouseHover(object sender, EventArgs e)
        {
            HoverBarraLateral();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            HoverBarraLateral();
        }

        private void lblNoticias_MouseHover(object sender, EventArgs e)
        {
            HoverBarraLateral();
        }

        private void lblTienda_MouseHover(object sender, EventArgs e)
        {
            HoverBarraLateral();
        }

        private void lblIaYuda_MouseHover(object sender, EventArgs e)
        {
            HoverBarraLateral();
        }

        private void lblAjustes_MouseHover(object sender, EventArgs e)
        {
            HoverBarraLateral();
        }

        private void lblPerfil_MouseHover(object sender, EventArgs e)
        {
            HoverBarraLateral();
        }

        private void LblBúsqueda_MouseLeave(object sender, EventArgs e)
        {
            LeaveBarraLateral();
        }

        private void label2_Leave(object sender, EventArgs e)
        {
            LeaveBarraLateral();
        }

        private void lblNoticias_MouseLeave(object sender, EventArgs e)
        {
            LeaveBarraLateral();
        }

        private void lblTienda_MouseLeave(object sender, EventArgs e)
        {
            LeaveBarraLateral();
        }

        private void lblIaYuda_MouseLeave(object sender, EventArgs e)
        {
            LeaveBarraLateral();
        }

        private void lblAjustes_MouseLeave(object sender, EventArgs e)
        {
            LeaveBarraLateral();
        }

        private void lblPerfil_MouseLeave(object sender, EventArgs e)
        {
            LeaveBarraLateral();
        }

        private void pictureBox2_MouseHover_1(object sender, EventArgs e)
        {
            HoverBarraLateral();
        }

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            LeaveBarraLateral();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            HoverBarraLateral();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            LeaveBarraLateral();
        }

        private void pnlBarraLateral_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BarraLateral_Load(object sender, EventArgs e)
        {
            LeaveBarraLateral();
        }

        private void pcbBuscar_Click(object sender, EventArgs e)
        {
            FrmFiltrador form = new FrmFiltrador();
            form.Show();
            form.StartPosition = FormStartPosition.Manual; // Esto evita animaciones del sistema
            formActual.Dispose();
        }

        private void pcbLogo_Click(object sender, EventArgs e)
        {
            FrmInicio form = new FrmInicio();
            form.Show();
            form.StartPosition = FormStartPosition.Manual; // Esto evita animaciones del sistema
            formActual.Dispose();
        }

        private void pcbChat_Click(object sender, EventArgs e)
        {
            FrmChat form = new FrmChat();
            form.Show();
            formActual.Dispose();
        }

        private void pcbIaYuda_Click(object sender, EventArgs e)
        {
            FrmIAyuda form = new FrmIAyuda();
            form.Show();
            formActual.Dispose();
        }

        private void pcbEditarPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil form = new FrmPerfil();
            form.ShowDialog();
        }
    }
}
