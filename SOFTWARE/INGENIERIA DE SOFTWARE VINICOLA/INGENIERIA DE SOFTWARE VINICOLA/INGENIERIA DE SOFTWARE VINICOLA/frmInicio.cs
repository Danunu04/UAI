using BE;
using BLL;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INGENIERIA_DE_SOFTWARE_VINICOLA
{
    public partial class frmInicio : Form, IObserver
    {
       public frmSeleccionarProductos formSeleccionarProductos = new frmSeleccionarProductos();
       public frmCobrarVenta formCobrarVenta = new frmCobrarVenta();
       public frmCarrito formCarrito = new frmCarrito();
       public frmDespacharProductos formDespacharProductos = new frmDespacharProductos();
       public frmProductos formProductos = new frmProductos();
       public frmGenerarFactura formGenerarFactura = new frmGenerarFactura();
       public Clientes Formclientes = new Clientes();
       public CambiarContraseña formCambiarContraseña = new CambiarContraseña();
       public GestionUsuarios formGestionUsuarios = new GestionUsuarios();
       public Login login = new Login();
       public RegistrarCliente FormRegistrarCliente = new RegistrarCliente();
       public CambiarIdioma FormCambiarIdioma = new CambiarIdioma();

       public Factura fact = new Factura();
        
        public Producto pro = new Producto();
        public frmInicio()
        {
            InitializeComponent();
            LanguageManager.ObtenerInstancia().Agregar(this);
        }
        public void ActualizarIdioma()
        {
            LanguageManager.ObtenerInstancia().CambiarIdiomaControles(this);
        }
        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void carritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCarrito.MdiParent = this;
            formCarrito.Show();
            formCobrarVenta.MdiParent = this;
            formSeleccionarProductos.MdiParent = this;
            formGenerarFactura.MdiParent = this;
            FormRegistrarCliente.MdiParent = this;
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formclientes.MdiParent = this;
            Formclientes.Show();

            
        }
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos.MdiParent = this;
            formProductos.Show();

        }
        private void gestionUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formGestionUsuarios.MdiParent = this;
            formGestionUsuarios.Show();
        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.MdiParent = this;
            login.Show();
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCambiarContraseña.MdiParent = this;
            formCambiarContraseña.Show();

        }
        




        private void cerrarSesiónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas seguro de cerrar sesion?", "Confirmar cierre de sesión", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SessionManager.ObtenerInstancia().CerrarSesion();
                modificarMenu();
                
            }
            
        }
        private void modificarMenu() 
        {
            iniciarSesiónToolStripMenuItem.Visible = true;
            cerrarSesiónToolStripMenuItem.Visible = false;
            cambiarClaveToolStripMenuItem.Visible = false;
            cambiarIdiomaToolStripMenuItem.Visible = false;
            clientesToolStripMenuItem.Visible = false;
            productosToolStripMenuItem.Visible = false;
            gestionUsuariosToolStripMenuItem.Visible = false;
            gestionPerfilesToolStripMenuItem.Visible = false;
            carritoToolStripMenuItem.Visible = false;
            reporte1ToolStripMenuItem.Visible = false;
        }
        

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
          
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cambiarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCambiarIdioma.MdiParent = this;
            FormCambiarIdioma.Show();
        }

        private void menuTitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
