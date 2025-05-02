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
using BLL;
using BE;
using System.Drawing.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;


namespace Registro_lluvia_Ivan_Dana
{
    public partial class LogIN : Form
    {
        BEUsuario BEU = null;
        LanguajeManager LMG = new LanguajeManager();
        Idioma idiom = new Idioma();
        private bool showPassword;
        BLLUsuario BLLU = new BLLUsuario();
        BLLEventos BLLE = new BLLEventos();
        Evento even = null;
        string Usuario;
        string Contraseña;
        string Idioma;
        public LogIN(string idi)
        {
            InitializeComponent();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void BTNIngresar_Click(object sender, EventArgs e)
        {
            Usuario = TXTUsuario.Text;
            Contraseña = TXTContraseña.Text;

            CriptoManager cripto = new CriptoManager();
            string ContraseñaHasheada = cripto.GetSHA256(Contraseña);
            try
            {

                if (TXTUsuario.Text == "" || TXTContraseña.Text == "")
                {
                    MessageBox.Show("Faltan Datos", "Error De inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Validación.ObtenerInstancia() != null)
                {
                    MessageBox.Show("Sesion ya activa", "Error De inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool Estado = BLLU.RevisarEstado(Usuario);
                    if (!Estado)
                    {
                        MessageBox.Show("Usuario Bloqueado", "Error De inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        BEUsuario BEU = BLLU.TraerUsuarioValido(Usuario, ContraseñaHasheada);
                        if (BEU == null)
                        {
                            int Cont = 0;
                            MessageBox.Show("Usuario o contraseña incorrectos", "Error De inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if (BLLU.IntentoFallido(Usuario))
                            {
                                Cont++;
                                if(Cont>=3)
                                {
                                    MessageBox.Show("Cuenta Bloqueada por mas de 3 intentos fallidos", "Error De inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    string evento = "Cuenta del usuario" + BEU.Usuario + " bloqueada tras 3 intentos fallidos";
                                    even = new Evento(BEU.Usuario.ToString(), DateTime.Now, this.ToString(), "Bloqueo de cuenta", 1);
                                    BLLE.RegistrarEvento(even);
                                }
                            }
                        }
                        else
                        {
                            // Aquí se inicializa la sesión con el usuario válido
                            Validación.LogIn(BEU);
                            ModificarMenu(BEU);

                            // Cargar los permisos, reiniciar intentos fallidos, ocultar ventana de login
                            BLLU.ReiniciarIntentosFallidos(Usuario);
                            //string evento = "Cuenta del usuario" + BEU.Usuario + " Inicio Sesion";
                            even = new Evento(BEU.Usuario.ToString(), DateTime.Now, "Log In", "Inicio Sesion", 1);
                            BLLE.RegistrarEvento(even);
                            this.Hide();
                            TXTContraseña.Text = "";
                            TXTUsuario.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error De inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarMenu(BEUsuario BEU)
        {
            BLLUsuario Bllu = new BLLUsuario();
            int UsuarioID = Bllu.TraerUsuaeioID(Usuario);
            MessageBox.Show(UsuarioID.ToString());
            string Idioma = BLLU.TraerIdioma(Usuario);
            if (Idioma == "")
            {
                Idioma = "Español";
            }
            if (UsuarioID != 0)
            {
                BLLPermiso Per = new BLLPermiso();
                List<BEPermisos> permisos = Per.ObtenerPermisos(UsuarioID);
                foreach (BEPermisos item in permisos)
                {
                    string Activate = item.Nombre.ToString();
                    try
                    {
                        if (Activate == "Ingeniero")
                        {
                            (this.MdiParent as Inicio)?.ActivarIngeniero();
                            (this.MdiParent as Inicio)?.CambiarIdioma(Idioma);
                        }
                        if (Activate == "Admin")
                        {
                            (this.MdiParent as Inicio)?.ActivarAdministrador();
                            (this.MdiParent as Inicio)?.CambiarIdioma(Idioma);
                        }
                        if (Activate == "General")
                        {
                            (this.MdiParent as Inicio)?.ActivarIngeniero();
                            (this.MdiParent as Inicio)?.ActivarAdministrador();
                            (this.MdiParent as Inicio)?.CambiarIdioma(Idioma);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        BLLFamilia BLLF = new BLLFamilia();
        

        private void BTNContraseña_Click(object sender, EventArgs e)
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

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogIN_Load(object sender, EventArgs e)
        {
            Form F1 = this;
            LMG.RegistrarForm(F1); // Registrar el formulario actual
            idiom.AgregarObservador(LMG); // Agregar observador
            (this.MdiParent as Inicio)?.CambiarIdioma(Idioma);
            TXTContraseña.Text = "Dana200410";
            TXTUsuario.Text = "Danunu";
        }
    }
}
