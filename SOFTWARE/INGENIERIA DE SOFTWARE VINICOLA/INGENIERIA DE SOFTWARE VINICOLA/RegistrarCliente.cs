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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INGENIERIA_DE_SOFTWARE_VINICOLA
{
    public partial class RegistrarCliente : Form, IObserver
    {
        Negocios negocios = new Negocios();
        BLLCliente NegociosCliente = new BLLCliente();
        BLLEvento evento = new BLLEvento();
        public RegistrarCliente()
        {
            InitializeComponent();
            LanguageManager.ObtenerInstancia().Agregar(this);
        }
        public void ActualizarIdioma()
        {
            LanguageManager.ObtenerInstancia().CambiarIdiomaControles(this);
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            MailAddress Correo;
            bool MailValido = false;
         

            if (textBox3.Text != "")
            {
                try
                {
                    Correo = new MailAddress(textBox4.Text);
                    MailValido = true;
                }
                catch (FormatException) { }
            }

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else if (negocios.RevisarDisponibilidad(numericUpDown1.Value.ToString(), "DNI", "Cliente"))
            {
                MessageBox.Show("DNI ya se encuentra registrado");
            }
            else if (MailValido == false)
            {
                MessageBox.Show("El correo ingresado no es válido");
            }
            else if (negocios.RevisarDisponibilidad(textBox4.Text, "Email", "Cliente"))
            {
                MessageBox.Show("El correo ingresado ya se encuentra en uso");
            }
      
            else
            {
                Cliente cliente = new Cliente(Convert.ToInt32(numericUpDown1.Value), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text));

                NegociosCliente.AgregarCliente(cliente);

                MessageBox.Show("Cliente registrado");
                evento.RegistrarEvento(new Evento(SessionManager.ObtenerInstancia().Usuario.UserName, DateTime.Now, "Clientes", "Cliente registrado", 6));
                this.Hide();

                numericUpDown1.Value = numericUpDown1.Minimum;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void RegistrarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void RegistrarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
