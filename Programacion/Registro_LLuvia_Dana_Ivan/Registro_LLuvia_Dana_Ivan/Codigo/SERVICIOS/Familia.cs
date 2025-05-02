using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS
{
    public class Familia: Componente
    {
        public List<Componente> Permisos = new List<Componente>();

        public Familia(string nombre)
        {
            this.Name = nombre;
        }
        public override void Agregar(Componente componente)
        {
            Permisos.Add(componente);
            //Agregar en la bd
        }

        public override void Eliminar(Componente componente)
        {
            Permisos.Remove(componente);
            //eliminar en la bd
        }

        public override bool TienePermiso(string Permiso)
        {
            return Permisos.All(p => p.TienePermiso(Permiso));
        }
    }
}
