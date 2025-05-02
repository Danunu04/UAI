using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEPermisos
    {

        public BEPermisos(string N, bool I)
        {
            Nombre = N;
            IsPerfil = I;
        }
        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private bool _IsPerfil;
        public bool IsPerfil
        {
            get { return _IsPerfil; }
            set { _IsPerfil = value; }
        }
    }
}
