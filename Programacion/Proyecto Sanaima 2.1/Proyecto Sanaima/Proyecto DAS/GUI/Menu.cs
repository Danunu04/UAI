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
using BE;
using BLL;
using Servicios;

namespace Proyecto_DAS
{
    public partial class Menu : Form
    {
        BLL.Bll BLL = new BLL.Bll();

        Observer_Idioma Controles = new Observer_Idioma();
        Idioma idi = new Idioma();

        

        public Menu()
        {
            InitializeComponent();
        }
        
        

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar_Empleado RE = new Registrar_Empleado();
            RE.Show();

        
        }

        private void registarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Registrar_Producto RP = new Registrar_Producto();
           RP.Show();


        }


        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Iniciar_Sesion IS = new Iniciar_Sesion();
            IS.MdiParent = this;
            IS.Show();
            
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            { 
                Session_Manager.DesLogear();

                registarProductoToolStripMenuItem.Enabled = false;
                registrarEmpleadoToolStripMenuItem.Enabled = false;
                administraciònToolStripMenuItem.Enabled = false;
                verMovimientoToolStripMenuItem.Enabled = false;
                rToolStripMenuItem.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void MenuActualizar()
        {
            Controles.RegistrarForm(this);
            idi.AgregarObservador(Controles);//?????xq

            CLSUsuario U = Session_Manager.Instancia().GetUsuario();
            if(U.Estado == 0) 
            { 

                if (U != null)
                {
                    string Rol = U.Rol;

                    if (Rol == "1")
                    {
                        registarProductoToolStripMenuItem.Enabled = false; //solo va a poder verlos
                        registrarEmpleadoToolStripMenuItem.Enabled = false;

                        GestionarEmpeladotoolStripMenuItem2.Enabled = true;
                        administraciònToolStripMenuItem.Enabled = true;
                        verMovimientoToolStripMenuItem.Enabled = true;
                        rToolStripMenuItem.Enabled = true;


                        //capaz aca va el metodo de bucle para las patentes especificas de cada rol
                    }
                    else if (Rol == "2")
                    {
                        registarProductoToolStripMenuItem.Enabled = false;


                        GestionarEmpeladotoolStripMenuItem2.Enabled = true;
                        registrarEmpleadoToolStripMenuItem.Enabled = true;
                        administraciònToolStripMenuItem.Enabled = true;
                        verMovimientoToolStripMenuItem.Enabled = true;
                        rToolStripMenuItem.Enabled = true;


                    }
                     else if (Rol == "3")
                     {
                        registarProductoToolStripMenuItem.Enabled = true;

                        registrarEmpleadoToolStripMenuItem.Enabled = false;
                        administraciònToolStripMenuItem.Enabled = false;
                        verMovimientoToolStripMenuItem.Enabled = false;
                        rToolStripMenuItem.Enabled = false;
                        GestionarEmpeladotoolStripMenuItem2.Enabled = false;
                     }

                  }
            }
            else
            {
                MessageBox.Show($"Sr/sra " + U.Apellido + " usted está inhabilitado, consulte con su superior o llame al 666");
            }

            if (Session_Manager.Instancia().GetUsuario() != null)
            {
                CLSUsuario usuario = Session_Manager.Instancia().GetUsuario();
                idi.CambiarIdioma(usuario.Idioma);
            }
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)//copy paste de todo esto en cada Form_Load 
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Gestionar_Empleado GE = new Gestionar_Empleado();
            GE.Show();
        }
    }
}
