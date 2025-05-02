using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using BLL;
using Servicios;

namespace Proyecto_DAS
{
    public partial class Registrar_Empleado : Form
    {
        public Registrar_Empleado()
        {
            InitializeComponent();
        }

        BLL.Bll Estado = new BLL.Bll();
       

        Observer_Idioma Controles = new Observer_Idioma();
        Idioma idi = new Idioma();

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            while (true)
            {
                RegistrarEmpleado();
                Limpiar();
                DialogResult Resultado = MessageBox.Show("¿Desea registrar otro empleado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (Resultado == DialogResult.No)
                {
                    break;
                }
            }
            this.Close();
        }

        private void RegistrarEmpleado()
        {
            CLSUsuario NuevoUsuario = new CLSUsuario();


            NuevoUsuario.Documento = Convert.ToInt32(TxtDoc.Text);
            NuevoUsuario.Apellido = TxtApe.Text;
            NuevoUsuario.Nombre = TxtNom.Text;
            NuevoUsuario.Mail = NuevoUsuario.Nombre + "." + NuevoUsuario.Apellido + "@Sanaima.edu.com.ar";
            NuevoUsuario.Fecha_Nacimiento = Convert.ToDateTime(DtpFecNac.Text);
            NuevoUsuario.Contraseña = TxtContra.Text;
            NuevoUsuario.Rol = CmbRol.Text;
            NuevoUsuario.Idioma = CmbIdioma.Text;
            NuevoUsuario.Estado = 0;

            Estado.GuardarUsuario(NuevoUsuario);
        }

        private void TxtNom_Leave(object sender, EventArgs e)
        {
            TxtMail.Text = TxtNom.Text + "." + TxtApe.Text + "@Sanaima.edu.com.ar";
        }

        private void Limpiar()
        {
            TxtDoc.Text = null;
            TxtApe.Text = null;
            TxtNom.Text = null;
            TxtMail.Text = null;
            TxtContra.Text = null;
            DtpFecNac.Value = DateTime.Now;
            CmbRol.Text = null;
            CmbIdioma.Text = null;
        }

        private void Registrar_Empleado_Load(object sender, EventArgs e)
        {
            //cambia el idioma
            Controles.RegistrarForm(this);
            idi.AgregarObservador(Controles);//?????xq
            if (Session_Manager.Instancia().GetUsuario() != null)
            {
                CLSUsuario usuario = Session_Manager.Instancia().GetUsuario();
                idi.CambiarIdioma(usuario.Idioma);

            }
        }
    }
}
