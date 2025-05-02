using SERVICIOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BE
{
    public class BEUsuario
    {
        
        public BEUsuario(string N, string A, int D, string U, string C, bool E, string R)
        {
            Nombre = N;
            Apellido = A;
            Dni = D;
            Usuario = U;
            Contraseña = C;
            Estado = E;
            Rol = R;
        }
        
        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _Apellido;
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
        private int _Dni;
        public int Dni
        {
            get { return _Dni; }
            set { _Dni = value; }
        }

        private string _Usuario;
        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        private string _Contraseña;
        public string Contraseña
        {
            get { return _Contraseña; }
            set { _Contraseña = value; }
        }

        private bool _Estado;
        public bool Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
        private string _Rol;
        public string Rol
        {
            get { return _Rol; }
            set { _Rol = value; }
        }
        public List<BEPermisos> Permisos = new List<BEPermisos>();

    }
}
