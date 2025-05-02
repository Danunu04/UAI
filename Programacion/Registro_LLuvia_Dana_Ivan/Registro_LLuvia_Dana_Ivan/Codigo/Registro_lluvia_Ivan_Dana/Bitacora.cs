using BE;
using BLL;
using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text; // Asegúrate de usar este espacio de nombres para el Document correcto
using iTextSharp.text.pdf;
using SERVICIOS;



namespace Registro_lluvia_Ivan_Dana
{
    public partial class Bitacora : Form
    {
        BLLEventos BLLE = new BLLEventos();
        string idioma;
        public Bitacora(string lang)
        {
            InitializeComponent();
            idioma = lang;
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            CargarGridView();
            (this.MdiParent as Inicio)?.CambiarIdioma(idioma);
        }

        private void CargarGridView()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = BLLE.ListarTodo();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime FechaInicio = fechaDTP.Value; // Obtén el valor del DateTimePicker
            DateTime FechaFin = FechaFinal.Value;
            string Usuario = TXTOperacion.Text;
            string Modulo = TXTModulo.Text;
            string Operacion = TXTOperacion.Text;
            
            int Critic = (int)CDCritic.Value; // Obtén el valor del NumericUpDown y conviértelo a int
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = BLLE.ListarFiltrado(FechaInicio, FechaFin, Critic, Usuario, Modulo, Operacion);
        }

        private void BTNIntrigar_Click(object sender, EventArgs e)
        {
            try
            {
                string filepath = "C:\\Users\\Dana Perelmuter\\Desktop\\Registro_LLuvia_Dana_Ivan\\Registro_lluvia_Ivan_Dana";
                // Aquí indicas explícitamente que usas el Document de iTextSharp.text
                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 10f, 20f, 20f);

                // Archivo donde se guardará el PDF
                PdfWriter.GetInstance(pdfDoc, new FileStream(filepath, FileMode.Create));

                // Abre el documento PDF
                pdfDoc.Open();

                // Añade un título opcional
                pdfDoc.Add(new Paragraph("Reporte de DataGridView"));
                pdfDoc.Add(new Paragraph(" ")); // Línea en blanco

                // Crea una tabla en el PDF con el mismo número de columnas que el DataGridView
                PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount); // Usa el nombre real de tu DataGridView

                // Configura las celdas de la tabla en el PDF
                pdfTable.WidthPercentage = 100;

                // Añade los encabezados de las columnas del DataGridView a la tabla PDF
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    pdfTable.AddCell(cell);
                }

                // Añade las filas del DataGridView a la tabla PDF
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value?.ToString());
                    }
                }

                // Añade la tabla al documento PDF
                pdfDoc.Add(pdfTable);

                // Cierra el documento PDF
                pdfDoc.Close();

                MessageBox.Show("PDF generado con éxito!", "Exportar a PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
