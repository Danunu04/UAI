using BLL;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace INGENIERIA_DE_SOFTWARE_VINICOLA
{
    public partial class frmCarrito : Form, IObserver
    {
        frmInicio parent;
        public DataTable Productos = new DataTable();
        BLLFactura negociosFactura = new BLLFactura();
        Negocios negocios = new Negocios();

        public frmCarrito()
        {
            InitializeComponent();
            LanguageManager.ObtenerInstancia().Agregar(this);
        }
        public void ActualizarIdioma()
        {
            LanguageManager.ObtenerInstancia().CambiarIdiomaControles(this);
        }



        private void Seleccionar_Click_1(object sender, EventArgs e)
        {
            parent.formSeleccionarProductos.Show();

        }

        private void frmCarrito_Load(object sender, EventArgs e)
        {
            parent = this.MdiParent as frmInicio;   
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(dgvCarrito.Rows.Count == 0)
            {
                MessageBox.Show("Seleccione los productos para cobrar la venta");
            }
            else
            {
                parent.formCobrarVenta.Show();
            }
            
        }
            
            
        private void dgvCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              
                dgvCarrito.Rows[e.RowIndex].Selected = true;
           
            
            
            }catch (Exception)
            
            {

            }
        }

        private void frmCarrito_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dgvCarrito.Rows.Count == 0) 
            {
                MessageBox.Show("No se seleccionaron los productos para vender");
            }
            if (parent.fact.DNI == 0 || parent.fact.MetodoPago == null)
            {
                MessageBox.Show("No se ingresaron datos de pago");
            }
            else 
            { 
               
                parent.formGenerarFactura.Show();
            
            }

    }
    }
}
