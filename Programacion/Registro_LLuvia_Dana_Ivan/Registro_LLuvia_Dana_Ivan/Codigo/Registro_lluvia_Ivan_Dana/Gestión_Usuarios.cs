using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SERVICIOS;

namespace Registro_lluvia_Ivan_Dana
{
    public partial class GestionUsuarios : Form
    {
        BLLUsuario BLLU = new BLLUsuario();
        CriptoManager CriptoManager = new CriptoManager();
        public GestionUsuarios(string idi)
        {
            InitializeComponent();
        }
        private bool showPassword;
        private void LBLUsuario_Click(object sender, EventArgs e)
        {

        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            LBLApellido.BackColor = System.Drawing.Color.Transparent;
            LBLCargarUsuario.BackColor = System.Drawing.Color.Transparent;
            LBLContraseña.BackColor = System.Drawing.Color.Transparent;
            LBLDni.BackColor = System.Drawing.Color.Transparent;
            LBLNombre.BackColor = System.Drawing.Color.Transparent;
            LBLUsuario.BackColor = System.Drawing.Color.Transparent;
            LBLRol.BackColor = System.Drawing.Color.Transparent;
            LBLCargarUsuario.BackColor= System.Drawing.Color.Transparent;
            LBLUsuarioRol.BackColor= System.Drawing.Color.Transparent;
            cargarDG();
        }

        private void cargarDG()
        {

            this.DGUsuarioRol.DataSource = null;
            this.DGUsuarioRol.DataSource = BLLU.ListarRoles();
            this.DGUsuarioRol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DGUsuarioRol.AlternatingRowsDefaultCellStyle.BackColor = Color.Tan;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNMostrarContra_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            if (showPassword)
            {
                TXTContraseña.PasswordChar = '\0';
            }
            else
            {
                TXTContraseña.PasswordChar = '*';
            }
        }

        private void BTNCargar_Click(object sender, EventArgs e)
        {
            if (TXTUsuario.Text == "" || TXTContraseña.Text == "" ||TXTNombre.Text == "" || TXTApellido.Text == "" ||TXTDni.Text == "" ||TXTRol.Text == "")
            {
                MessageBox.Show("Completar Datos faltantes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string N = TXTNombre.Text;
                    string A = TXTApellido.Text;
                    int D = Convert.ToInt32(TXTDni.Text);
                    string U = TXTUsuario.Text;
                    string C = CriptoManager.GetSHA256(TXTContraseña.Text);
                    string R = TXTRol.Text;
                    bool E = true;
                    BEUsuario BEU = new BEUsuario(N, A, D, U, C, E, R);
                    BLLU.Cargar(N, A, D, U, C, E, R);
                    cargarDG();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
    }
}
