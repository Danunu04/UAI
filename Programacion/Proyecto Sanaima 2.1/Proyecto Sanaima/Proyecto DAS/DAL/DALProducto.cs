using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios;
using System.Data;

namespace DAL
{
    public class DALProducto
    {
        public List<CLSProducto> ListaProductos { get; set; }

        DALAccesoDatos DALDatos = new DALAccesoDatos();

        public DALProducto()
        {
            ListaProductos = new List<CLSProducto>();
        }



        public void GuardarProductoLista(CLSProducto producto)
        {
            ListaProductos.Add(producto);
        }



        public void GuardarProductoBDD(CLSProducto P)
        {
            string Consulta = "USE [Productos_Defectuosos] INSERT INTO Productos (Codigo,Responsable,Nombre,Costo,Gasto_Previo,Estado) VALUES (" + P.Codigo + "," + P.Responsable_Doc + ",'" + P.NombreProducto + "', " + P.Costo + "," + P.GastoPrevio + ",'" + P.Estado + "');";
            DALDatos.Ejecutar(Consulta);
        }



        public void EliminarProducto(CLSProducto producto)
        {
            ListaProductos.Remove(producto);
        }



        public CLSProducto BuscarProducto(int codigo)
        {
            CLSProducto Prod = new CLSProducto();

            ListaProductos.ForEach((CLSProducto Producto) => {
                if (Producto.Codigo == codigo)
                {
                    Prod = Producto;
                }
            });
            return Prod;
        }

        public List<CLSProducto> DevolverProductosDB()
        {
            List<CLSProducto> list = new List<CLSProducto>();

            DataTable DT = DALDatos.DevuelveUsuariosBD("SELECT * FROM Productos;");

            foreach (DataRow linea in DT.Rows)
            {
                CLSProducto prod = new CLSProducto(Convert.ToInt32(linea[0]), Convert.ToInt32(linea[1]), linea[2].ToString(),(float)Convert.ToInt32(linea[3]), (float)Convert.ToInt32(linea[4]), linea[5].ToString());
                list.Add(prod);
            }

            return list;
        }


    }
}
