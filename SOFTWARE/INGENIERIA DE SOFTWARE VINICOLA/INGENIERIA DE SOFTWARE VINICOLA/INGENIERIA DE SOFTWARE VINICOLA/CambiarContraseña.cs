using BE;
using BLL;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INGENIERIA_DE_SOFTWARE_VINICOLA
{
    public partial class CambiarContraseña : Form, IObserver
    {

        
        Negocios negocios = new Negocios();
        BLLUsuario NegociosUsuario = new BLLUsuario();
        CryptoManager cryptoManager = new CryptoManager();
        Usuario usuarioActual;
        public CambiarContraseña()
        {
            usuarioActual = SessionManager.ObtenerDatosUsuario();
            InitializeComponent();
            LanguageManager.ObtenerInstancia().Agregar(this);
        }
        public void ActualizarIdioma()
        {
            LanguageManager.ObtenerInstancia().CambiarIdiomaControles(this);
        }
        private void FRMCambiarContraseña_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "")
            {
                if (usuarioActual != null)
                {
                    if (cryptoManager.GetSHA256(textBox2.Text) == usuarioActual.Password)
                    {
                        if (textBox3.Text == textBox4.Text)
                        {
                            try
                            {
                                NegociosUsuario.ActualizarContraseña(usuarioActual.DNI, cryptoManager.GetSHA256(textBox3.Text));
                                MessageBox.Show("Su clave ha sido cambiada");

                                SessionManager.ObtenerInstancia().CerrarSesion();
                                

                                this.Close();



                            }
                            catch (Exception ex) { MessageBox.Show("Error al cambiar la contraseña"); }

                        }
                        else { MessageBox.Show("Confirme la nueva clave"); }



                    }
                    else
                    {
                        MessageBox.Show("La contraseña actual ingresada no es correcta");
                    }

                }
                else { MessageBox.Show("Debe iniciar una sesion en el sistema"); }

            }
            else { MessageBox.Show("Complete los campos"); }
        }

        private void CambiarContraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
