using BE;
using BLL;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INGENIERIA_DE_SOFTWARE_VINICOLA
{
    public partial class frmCobrarVenta : Form, IObserver
    {
        Negocios negocios = new Negocios();
        BLLEvento evento = new BLLEvento();
        BLLFactura NegociosFactura = new BLLFactura();
        CryptoManager Encriptar = new CryptoManager();
        frmInicio parent;
        public frmCobrarVenta()
        {
            InitializeComponent();
            LanguageManager.ObtenerInstancia().Agregar(this);
        }

        public void ActualizarIdioma()
        {
            LanguageManager.ObtenerInstancia().CambiarIdiomaControles(this);
        }

        private void btnCobrarVenta_Click(object sender, EventArgs e)
        {
           

            if (negocios.RevisarDisponibilidad(numericUpDown1.Value.ToString(), "DNI", "Cliente")== false)
            {
                MessageBox.Show("DNI ingresado no existe, a continuación se presentará un formulario para el registro del cliente. Ingrese los datos solicitados.");

                parent.FormRegistrarCliente.Show();
            }
            
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Elija un medio de pago");

            }
            else if(comboBox1.Text != "Efectivo" && (textBox1.Text == "" || textBox2.Text == ""|| textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == ""))
            {
                MessageBox.Show("Llene todos los campos");
            }
            else if(textBox4.Text.All(char.IsDigit)== false && comboBox1.Text != "Efectivo")
            {
                MessageBox.Show("El numero de tarjeta solo puede contener numeros");
            }
            else if(textBox4.Text.Length < 16 && comboBox1.Text != "Efectivo")
            {
                MessageBox.Show("El numero de tarjeta debe tener 16 digitos");
            }
            else if(textBox5.Text.All(char.IsDigit) == false && comboBox1.Text != "Efectivo")
            {
                MessageBox.Show("El CVV solo puede tener 3 digitos");

            }
            else
            {
                parent.fact.DNI = Convert.ToInt32(numericUpDown1.Value);
                parent.fact.MetodoPago = comboBox1.Text;

                parent.formCarrito.label1.Text = numericUpDown1.Value.ToString();

                parent.formCarrito.label2.Text = comboBox1.Text;

                if(comboBox1.Text != "Efectivo")
                {
                    parent.fact.Banco = textBox1.Text;
                    parent.fact.MarcaTarjeta = textBox2.Text;
                    parent.fact.TipoTarjeta = textBox3.Text;
                    parent.fact.NumTarjeta = textBox4.Text;
                    parent.fact.CVV = textBox5.Text;

                    parent.formCarrito.label3.Text =  textBox1.Text;
                    parent.formCarrito.label4.Text =  textBox2.Text;
                    parent.formCarrito.label5.Text =  textBox3.Text;
                    parent.formCarrito.label6.Text =  textBox4.Text;
                    parent.formCarrito.label7.Text =  textBox5.Text;
                }
                else
                {

                    parent.formCarrito.label3.Text =  "-";
                    parent.formCarrito.label4.Text =  "-";
                    parent.formCarrito.label5.Text =  "-";
                    parent.formCarrito.label6.Text =  "-";
                    parent.formCarrito.label7.Text =  "-";
                }

                VaciarCampos();
                MessageBox.Show("Cobro realizado");
                evento.RegistrarEvento(new Evento(SessionManager.ObtenerInstancia().Usuario.UserName, DateTime.Now, "Venta cobrada", 5));
                this.Hide();
                
            }

            
        }

        private void VaciarCampos()
        {
            numericUpDown1.Value = numericUpDown1.Minimum;
            comboBox1.SelectedItem = null;
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Enabled = false;
            }
        }

        private void frmCobrarVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing) 
            {
                e.Cancel = true;
                Hide();
            
            }
        }

        private void frmCobrarVenta_VisibleChanged(object sender, EventArgs e)
        {
            VaciarCampos();
        }

        private void frmCobrarVenta_Load(object sender, EventArgs e)
        {
            parent = this.MdiParent as frmInicio;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Efectivo")
            {
                foreach(TextBox tb in this.Controls.OfType<TextBox>())
                {
                    tb.Enabled=false;
                }  
            }
            else
            {
                foreach(TextBox tb in this.Controls.OfType<TextBox>())
                {
                    tb.Enabled=true;
                }
            }
        }
    }



}
