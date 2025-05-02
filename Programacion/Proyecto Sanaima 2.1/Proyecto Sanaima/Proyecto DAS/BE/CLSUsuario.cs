using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CLSUsuario
    {

        public CLSUsuario(int Doc, string Nom, string Ape, DateTime FN,string Ma, string Con, string Ro,string Id,int Est)
        {
            Documento = Doc;
            Nombre = Nom;
            Apellido = Ape;
            Fecha_Nacimiento = FN;
            Mail = Ma;
            Contraseña = Con;
            Rol = Ro;
            Idioma = Id;
            Estado = Est;
        }

        public CLSUsuario()
        {
                
        }

        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Mail { get; set; }
        public string Contraseña { get; set; }
        public string Idioma { get; set; }
        public string Rol { get; set; }

        public int Estado { get; set; }
    }
}
