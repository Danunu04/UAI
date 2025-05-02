using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFactura
    {
        Datos data = new Datos();
        DALUsuario DatosFactura = new DALUsuario();

        public void RegistrarFactura(Factura factura)
        {
            if(factura.MetodoPago == "Efectivo")
            {
                data.EjecutarComando("InsertarFacturaEfectivo", $"'{factura.Fecha.ToString("yyyy-MM-dd")}', {factura.Precio}, '{factura.MetodoPago}', {factura.DNI}");
            }
            else
            {
                data.EjecutarComando("InsertarFacturaTarjeta", $"'{factura.Fecha.ToString("yyyy-MM-dd")}', {factura.Precio},'{factura.MetodoPago}', '{factura.Banco}','{factura.MarcaTarjeta}','{factura.TipoTarjeta}', '{factura.NumTarjeta}', '{factura.CVV}', {factura.DNI}");
            }
        }

        public int ObtenerCodFactura()
        {
            return DatosFactura.ObtenerCodFactura();
        }
        public void RegistrarItem(int IdFactura, string IdProducto, int Cantidad)
        {
            data.EjecutarComando("RegistrarItem", $"{IdFactura}, '{IdProducto}' , {Cantidad}");
        }
            
            
    }
}
