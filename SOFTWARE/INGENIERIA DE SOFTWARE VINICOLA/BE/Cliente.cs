using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente
    {
        public int DNI;
        public string Nombre;
        public string Apellido;
        public string Domicilio;
        public string Email;
        public int Telefono;

        public Cliente(int dNI, string nombre, string apellido, string domicilio, string email, int telefono)
        {
            DNI = dNI;
            Nombre = nombre;
            Apellido = apellido;
            Domicilio = domicilio;
            Email = email;
            Telefono = telefono;
        }
    }
}
