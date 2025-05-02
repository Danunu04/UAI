using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using BE;
using BLL;
using SERVICIOS;

namespace INGENIERIA_DE_SOFTWARE_VINICOLA
{
    public partial class frmSeleccionarProductos : Form, IObserver
    {
        Negocios negocios = new Negocios();
        //BLLFactura negociosFactura = new BLLFactura();
        //CryptoManager Encriptar = new CryptoManager();
        frmInicio parent;
        public frmSeleccionarProductos()
        {
            InitializeComponent();
            LanguageManager.ObtenerInstancia().Agregar(this);
        }
        public void ActualizarIdioma()
        {
            LanguageManager.ObtenerInstancia().CambiarIdiomaControles(this);
        }
        private void frmSeleccionarProductos_VisibleChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocios.ObtenerTabla("*", "Producto");

            dataGridView2.Rows.Clear();
        }
        private void frmSeleccionarProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
           if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool vinoSeleccionado = false;
            try
            {
                foreach(DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[0].Value.ToString()== dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("El vino se ha seleccionado");
                        vinoSeleccionado = true;

                    }
                }
            
            if(vinoSeleccionado == false)
            {
                string cantidad = Interaction.InputBox("Ingrese la cantidad de ejemplares que desea", "Cantidad");
                bool validarNumero = cantidad.All(char.IsDigit);
                if (cantidad.Length >= 11)
                {
                    cantidad = cantidad.Substring(0, 11);
                }
                if(validarNumero == false || cantidad == "" || Convert.ToInt64(cantidad) > 2147483647)
                {
                    MessageBox.Show("El numero ingresado no es valido");
                }
                else if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value) < Convert.ToInt32(cantidad))                 
                {
                        MessageBox.Show("La cantidad ingresada es mayor al stock disponible del vino seleccionado");
                }
                else
                {
                        dataGridView2.Rows.Add(dataGridView1.Rows[e.RowIndex].Cells[0].Value, dataGridView1.Rows[e.RowIndex].Cells[1].Value, dataGridView1.Rows[e.RowIndex].Cells[2].Value, dataGridView1.Rows[e.RowIndex].Cells[3].Value, cantidad);
                        ActualizarPrecio();
                }

            }
                dataGridView1.Rows[e.RowIndex].Selected = true;
        
            }
            catch(Exception) 
            { 
            
            
            
            }


        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MessageBox.Show($"Se ha quitado el vino {dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString()}");
                dataGridView2.Rows.Remove(dataGridView2.Rows[e.RowIndex]);
                ActualizarPrecio();

                dataGridView1.Rows[e.RowIndex].Selected = true;

            }catch(Exception)
            {

            }
        }

        private void ActualizarPrecio()
        {
            int precio = 0;

            try
            {
                foreach(DataGridViewRow dr in dataGridView2.Rows)
                {
                    precio += (Convert.ToInt32(dr.Cells[2].Value) * Convert.ToInt32(dr.Cells[4].Value));
                }
            }catch(Exception ex)
            {

            }
            label3.Text = precio.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(dataGridView2.RowCount == 0)
            {
                MessageBox.Show("No se seleccionaron los productos a vender");
            }
            else
            {
                parent.formCarrito.dgvCarrito.DataSource = null;
                parent.formCarrito.Productos = new DataTable();

                foreach(DataGridViewColumn column in dataGridView2.Columns)
                {
                    Type columnType = column.ValueType ?? typeof(string);
                    parent.formCarrito.Productos.Columns.Add(column.HeaderText, columnType);
                }
                foreach(DataGridViewRow row in dataGridView2.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DataRow dataRow = parent.formCarrito.Productos.NewRow();

                        foreach(DataGridViewCell cell in row.Cells)
                        {
                            object cellValue = cell.Value ?? DBNull.Value;
                            dataRow[cell.ColumnIndex] = Convert.ChangeType(cellValue, parent.formCarrito.Productos.Columns[cell.ColumnIndex].DataType);
                        }

                        parent.formCarrito.Productos.Rows.Add(dataRow);
                    }
                }
                parent.formCarrito.dgvCarrito.DataSource = parent.formCarrito.Productos.Copy();

                this.Hide();
                dataGridView2.Rows.Clear();

                MessageBox.Show("Productos seleccionados correctamente");
            }
           
        }

        private void frmSeleccionarProductos_Load(object sender, EventArgs e)
        {
            parent = this.MdiParent as frmInicio;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

