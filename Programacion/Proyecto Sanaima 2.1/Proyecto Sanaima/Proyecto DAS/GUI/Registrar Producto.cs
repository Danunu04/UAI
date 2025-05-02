using BE;
using BLL;
using Microsoft.VisualBasic;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_DAS
{
    public partial class Registrar_Producto : Form
    {
        BLL.Bll Estado = new BLL.Bll();

        Observer_Idioma Controles = new Observer_Idioma();
        Idioma idi = new Idioma();
        public Registrar_Producto()
        {
            InitializeComponent();
            

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            CLSUsuario u = new CLSUsuario();
            u = Session_Manager.Instancia().GetUsuario();
            


            CLSProducto NuevoProducto = new CLSProducto();

            NuevoProducto.Codigo = Randomizador();
            NuevoProducto.Responsable_Doc = u.Documento;
            NuevoProducto.NombreProducto = TxtNombre.Text;
            NuevoProducto.Costo = (float) Convert.ToInt32(TxtCosto.Text);
            NuevoProducto.GastoPrevio = (float)Convert.ToInt32(TxtGastoPrevio.Text);
            NuevoProducto.Estado = Condicion((float)Convert.ToInt32(TxtGastoPrevio.Text));

                
                if (NuevoProducto.GastoPrevio >= 0 && NuevoProducto.GastoPrevio < 101)
                {
                    NuevoProducto.Estado = Estado.CambiarEstado(NuevoProducto.GastoPrevio);

                    Estado.GuardarProducto(NuevoProducto);

                }
                else
                {
                    throw new ArgumentException("Flaco pone un porcentaje.");
                }


            Limpiar();
           
            CargarDataGridView(); 
            TxtCodigo.Text =Convert.ToString(Randomizador());
        }

        private string Condicion(float Gasto)
        {
            if (Gasto >= 65)
            {
                return "Desechable";
            }
            else
            {
                return "Reacondicionable";
            }
        }

        private void Limpiar()
        {
            
            
            TxtNombre.Text = null;
            TxtCosto.Text = null;
            TxtGastoPrevio.Text = null;
            TxtEstado.Text = null;
        }


        private void Registrar_Producto_Load(object sender, EventArgs e)
        {
            //cambia el idioma
            Controles.RegistrarForm(this);
            idi.AgregarObservador(Controles);//?????xq
            if (Session_Manager.Instancia().GetUsuario() != null)
            {
                CLSUsuario usuario = Session_Manager.Instancia().GetUsuario();
                idi.CambiarIdioma(usuario.Idioma);

            }

            CargarDataGridView();
            
            CLSUsuario u = new CLSUsuario();
            u = Session_Manager.Instancia().GetUsuario();
            TxtResponsable.Text = u.Documento.ToString();
            TxtCodigo.Text = Convert.ToString(Randomizador());
        }



        private void CargarDataGridView()
        {
            List<CLSProducto> listaProductos = Estado.RecibirListaProductos();

            DgvProductos.Rows.Clear();


            foreach (var linea in listaProductos)
            {
                DgvProductos.Rows.Add(linea.Codigo, linea.Responsable_Doc, linea.NombreProducto, linea.Costo, linea.GastoPrevio, linea.Estado);
            }
        }


        private int Randomizador()
        {
            Random rnd = new Random();  
            int NumeroAleatorio = rnd.Next(1000, 9999);
            return NumeroAleatorio;
        }

        private void TxtGastoPrevio_Leave(object sender, EventArgs e)
        {
            TxtEstado.Text = Condicion((float)Convert.ToInt32( TxtGastoPrevio.Text));
        }

        private void DgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             //ailu
        }
    }
}
