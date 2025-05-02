using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS
{
    public abstract class Componente
    {
        public string Name;
        
        public abstract void Agregar(Componente componente);
        public abstract void Eliminar(Componente componente);
        public abstract bool TienePermiso(string Permiso);

    }
}
