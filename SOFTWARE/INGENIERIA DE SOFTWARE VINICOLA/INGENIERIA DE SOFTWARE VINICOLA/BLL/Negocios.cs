using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Data;

namespace BLL
{
    public class Negocios
    {
        Datos data = new Datos();

        public bool RevisarDisponibilidad(string Dato, string Columna, string Tabla)
        {
            return data.RevisarDisponibilidad(Dato, Columna, Tabla);
        }
        public DataTable ObtenerTabla(string columna, string tabla) 
        { 
            DataTable dt = data.LlenarTabla(columna, tabla);
            return dt;
        }
        public DataTable ObtenerTabla(string columna, string tabla, string condicion)
        {
            DataTable dt = data.LlenarTabla(columna, tabla, condicion);
            return dt;
        }
    }
}
