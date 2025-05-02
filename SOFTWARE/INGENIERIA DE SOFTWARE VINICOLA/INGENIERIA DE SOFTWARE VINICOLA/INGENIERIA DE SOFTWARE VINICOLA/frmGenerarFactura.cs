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
    public partial class frmGenerarFactura : Form, IObserver
    {

        Negocios negocios = new Negocios();
        BLLEvento evento = new BLLEvento();
        BLLFactura NegociosFactura = new BLLFactura();
        public DataTable Productos = new DataTable();
        frmInicio parent;
        
        public frmGenerarFactura()
        {
            InitializeComponent();
            LanguageManager.ObtenerInstancia().Agregar(this);
        }
        public void ActualizarIdioma()
        {
            LanguageManager.ObtenerInstancia().CambiarIdiomaControles(this);
        }
        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            parent.fact.Fecha = DateTime.Now;

            NegociosFactura.RegistrarFactura(parent.fact);

            int IdFactura = NegociosFactura.ObtenerCodFactura();

            foreach(DataRow dr in Productos.Rows)
            {
                NegociosFactura.RegistrarItem(IdFactura, dr.Field<string>(0), Convert.ToInt32(dr.Field<string>(4)));
            }
            MessageBox.Show("Se generó la factura de la venta");
            
            ActualizarGrilla();
            evento.RegistrarEvento(new Evento(SessionManager.ObtenerInstancia().Usuario.UserName, DateTime.Now, "Factura", 3));
            VaciarCampos();
            
        }

        void VaciarCampos()
        {
            parent.formSeleccionarProductos.Hide();
            parent.FormRegistrarCliente.Hide();
            parent.formCobrarVenta.Hide();  

            parent.formCarrito.label1.Text = "-";
            parent.formCarrito.label2.Text = "-";
            parent.formCarrito.label3.Text = "-";
            parent.formCarrito.label4.Text = "-";
            parent.formCarrito.label5.Text = "-";
            parent.formCarrito.label6.Text = "-";
            parent.formCarrito.label7.Text = "-";
            parent.formCarrito.label8.Text = "-";
            try
            {
                dgvGenerarFactura.Rows.Clear();
            }
            catch(Exception)
            {
                Productos.Clear();
                parent.fact = new BE.Factura();
            }
        
        }

        private void frmGenerarFactura_Load(object sender, EventArgs e)
        {
            parent = this.MdiParent as frmInicio;
        }

        private void frmGenerarFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        

        private void frmGenerarFactura_VisibleChanged(object sender, EventArgs e)
        {
            //dgvGenerarFactura.DataSource = negocios.ObtenerTabla("*", "Factura");

            //parent.formDespacharProductos.dgvDespacharProductos.Rows.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            dgvGenerarFactura.DataSource = negocios.ObtenerTabla("TOP 1 *", "Factura ORDER BY IdFactura DESC");
            
            
        }
        private void DespacharVino_Click(object sender, EventArgs e)
        {
            if(dgvGenerarFactura.Rows.Count == 0)
            {
                MessageBox.Show("No hay factura para despachar");

            }
            else 
            { 
            parent.formDespacharProductos.Show();
            parent.formDespacharProductos.dgvDespacharProductos.DataSource = null;
            DataTable Productos = new DataTable();
            

            foreach (DataGridViewColumn column in dgvGenerarFactura.Columns)
            {
                Type columnType = column.ValueType ?? typeof(string);
                Productos.Columns.Add(column.HeaderText, columnType);
            }
            foreach (DataGridViewRow row in dgvGenerarFactura.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dataRow = Productos.NewRow();

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        object cellValue = cell.Value ?? DBNull.Value;
                        dataRow[cell.ColumnIndex] = Convert.ChangeType(cellValue, Productos.Columns[cell.ColumnIndex].DataType);
                    }

                  Productos.Rows.Add(dataRow);
                }
            }
            parent.formDespacharProductos.dgvDespacharProductos.DataSource = Productos.Copy();

            

            

            
            }
        }
    }
}
