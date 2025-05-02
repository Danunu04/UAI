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
    public partial class frmDespacharProductos : Form, IObserver
    {
        BLLEvento evento = new BLLEvento();
        public frmDespacharProductos()
        {
            InitializeComponent();
            LanguageManager.ObtenerInstancia().Agregar(this);
        }
        public void ActualizarIdioma()
        {
            LanguageManager.ObtenerInstancia().CambiarIdiomaControles(this);
        }
        private void btnDespachar_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("El producto ha sido despachado");
            evento.RegistrarEvento(new Evento(SessionManager.ObtenerInstancia().Usuario.UserName, DateTime.Now, "Despachar", 4));
        }

        private void frmDespacharProductos_Load(object sender, EventArgs e)
        {

        }

        private void frmDespacharProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();

            }
        }
    }
}
