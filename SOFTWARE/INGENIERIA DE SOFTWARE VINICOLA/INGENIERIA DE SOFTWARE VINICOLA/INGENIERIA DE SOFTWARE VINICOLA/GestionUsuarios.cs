using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using SERVICIOS;
using BE;
using BLL;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics;


namespace INGENIERIA_DE_SOFTWARE_VINICOLA
{
    public partial class GestionUsuarios : Form, IObserver
    {
        BLLEvento evento = new BLLEvento();
        Negocios negocios = new Negocios();
        BLLUsuario usuario = new BLLUsuario();
        CryptoManager cryptoManager = new CryptoManager();
       
        public GestionUsuarios()
        {
            InitializeComponent();
            LanguageManager.ObtenerInstancia().Agregar(this);
        }
        public void ActualizarIdioma()
        {
            LanguageManager.ObtenerInstancia().CambiarIdiomaControles(this);
        }

        private void frmGestionUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
        private void frmGestionUsuarios_VisibleChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocios.ObtenerTabla("DNI, Nombre, Apellido, Mail, NumeroTelefono, UserName, Rol,Bloqueado, Desactivado", "Usuario");
            ColorearInactivos();
        }
   
       

        private string ObtenerCondiciones()
        {
            string c = "";

            if(checkBox1.Checked == true) 
            {

                c += "DNI = " + numericUpDown1.Value.ToString() + " AND ";
            }
            if(checkBox2.Checked == true)
            {
                c += "Nombre = '" + textBox1.Text + "' AND ";

            }
            if(checkBox3.Checked == true) 
            {
                c += "Apellido = '" + textBox2.Text + "' AND ";
            }
            if(checkBox4.Checked == true)
            {
                c += "Mail = '" + textBox3.Text + "' AND ";
            }
            if(checkBox5.Checked == true)
            {
                c += "NumeroTelefono = '" + textBox4.Text + "' AND ";
            }
            if (checkBox6.Checked == true)
            {
                c += "UserName = '" + txtUserName.Text + "' AND ";
            }
            if(checkBox8.Checked == true)
            {
                c += "Rol = '" + comboBox1.Text + "' AND ";
            }
            if(checkBox9.Checked == true)
            {
                c += "Bloqueado = '" + checkBox11.Checked.ToString() + "' AND";
            }
            if(checkBox10.Checked== true)
            {
                c += "Desactivado = '" + checkBox12.Checked.ToString() + "' AND";
            }
            if(c.Length > 5)
            {
                c= c.Substring(0, c.Length - 5);
            }
            return c;
        }

