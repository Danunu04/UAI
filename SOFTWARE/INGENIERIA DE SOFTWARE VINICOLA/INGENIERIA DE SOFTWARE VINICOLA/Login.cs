using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using SERVICIOS;
using System.Diagnostics;

namespace INGENIERIA_DE_SOFTWARE_VINICOLA
{
    public partial class Login : Form, IObserver
    {
        BLLPerfil NegociosFamilia = new BLLPerfil();
        BLLEvento evento = new BLLEvento();
        BLLUsuario NegociosUsuario = new BLLUsuario();
        CryptoManager cryptoManager = new CryptoManager();
       
        private bool showPassword = false;
        public Login()
        {
            InitializeComponent();
            LanguageManager.ObtenerInstancia().Agregar(this);
    
        }

        public void ActualizarIdioma()
        {
            LanguageManager.ObtenerInstancia().CambiarIdiomaControles(this);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            if (showPassword)
            {
                txtClave.PasswordChar = '\0';
                pictureBox1.Image = INGENIERIA_DE_SOFTWARE_VINICOLA.Properties.Resources.hide;
               
            }
            else
            {
                txtClave.PasswordChar = '*';
                pictureBox1.Image = INGENIERIA_DE_SOFTWARE_VINICOLA.Properties.Resources.show;
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ingresar_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Llene todos los espacios");
                return;
            }
            else if (NegociosUsuario.RevisarDesactivado(txtNombre.Text))
            {
                MessageBox.Show("El usuario al que intenta acceder se encuentra desactivado");
            }
            else if (NegociosUsuario.RevisarBloqueado(txtNombre.Text))
            {
                MessageBox.Show("El usuario al que intenta acceder se encuentra bloqueado");
            }
            if (SessionManager.ObtenerInstancia().Usuario != null)
            {
                MessageBox.Show("Ya hay una sesión activa.");
                return;
            }
          
            Usuario user = NegociosUsuario.RevisarLogin(txtNombre.Text,cryptoManager.GetSHA256(txtClave.Text));
            if (user == null)
            {
                MessageBox.Show("El nombre de usuario y la contraseña no coinciden");
                if (NegociosUsuario.IntentoFallido(txtNombre.Text))
                {
                    MessageBox.Show("Se ingreso la contraseña de manera incorrecta tres veces. Su cuenta ha sido bloqueada");
                    evento.RegistrarEvento(new Evento(SessionManager.ObtenerInstancia().Usuario.UserName, DateTime.Now, "Sesiones", "Contraseña erronea", 1));
                }
                
            }
            else
            {
                SessionManager.ObtenerInstancia().IniciarSesion(user);
                ModificarMenu(user.Rol);
                evento.RegistrarEvento(new Evento(SessionManager.ObtenerInstancia().Usuario.UserName, DateTime.Now,"Sesiones" ,"Login", 1));
                
                

                NegociosUsuario.ReiniciarIntentosFallidos(txtNombre.Text);

                this.Hide();

                txtNombre.Text = "";
                txtClave.Text = "";
            }


        }
      
        private void Login_Load(object sender, EventArgs e)
        {
            txtNombre.Text = "joaco";
            txtClave.Text = "1234";

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();

            }
        }
        public void ModificarMenu(string rol)
        {
            frmInicio parent = this.MdiParent as frmInicio;

            

            parent.cerrarSesiónToolStripMenuItem.Visible = true;
            parent.cambiarClaveToolStripMenuItem.Visible = true;



            parent.gestionUsuariosToolStripMenuItem.Visible = false;
            
            parent.gestionPerfilesToolStripMenuItem.Visible = false;

           
            parent.productosToolStripMenuItem.Visible = false;

            
            parent.carritoToolStripMenuItem.Visible = false;

         
            parent.clientesToolStripMenuItem.Visible = false;
            

            parent.reporte1ToolStripMenuItem.Visible = false;

            parent.bitacoraDeEventosToolStripMenuItem.Visible = false;

            foreach (DataRow dr in NegociosFamilia.ObtenerPermisosPorNombreFamilia(rol).Rows)
            {
                OtorgarVisibilidad(parent.menu.Items, dr[0].ToString(), parent);
            }

            foreach (DataRow dr in NegociosFamilia.ObtenerFamiliasPerfilPorNombre(rol).Rows)
            {
                foreach (DataRow dr2 in NegociosFamilia.ObtenerPermisosPorNombreFamilia(dr[0].ToString()).Rows)
                {
                    OtorgarVisibilidad(parent.menu.Items, dr2[0].ToString(), parent);
                }
            }

            
        }
        public void OtorgarVisibilidad(ToolStripItemCollection items, string NombrePermiso, frmInicio parent)
        {
            foreach (ToolStripMenuItem item in items)
            {
                if (item.Name == (NombrePermiso + "ToolStripMenuItem"))
                {
                    item.Visible = true;
                    item.OwnerItem.Visible = true;
                }
                OtorgarVisibilidad(item.DropDownItems, NombrePermiso, parent);
            }
        }
    }
    
    
}
  


