using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS
{
    public class Evento
    {
        public int IdEvento { get; set; }
        public string NombreUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Modulo { get; set; }

        public string Operacion { get; set; }
        public int Criticidad { get; set; }


        public Evento(string nombreUsuario, DateTime fecha, string modulo, string operacion, int criticidad)
        {
            NombreUsuario = nombreUsuario;
            Fecha = fecha;
            Modulo = modulo;
            Operacion = operacion;
            Criticidad = criticidad;
        }
    }
}
