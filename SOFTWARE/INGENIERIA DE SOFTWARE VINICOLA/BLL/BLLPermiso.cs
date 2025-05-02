using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLPermiso
    {
        DALPerfil DataPerfil = new DALPerfil();
        Datos Data = new Datos();

        public DataTable ObtenerPermisos()
        {
            return Data.LlenarTabla("CodPermiso, Nombre", "Permiso");
        }
    }
}
