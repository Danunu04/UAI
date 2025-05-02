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
    public partial class GenerarReporteFacutra : Form
    {
        Negocios negocios = new Negocios();
        CryptoManager crypto = new CryptoManager();
        public GenerarReporteFacutra()
        {
            InitializeComponent();
            //LanguageManager.ObtenerInstancia().Agregar(this);
        }
        //public void ActualizarIdioma()
        //{
        //    LanguageManager.ObtenerInstancia().CambiarIdiomaControles(this);

        //    DataTable dt = negocios.ObtenerTabla("IdFactura AS [Id de factura], CVV, MarcaTarjeta AS [Marca de tarjeta], TipoTarjeta AS [Tipo de tarjeta],MetodoPago AS [Metodo de pago],Precio AS [Precio total], Fecha, Factura.DNI, (Nombre + ' ' + Apellido) AS [Nombre de cliente], Domicilio AS Domicilio, Email, Telefono", "Factura INNER JOIN Cliente.DNI = Factura.DNI");
            
        //    dataGridView1.DataSource = dt;
        //}

        private void GenerarReporteFacutra_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
            DataTable dt = negocios.ObtenerTabla("IdFactura AS [Id de factura], CVV, MarcaTarjeta AS [Marca de tarjeta], TipoTarjeta AS [Tipo de tarjeta],MetodoPago AS [Metodo de pago],Precio AS [Precio total], Fecha, Factura.DNI, (Nombre + ' ' + Apellido) AS [Nombre de cliente], Domicilio AS Domicilio, Email, Telefono", "Factura INNER JOIN Cliente.DNI = Factura.DNI");
            dataGridView1.DataSource = dt;
        }

        private void GenerarReporteFacutra_VisibleChanged(object sender, EventArgs e)
        {
            DataTable dt = negocios.ObtenerTabla("IdFactura AS [Id de factura], CVV, MarcaTarjeta AS [Marca de tarjeta], TipoTarjeta AS [Tipo de tarjeta],MetodoPago AS [Metodo de pago],Precio AS [Precio total], Fecha, Factura.DNI, (Nombre + ' ' + Apellido) AS [Nombre de cliente], Domicilio AS Domicilio, Email, Telefono", "Factura INNER JOIN Cliente.DNI = Factura.DNI");
            dataGridView1.DataSource = dt;
        }

        private void GenerarReporteFacutra_Load(object sender, EventArgs e)
        {
            DataTable dt = negocios.ObtenerTabla("IdFactura AS [Id de factura], CVV, MarcaTarjeta AS [Marca de tarjeta], TipoTarjeta AS [Tipo de tarjeta],MetodoPago AS [Metodo de pago],Precio AS [Precio total], Fecha, Factura.DNI, (Nombre + ' ' + Apellido) AS [Nombre de cliente], Domicilio AS Domicilio, Email, Telefono", "Factura INNER JOIN Cliente.DNI = Factura.DNI");
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Selected = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
