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

namespace INGENIERIA_DE_SOFTWARE_VINICOLA
{
    public partial class CambiarIdioma : Form, IObserver
    {
        public CambiarIdioma()
        {
            InitializeComponent();
            LanguageManager.ObtenerInstancia().Agregar(this);
        }
        public void ActualizarIdioma()
        {
            LanguageManager.ObtenerInstancia().CambiarIdiomaControles(this);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (box.Text != "")
            {
                SessionManager.ObtenerInstancia().IdiomaActual = box.Text;
                MessageBox.Show(LanguageManager.ObtenerInstancia().ObtenerTexto("CambiarIdioma.Etiquetas.IdiomaCambiado") + box.Text);
                this.Hide();
            }
            else
            {
                MessageBox.Show(LanguageManager.ObtenerInstancia().ObtenerTexto("FRMCambiarIdioma.Etiquetas.SeleccionarIdioma"));
            }

            //MessageBox.Show("Se cambió el idioma correctamente a: " + box.Text);

            this.Hide();
        }

        private void CambiarIdioma_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void CambiarIdioma_Load(object sender, EventArgs e)
        {

        }

        private void CambiarIdioma_VisibleChanged(object sender, EventArgs e)
        {
            box.SelectedItem = null;
        }
    }
}
