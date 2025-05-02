using BE;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;
using BLL;

namespace Proyecto_DAS
{
    public partial class Iniciar_Sesion : Form
    {
        BLL.Bll BLL = new BLL.Bll();

        Observer_Idioma Controles = new Observer_Idioma();
        Idioma idi = new Idioma();
        public Iniciar_Sesion()
        {
            InitializeComponent();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            
            string Mail = TxtMail.Text;
            string Constrasenia = TxtConstraseña.Text;
            try { 
            if (BLL.VerificarUsuario(Mail, Constrasenia) == true)
            {
                CLSUsuario usuario = new CLSUsuario();
                usuario = BLL.BuscarUsuario(Mail);
                Session_Manager.Logear(usuario);

                    //Se hace así, porque el session manager no puede ser instanciado en otro lugar que no sea dentro de si mismo (Una a la vez).
                    

                    (this.MdiParent as Menu)?.MenuActualizar();        
            }
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Iniciar_Sesion_Load(object sender, EventArgs e)
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
