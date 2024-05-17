using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piTest
{
    public partial class BarraLateral : UserControl
    {
        public BarraLateral()
        {
            InitializeComponent();
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
    }
}