        private void ColorearInactivos()
        {
            int cont = 0;
            try { 
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                cont++;
                if (Convert.ToInt32(row.Cells[9].Value) == 1) 
                { 
                    
                    row.DefaultCellStyle.BackColor = Color.Red;
                
                
                }
            }
            label4.Text = "NUMERO DE USUARIOS: " + cont;
            }catch (Exception ex) { }
        }

        private void ActivarBotones(Button b, string adm)
        {
            txtPanel.Text = adm;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
            btnDesbloquear.Enabled = true;

            b.Enabled = false;

            LimpiarCampos();

            if(adm == "Consultas")
            {
                foreach(CheckBox cb in this.Controls.OfType<CheckBox>())
                {
                    cb.Enabled = true;
                }

            }
            else
            {
                foreach(CheckBox cb in this.Controls.OfType<CheckBox>())
                {
                    cb.Enabled = false;
                }
            }

            if(adm == "Modo eliminar")
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                txtUserName.Enabled = false;
                comboBox1.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                txtUserName.Enabled = true;
                comboBox1.Enabled = true;
            }
        }

        private void LimpiarCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            txtUserName.Text = "";
            comboBox1.SelectedItem = null;
            numericUpDown1.Value = numericUpDown1.Minimum;
            foreach(CheckBox cb in this.Controls.OfType<CheckBox>())
            {
                cb.Checked = false;
            } 
        }
        private bool ValidarCampos()
        {
            MailAddress Correo;
            bool MailValido = false;
           

            if(textBox3.Text != "")
            {
                try
                {
                    Correo = new MailAddress(textBox3.Text);
                    MailValido = true;
                }
                catch (FormatException) { }

            }
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || txtUserName.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Porfavor llene todos los campos");
            }
            else if (negocios.RevisarDisponibilidad(numericUpDown1.Value.ToString(), "DNI", "Usuario") && txtPanel.Text != "Modo modificar")
            {
                MessageBox.Show("DNI ya está registrado");
            }
            else if (MailValido == false && txtPanel.Text != "Modo modificar")
            {
                MessageBox.Show("El correo ingresado no es válido");
            }
            else if (negocios.RevisarDisponibilidad(textBox3.Text, "Mail", "Usuario") && txtPanel.Text != "Modo modificar")
            {
                MessageBox.Show("El correo ingresado se está usando");
            }
            //else if (NumeroTelefonoValido == false)
            //{
            //    MessageBox.Show("El numero de telefono ingresado no es valido");
            //}
            else if (negocios.RevisarDisponibilidad(txtUserName.Text, "UserName", "Usuario"))
            {
                MessageBox.Show("Nombre de usuario se encuentra en uso");
            }
            else
            {
                return true;
            }
            return false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ActivarBotones(btnAgregar, "Modo añadir");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ActivarBotones(btnEliminar, "Modo eliminar");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ActivarBotones(btnModificar, "Modo modificar");
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            ActivarBotones(btnDesbloquear, "Modo desbloquear");
         
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if(txtPanel.Text == "Modo añadir")
            {
                if(ValidarCampos() == true)
                {
                    Usuario user = new Usuario(Convert.ToInt32(numericUpDown1.Value), textBox1.Text, textBox2.Text, textBox3.Text,Convert.ToInt32(textBox4.Text),txtUserName.Text,cryptoManager.GetSHA256(numericUpDown1.Value.ToString() + textBox2.Text.Replace(" ", " ")), comboBox1.Text);
                    MessageBox.Show("Usuario registrado");
                    usuario.RegistrarUsuario(user);
                    actualizarGrilla();
                    evento.RegistrarEvento(new Evento(SessionManager.ObtenerInstancia().Usuario.UserName, DateTime.Now, "AgregarUsuario", 2));
                    ActivarBotones(btnCancelar, "Añadir");

                    
                }
            }
            if(txtPanel.Text == "Modo modificar")
            {
                if(ValidarCampos() == true)
                {
                    Usuario user = new Usuario(Convert.ToInt32(numericUpDown1.Value), textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), txtUserName.Text, "", comboBox1.Text);
                    MessageBox.Show("Se ha modificado el usuario con el dni que se ingresó");
                    usuario.ModificarUsuario(user);
                    
                    actualizarGrilla();
                    ActivarBotones(btnCancelar, "Modificar");
                    
                }
            }
            if(txtPanel.Text == "Modo eliminar")
            {
                usuario.EliminarUsuario(Convert.ToInt32(numericUpDown1.Value));                
                MessageBox.Show("Se ha eliminado el usuario con el dni que se ingresó");
                actualizarGrilla();
                ActivarBotones(btnCancelar, "Eliminar");
                
            }
            if(ObtenerCondiciones().Length > 5)
            {
                dataGridView1.DataSource = negocios.ObtenerTabla("DNI, Nombre, Apellido, Mail, NumeroTelefono, UserName, Rol, Bloqueado, Desactivado", "Usuario", ObtenerCondiciones());
            }
            else
            {
                dataGridView1.DataSource = negocios.ObtenerTabla("DNI, Nombre, Apellido, Mail, NumeroTelefono, UserName, Rol, Bloqueado, Desactivado", "Usuario");
            }
            if (txtPanel.Text == "Modo desbloquear")
            {
                if(negocios.RevisarDisponibilidad(numericUpDown1.Value.ToString(),"DNI", "Usuario") == false)
                {
                    MessageBox.Show("DNI Ingresado no existe");
                }
                else if(usuario.RevisarBloqueado(Convert.ToInt32(numericUpDown1.Value)) == false)
                {
                    usuario.BloquearUsuario(Convert.ToInt32(numericUpDown1.Value));
                    MessageBox.Show("El usuario se ha bloqueado");
                }
                else
                {
                    usuario.DesbloquearDNI(Convert.ToInt32(numericUpDown1.Value));
                    DataTable dt = negocios.ObtenerTabla("DNI, Apellido", "Usuario", $"DNI = {numericUpDown1.Value}");
                    usuario.ActualizarContraseña(Convert.ToInt32(numericUpDown1.Value), cryptoManager.GetSHA256(dt.Rows[0][0].ToString() + dt.Rows[0][1].ToString().Replace(" ", " ")));

                    MessageBox.Show("El usuario se ha desbloqueado");
                }
                actualizarGrilla();
            ColorearInactivos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActivarBotones(btnCancelar, "Consultas");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualizarGrilla()
        {
            dataGridView1.DataSource = negocios.ObtenerTabla("DNI, Nombre, Apellido, Mail, NumeroTelefono, UserName, Rol,Bloqueado, Desactivado", "Usuario");
            ColorearInactivos();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            actualizarGrilla();
        }

       
    }
}