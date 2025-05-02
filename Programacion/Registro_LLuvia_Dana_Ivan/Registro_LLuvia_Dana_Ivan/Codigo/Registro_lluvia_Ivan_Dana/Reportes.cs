using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using Microsoft.VisualBasic.Logging;
using SERVICIOS;

namespace Registro_lluvia_Ivan_Dana
{
    public partial class Reportes : Form
    {
        LanguajeManager LMG = new LanguajeManager();
        Idioma idiom = new Idioma();
        string Idi;
        public Reportes(string idi)
        {
            InitializeComponent();
            Idi = idi;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            //Alerta();
            Form F1 = this;
            LMG.RegistrarForm(F1); // Registrar el formulario actual
            idiom.AgregarObservador(LMG); // Agregar observador
            idiom.CambiarIdioma(Idi); // Cambiar idioma
            MessageBox.Show($"Idioma cambiado a: {Idi}");
        }
        BLLReporte BLLR = new BLLReporte();
        

        //private void Alerta()
        //{
        //    List<BEReporte> alerta = BLLR.crearAlerta();
        //    foreach (BEReporte registro in alerta)
        //    {
        //        if (alerta != null) // Verificas si la alerta fue creada correctamente
        //        {
        //            int Responsable = registro.Responsable;
        //            string Localidad = registro.Localidad;
        //            double Cantidad = registro.CantidadAgua;
        //            DateTime fecha = registro.FechaHora;
        //            string mensaje = $"Se registró una alerta en la cantidad de agua. Llovió {Cantidad} mm/h en {Localidad}. Recomendado no salir";
        //            Console.WriteLine(mensaje, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //        else
        //        {
        //            // Si no se crea la alerta, puedes manejar el error o simplemente ignorarlo
        //            Console.WriteLine("No se creó ninguna alerta.");
        //        }

        //    }
        //}

        private void CargarGrilla()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = BLLR.ListarTodo();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Tan;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TXTAlertas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
