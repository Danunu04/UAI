using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS
{
    public class Patente: Componente
    {
        public string NombrePermiso { get; set; }
        public bool EsPerfil { get; set; }

        public Patente(string nombre, bool esPerfil) 
        {
            this.NombrePermiso = nombre;
        }

        public override void Agregar(Componente componente)
        {
            throw new NotImplementedException("No se puede agregar una patente dentro de otra patente");
        }

        public override void Eliminar(Componente componente)
        {
            throw new NotImplementedException("No se puede eliminar una patente dentro de una patente");
        }

        public override bool TienePermiso(string Permiso)
        {
            return EsPerfil && NombrePermiso == Permiso;
        }
    }
}
