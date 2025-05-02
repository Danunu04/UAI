using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BE;
using BLL;

namespace Proyecto_DAS
{
    public partial class Gestionar_Empleado : Form
    {
        Bll Bllsita = new Bll();

        public Gestionar_Empleado()
        {
            InitializeComponent();
        }

        private void Gestionar_Empleado_Load(object sender, EventArgs e)
        {
            CargarDGVs();
            //observer mati


        }

       
       
        private void BtnModificar_Click(object sender, EventArgs e)
        {

            CLSUsuario U = new CLSUsuario();

            U.Documento = Convert.ToInt32(TxtDoc.Text);
            U.Nombre = TxtNom.Text;
            U.Apellido = TxtApe.Text;
            U.Mail = U.Nombre + "." + U.Apellido + "@Sanaima.edu.com.ar";
            U.Contraseña = LblContra.Text;
            U.Fecha_Nacimiento = Convert.ToDateTime(DtpFecNac.Value);
            U.Rol = CmbRol.SelectedItem.ToString();
            U.Idioma = CmbIdioma.SelectedItem.ToString();
            U.Estado = Convert.ToInt32(LblEstado.Text);


            Bllsita.EditarUsuario(U);
            CargarDGVs();
            Limpiar();
        }

        private void BtnHabiDesa_Click(object sender, EventArgs e)
        {
             // [] pensar como hacerlo
            CLSUsuario U = new CLSUsuario();

            U.Documento =Convert.ToInt32(TxtDoc.Text);
            U.Nombre = TxtNom.Text;
            U.Apellido = TxtApe.Text;
            U.Mail = TxtMail.Text;
            U.Contraseña = LblContra.Text;
            U.Fecha_Nacimiento = DtpFecNac.Value;
            U.Rol = CmbRol.SelectedItem.ToString();
            U.Idioma = CmbIdioma.SelectedItem.ToString();
            U.Estado = Convert.ToInt32( LblEstado.Text);

            if(U.Estado == 0)
            {
                U.Estado = 1;
            }
            else if(U.Estado == 1)
            {
                U.Estado = 0;
            }




            Bllsita.EditarUsuario(U);
            CargarDGVs();
            Limpiar();

        }

      

        private List<CLSUsuario> ListaCargada()
        {
            List<CLSUsuario> listaEmpleados = Bllsita.RecibirListaEmpleados();
            return listaEmpleados;

        }
        private void CargarDGVs()
        {


            DgvHabilitado.Rows.Clear();
            DgvDeshabilitado.Rows.Clear();

            foreach (var E in ListaCargada())
            {
                if(E.Estado == 0)
                {
                    DgvHabilitado.Rows.Add(E.Documento, E.Nombre, E.Apellido, E.Fecha_Nacimiento, E.Mail, E.Contraseña, E.Rol, E.Idioma, E.Estado);
                }
                else if (E.Estado == 1)
                {
                    DgvDeshabilitado.Rows.Add(E.Documento, E.Nombre, E.Apellido, E.Fecha_Nacimiento, E.Mail, E.Contraseña, E.Rol, E.Idioma, E.Estado);
                }           
            }

        }

        private void Limpiar()
        {
            TxtDoc.Text = null;
            TxtApe.Text = null;
            TxtNom.Text = null;
            TxtMail.Text = null;
            DtpFecNac.Value = DateTime.Now; 
            CmbRol.SelectedIndex = -1; 
            CmbIdioma.SelectedIndex = -1; 
        }

        private void DgvHabilitado_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvHabilitado.SelectedRows.Count > 0)
            {
                    DataGridViewRow seleccionado = DgvHabilitado.SelectedRows[0];

                    TxtDoc.Text = seleccionado.Cells[0].Value.ToString();
                    TxtNom.Text = seleccionado.Cells[1].Value.ToString();
                    TxtApe.Text = seleccionado.Cells[2].Value.ToString();
                    DtpFecNac.Value = Convert.ToDateTime(seleccionado.Cells[3].Value.ToString());
                    TxtMail.Text = seleccionado.Cells[4].Value.ToString();
                    LblContra.Text = seleccionado.Cells[5].Value.ToString();
                    CmbRol.SelectedItem = seleccionado.Cells[6].Value.ToString();//si da error cambiar a selectedIndex
                    CmbIdioma.SelectedItem = seleccionado.Cells[7].Value.ToString();
                    LblEstado.Text= seleccionado.Cells[8].Value.ToString();

            }
        }

         
        

       
        private void DgvDeshabilitado_SelectionChanged_1(object sender, EventArgs e)
        {
            if (DgvDeshabilitado.SelectedRows.Count > 0)
            {
                DataGridViewRow seleccionado = DgvDeshabilitado.SelectedRows[0];

                TxtDoc.Text = seleccionado.Cells[0].Value.ToString();
                TxtNom.Text = seleccionado.Cells[1].Value.ToString();
                TxtApe.Text = seleccionado.Cells[2].Value.ToString();
                DtpFecNac.Value = Convert.ToDateTime(seleccionado.Cells[3].Value.ToString());
                TxtMail.Text = seleccionado.Cells[4].Value.ToString();
                LblContra.Text = seleccionado.Cells[5].Value.ToString();
                CmbRol.SelectedItem = seleccionado.Cells[6].Value.ToString();//si da error cambiar a selectedIndex
                CmbIdioma.SelectedItem = seleccionado.Cells[7].Value.ToString();
                LblEstado.Text = seleccionado.Cells[8].Value.ToString();
            }
        }
    }
}
