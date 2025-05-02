using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using SERVICIOS;
using BE;
using iText.Kernel.Events;

namespace Registro_lluvia_Ivan_Dana
{
    public partial class Tareas : Form
    {
        string Idi;
        LanguajeManager LMG = new LanguajeManager();
        Idioma idiom = new Idioma();
        BEUsuario BEU = null;
        BLLEventos BLLE = new BLLEventos();
        Evento even = null;
        public Tareas(string idi, BEUsuario usuario)
        {
            InitializeComponent();
            Idi = idi;
            BEU = usuario;
        }

        private void Tareas_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            TXTFecha.Text = GetDate();
            Form F1 = this;
            LMG.RegistrarForm(F1); // Registrar el formulario actual
            idiom.AgregarObservador(LMG); // Agregar observador
            idiom.CambiarIdioma(Idi); // Cambiar idioma
            MessageBox.Show($"Idioma cambiado a: {Idi}");
        }
        BLLUsuario BLLU = new BLLUsuario();
        BLLReporte BLLR = new BLLReporte();
        private void CargarGrilla()
        {
            this.DTIngenieros.DataSource = null;
            this.DTIngenieros.ReadOnly = true;
            this.DTIngenieros.DataSource = BLLU.ListarRoles();
            this.DTIngenieros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DTIngenieros.AlternatingRowsDefaultCellStyle.BackColor = Color.Tan;
            this.DTCargas.DataSource = null;
            this.DTCargas.DataSource = BLLR.ListarTodo();
            this.DTCargas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DTCargas.AlternatingRowsDefaultCellStyle.BackColor = Color.Pink;
        }

        private string GetDate()
        {
            return DateTime.Today.ToString();
        }

        private void LBLCantidad_Click(object sender, EventArgs e)
        {

        }

        private void BTNCargar_Click(object sender, EventArgs e)
        {
            if (TXTCantidad.Text != "" && TXTLocalidad.Text != "")
            {
                string Localidad = TXTLocalidad.Text;
                int Responsable = Convert.ToInt32(TXTResponsable.Text);
                double cantidad = Convert.ToDouble(TXTCantidad.Text);
                DateTime fecha = Convert.ToDateTime(GetDate());
                BLLR.CargarDatos(Responsable, Localidad, cantidad, fecha);
                CargarGrilla();

                even = new Evento(BEU.Usuario.ToString(), DateTime.Now, "Carga de reportes", "Caega de reportes", 2);
                BLLE.RegistrarEvento(even);
            }
            else
            {
                MessageBox.Show("Faltan Datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void BTNAtreas_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
