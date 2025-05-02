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
        public string Evento_ { get; set; }

        public int Criticidad { get; set; }


        public Evento(string nombreUsuario, DateTime fecha,string modulo,string evento_, int criticidad)
        {
            NombreUsuario = nombreUsuario;
            Fecha = DateTime.Now;
            Modulo = modulo;
            Evento_ = evento_;
            Criticidad = criticidad;
        }
    }
}
