using BE;
using BLL;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace INGENIERIA_DE_SOFTWARE_VINICOLA
{
    public partial class Clientes : Form, IObserver
    {
        CryptoManager crypto = new CryptoManager();
        BLLCliente cliente = new BLLCliente();
        Negocios negocios = new Negocios();
        public Clientes()
        {
            InitializeComponent();
            LanguageManager.ObtenerInstancia().Agregar(this);
        }
        public void ActualizarIdioma()
        {
            LanguageManager.ObtenerInstancia().CambiarIdiomaControles(this);
        }
        private string ObtenerCondiciones()
        {
            string c = "";

            if (checkBox1.Checked == true)
            {

                c += "DNI = " + numericUpDown1.Value.ToString() + " AND ";
            }
            if (checkBox2.Checked == true)
            {
                c += "Nombre = '" + txtNombre.Text + "AND";

            }
            if (checkBox3.Checked == true)
            {
                c += "Apellido = '" + txtApellido.Text + "' AND ";
            }
           
            if (checkBox4.Checked == true)
            {
                c += "Domicilio = '" + txtDomicilio.Text + "' AND ";
            }
            if (checkBox5.Checked == true) 
            {
                c += "Email = '" + txtEmail.Text + "' AND ";
            }
            if (checkBox6.Checked == true)
            {
                c += "Telefono = '" + txtTelefono.Text + "' AND ";
            }
            if (c.Length > 5)
            {
                c = c.Substring(0, c.Length - 5);
            }
            return c;

        }
        private void ColorearInactivos()
        {
            int cont = 0;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    cont++;
                    if (Convert.ToInt32(row.Cells[7].Value) == 1)
                    {

                        row.DefaultCellStyle.BackColor = Color.Red;


                    }
                }
                label2.Text = "Numero de clientes: " + cont;
            }
            catch (Exception ex) { }

        }
        private void ActivarBotones(Button b, string adm)

        {
            txtPanel2.Text = adm;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true; 
            btnSalir.Enabled = true;


            b.Enabled = false;

            if (adm == "Consultas")
            {
                foreach (CheckBox cb in this.Controls.OfType<CheckBox>())
                {
                    cb.Enabled = true;
                }

            }
            else
            {
                foreach (CheckBox cb in this.Controls.OfType<CheckBox>())
                {
                    cb.Enabled = false;
                }
            }

            if (adm == "Modo eliminar")
            {
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtDomicilio.Enabled = false;
                txtEmail.Enabled = false;
                txtTelefono.Enabled = false;
                


            }
            else
            {
                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                txtDomicilio.Enabled = true;
                txtEmail.Enabled = true;
                txtTelefono.Enabled = true;

            }
        }
        private bool ValidarCampos()
        {
            MailAddress Correo;
            bool MailValido = false;


            if (txtEmail.Text != "")
            {
                try
                {
                    Correo = new MailAddress(txtEmail.Text);
                    MailValido = true;
                }
                catch (FormatException) { }

            }
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDomicilio.Text == "" || txtEmail.Text == "" || txtTelefono.Text == "") 
            {
                MessageBox.Show("Porfavor llene todos los campos");
            }
            else if (negocios.RevisarDisponibilidad(numericUpDown1.Value.ToString(), "DNI", "Cliente") && txtPanel2.Text != "Modo modificar")
            {
                MessageBox.Show("DNI ya está registrado");
            }
            else if (MailValido == false && txtPanel2.Text != "Modo modificar")
            {
                MessageBox.Show("El correo ingresado no es válido");
            }
            else if (negocios.RevisarDisponibilidad(txtEmail.Text, "Email", "Cliente") && txtPanel2.Text != "Modo modificar")
            {
                MessageBox.Show("El correo ingresado se está usando");
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ActivarBotones(btnModificar, "Modo modificar");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ActivarBotones(btnEliminar, "Modo eliminar");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActivarBotones(btnCancelar, "Consultas");
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if(txtPanel2.Text == "Modo añadir")
            {
                if (ValidarCampos() == true)
                {
                    Cliente cliente1 = new Cliente(Convert.ToInt32(numericUpDown1.Value), txtNombre.Text, 
                    txtApellido.Text, crypto.GetAES256(txtDomicilio.Text), txtEmail.Text, Convert.ToInt32(txtTelefono.Text));
                    MessageBox.Show("Se ha agregado un nuevo cliente");
                    cliente.AgregarCliente(cliente1);
                    ActualizarGrilla();
                    ActivarBotones(btnCancelar, "Añadir");

                }

            }
            if(txtPanel2.Text == "Modo modificar")
            {
                if (ValidarCampos() == true)
                {
                    
                    Cliente cliente1 = new Cliente(Convert.ToInt32(numericUpDown1.Value), txtNombre.Text, 
                    txtApellido.Text, crypto.GetAES256(txtDomicilio.Text), txtEmail.Text, Convert.ToInt32(txtTelefono.Text));
                     
                    cliente.ModificarCliente(cliente1);
                    MessageBox.Show("Se ha modificado el cliente");
                    ActualizarGrilla();
                    ActivarBotones(btnCancelar, "Modificar");

                    
                }
            }
            if(txtPanel2.Text == "Modo eliminar")
            {
                cliente.EliminarCliente(Convert.ToInt32(numericUpDown1.Value));
                MessageBox.Show("Se ha eliminado el usuario con el dni que se ingresó");
                ActualizarGrilla();
                ActivarBotones(btnCancelar, "Eliminar");
            }
            if (ObtenerCondiciones().Length > 5)
            {
                DataTable dt = negocios.ObtenerTabla("DNI, Nombre, Apellido, Domicilio, Email, Telefono", "Cliente", ObtenerCondiciones());
                foreach (DataRow dr in dt.Rows)
                {
                    dr[3] = crypto.DesencriptarAES256(dr[3].ToString());
                }
                dataGridView1.DataSource = dt;
                
            }
            else
            {
                DataTable dt = negocios.ObtenerTabla("DNI, Nombre, Apellido, Domicilio, Email, Telefono", "Cliente");
                foreach (DataRow dr in dt.Rows)
                {
                    dr[3] = crypto.DesencriptarAES256(dr[3].ToString());
                }
                dataGridView1.DataSource = dt;
            }

        }

        private void ActualizarGrilla()
        {
            DataTable dt = negocios.ObtenerTabla("DNI, Nombre, Apellido, Domicilio, Email, Telefono", "Cliente");
            foreach (DataRow dr in dt.Rows)
            {
                dr[3] = crypto.DesencriptarAES256(dr[3].ToString());
            }
            dataGridView1.DataSource = dt;
            ColorearInactivos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarGrilla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void Clientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
