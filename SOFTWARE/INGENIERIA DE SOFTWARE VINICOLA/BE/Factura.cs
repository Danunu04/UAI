using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Factura
    {
        public int IdFactura;
        public string CVV;
        public string MarcaTarjeta;
        public string MetodoPago;
        public string NumTarjeta;
        public string TipoTarjeta;
        public int Precio;
        public int DNI;
        public string Banco;
        public DateTime Fecha;

       
       
        public Factura(int idfactura, string cvv, string marcaTarjeta,string metodoPago, string numTarjeta, string tipoTarjeta, int precio, int dni, string banco, DateTime fecha)
        {
            IdFactura = idfactura;
            CVV = cvv;
            MarcaTarjeta = marcaTarjeta;
            MetodoPago = metodoPago;
            NumTarjeta = numTarjeta;
            TipoTarjeta = tipoTarjeta;
            Precio = precio;
            DNI = dni;
            Banco = banco;
            Fecha = fecha;

        }
        public Factura()
        {

        }


    }
}
