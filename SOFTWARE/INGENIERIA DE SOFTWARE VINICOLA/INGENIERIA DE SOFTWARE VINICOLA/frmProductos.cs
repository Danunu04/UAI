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
using BE;
using BLL;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Controls.Primitives;


namespace INGENIERIA_DE_SOFTWARE_VINICOLA
{
    public partial class frmProductos : Form, IObserver
    {
        BLLProductos productos = new BLLProductos();
        Negocios negocios = new Negocios();
        public frmProductos()
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

                c += "idProducto = " + numericUpDown1.Value.ToString() + " AND ";
            }
            if (checkBox2.Checked == true)
            {
                c += "Nombre = '" + txtNombre.Text + "AND";

            }
            if (checkBox3.Checked == true)
            {
                c += "Precio = '" + txtPrecio.Text + "' AND ";
            }
            if (checkBox4.Checked == true)
            {
                c += "Fecha = '" + dateTime.Value + "' AND ";
            }
            if (checkBox5.Checked == true)
            {
                c += "Stock = '" + txtCantidad.Text + "' AND ";
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
                    if (Convert.ToInt32(row.Cells[6].Value) == 1)
                    {

                        row.DefaultCellStyle.BackColor = Color.Red;


                    }
                }
                label5.Text = "Numero de vinos: " + cont;
            }
            catch (Exception ex) { }

        }

        private void ActivarBotones(Button b, string adm)
        
        {
            txtPanel2.Text = adm;
            btnAgregarProducto.Enabled = true;
            btnModificarProducto.Enabled = true;
            btnEliminarProducto.Enabled = true;
            btnCancelar2.Enabled = true;
            btnSalir2.Enabled = true;


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
                txtPrecio.Enabled = false;
                dateTime.Enabled = false;
                txtCantidad.Enabled = false;


            }
            else
            {
                txtNombre.Enabled = true;
                txtPrecio.Enabled = true;
                dateTime.Enabled = true;
                txtCantidad.Enabled = true;

            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            ActivarBotones(btnAgregarProducto, "Modo Añadir");
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            ActivarBotones(btnEliminarProducto, "Modo Eliminar");
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            ActivarBotones(btnModificarProducto, "Modo Modificar");
        }
        private bool ValidarCampos()
        {
            if (txtNombre.Text == "" || txtPrecio.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Porfavor llene los campos");
            }
            else if (negocios.RevisarDisponibilidad(numericUpDown1.Value.ToString(), "idProducto", "Producto") && txtPanel2.Text != "Modo modificar")
            {
                MessageBox.Show("El id ya está ingresado");
            }
            else
            {
                return true;
            }
            return false;
        }
        private void btnAplicar_Click(object sender, EventArgs e)
        {
           
            if(ValidarCampos() == true)
            {
                
                if(txtPanel2.Text == "Modo Añadir")
                {
                Producto producto = new Producto (Convert.ToInt32(numericUpDown1.Value), 
                txtNombre.Text,Convert.ToInt32(txtPrecio.Text),dateTime.Value,Convert.ToInt32(txtCantidad.Text));
               
                MessageBox.Show("El producto ha sido agregado");
                productos.AgregarProducto(producto);
                actualizarGrilla();
                ActivarBotones(btnCancelar2, "Añadir");
                    
                }
            }

            if (ValidarCampos() == true) 
            { 
                if (txtPanel2.Text == "Modo Modificar")
                {
                Producto producto = new Producto(Convert.ToInt32(numericUpDown1.Value), 
                txtNombre.Text, 
                Convert.ToInt32(txtPrecio.Text), 
                dateTime.Value, 
                Convert.ToInt32(txtCantidad.Text));
                
                productos.ModificarProducto(producto);
                MessageBox.Show("Se han modificado los datos de los productos");
                actualizarGrilla();
                ActivarBotones(btnCancelar2, "Modificar");

                }
            }
            if (txtPanel2.Text == "Modo Eliminar")
            {
                productos.EliminarProducto(Convert.ToInt32(numericUpDown1.Value));
                MessageBox.Show("Se ha eliminado el usuario con el id que se ingresó");
                actualizarGrilla();
                ActivarBotones(btnCancelar2, "Eliminar");
            }
            if (ObtenerCondiciones().Length > 5)
            {
                dataGridView1.DataSource = negocios.ObtenerTabla("idProducto, Nombre, Precio, Fecha, Stock", "Producto", ObtenerCondiciones());
            }
            else
            {
                dataGridView1.DataSource = negocios.ObtenerTabla("idProducto,Nombre, Precio, Fecha, Stock", "Producto");
            }
        
        }
      
        
        private void actualizarGrilla()
        {
            dataGridView1.DataSource = negocios.ObtenerTabla("idProducto, Nombre, Precio, Fecha, Stock", "Producto");
            ColorearInactivos();

        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            ActivarBotones(btnCancelar2, "Consultas");
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            actualizarGrilla();
        }

        private void btnSalir2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}