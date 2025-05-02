using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto
    {
        public int IdProducto;
        public string Nombre;
        public int Precio;
        public DateTime Fecha;
        public int Stock;

        public Producto(int idproducto, string nombre, int precio, DateTime fecha, int stock) 
        { 
            IdProducto = idproducto;
            Nombre = nombre;
            Precio = precio;
            Fecha = fecha;
            Stock = stock;

        
        
        }
        public Producto() { }
    }
}
