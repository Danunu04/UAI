using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLProductos
    {
        Datos data = new Datos();
        
        public void AgregarProducto(Producto producto)
        {
            data.EjecutarComando("AgregarProducto", $"{producto.IdProducto}, '{producto.Nombre}','{producto.Precio}', '{producto.Fecha.ToString("yyyy-MM-dd")}', '{producto.Stock}'");
        }
        public void ModificarProducto(Producto producto)
        {
            data.EjecutarComando("ModificarProducto", $"{producto.IdProducto}, '{producto.Nombre}','{producto.Precio}', '{producto.Fecha.ToString("yyyy-MM-dd")}', '{producto.Stock}'");
        }
        public void EliminarProducto(int idProducto)
        {
            data.EjecutarComando("EliminarProducto", $"'{idProducto}'");
        }
    }
}
