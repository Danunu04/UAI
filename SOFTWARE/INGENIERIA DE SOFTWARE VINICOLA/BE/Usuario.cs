using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        public int DNI;
        public string Nombre;
        public string Apellido;
        public string Mail;
        public int NumTelefono;
        public string UserName;
        public string Password;
        public string Rol;

        public Usuario(int dni, string nombre, string apellido, string mail, int numtelefono, string username, string password, string rol) 
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            Mail = mail;
            NumTelefono = numtelefono;
            UserName = username;
            Password = password;
            Rol = rol;
        
        
        
        }
    }
}
