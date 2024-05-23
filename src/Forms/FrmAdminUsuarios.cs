using MySql.Data.MySqlClient;
using pet4sitter.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet4sitter
{
    public partial class FrmAdminUsuarios : Form
    {
        public FrmAdminUsuarios()
        {
            InitializeComponent();
        }

        private void FrmAdminUsuarios_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = ConfiguracionIdioma.Cultura;
            AplicarIdioma();
            if (ConBD.Conexion != null)
            {
                try
                {
                    ConBD.AbrirConexion();
                    limpiarTablaUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
                finally
                {
                    ConBD.CerrarConexion();
                }
            }
        }

        private void AplicarIdioma()
        {
            btnVolver.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.btnVolver_Text;
            lblUsuarioss.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.lblUsuarioss_Text;
            btnEliminarUsuario.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.btnEliminarUsuario_Text;
            btnEditar.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.btnEditar_Text;
            lblUsuario.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.lblUsuario_Text;
            label1.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.label1_Text;
            lblPassword.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.label8_Text;
            lblDni.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.label7_Text;
            lblEmail.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.label6_Text;
            lblName.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.label4_Text;
            lblId.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.label3_Text;
            lblAdministrator.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.label10_Text;
            lblSitter.Text = Resources.Recursos_Localizable.FrmAdminUsuarios.label9_Text;
        }

        private void limpiarTablaUsers()
        {
            dgvUsers.DataSource = null;
            dgvUsers.Rows.Clear();

            DataTable usuarios = User.CargarUsuarios();
            if (usuarios != null)
            {
                dgvUsers.DataSource = usuarios;
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                DataGridViewRow fila = dgvUsers.Rows[e.RowIndex];
                lblId.Text = fila.Cells[0].Value.ToString();
                lblName.Text = fila.Cells[1].Value.ToString();
                lblEmail.Text = fila.Cells[2].Value.ToString();
                lblPassword.Text = fila.Cells[3].Value.ToString();
                if(fila.Cells[7].Value as byte[] != null)
                {
                    ptbImagen.Image = Utiles.ByteArrayToImage(fila.Cells[7].Value as byte[]);
                }
                else
                {
                    ptbImagen.Image = Properties.Resources.usuario;
                }
                if (fila.Cells[5].Value.ToString() == "0" || fila.Cells[5].Value.ToString() == "")
                {
                }
                else
                {
                    ckbSitter.Checked = true;
                }
                if (fila.Cells[6].Value.ToString() == "" || fila.Cells[6].Value.ToString() == "0")
                {
                }
                else
                {
                    ckbAdministrator.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("No se puede hacer doble click en la celda");
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (ConBD.Conexion != null)
            {
                try
                {
                    ConBD.AbrirConexion();
                    User.EliminarUsuarios(int.Parse(lblId.Text));
                    limpiarTablaUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar usuario: " + ex.Message);
                }
                finally
                {
                    ConBD.CerrarConexion();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
