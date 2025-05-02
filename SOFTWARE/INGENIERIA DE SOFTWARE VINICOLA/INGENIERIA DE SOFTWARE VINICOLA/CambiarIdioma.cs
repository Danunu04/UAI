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
                LanguageManager.ObtenerInstancia().IdiomaActual = box.Text;
            }

            MessageBox.Show("Se cambió el idioma correctamente a: " + box.Text);

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
    }
}
