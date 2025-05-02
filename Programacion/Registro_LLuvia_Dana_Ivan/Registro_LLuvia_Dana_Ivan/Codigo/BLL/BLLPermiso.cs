using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;
using BE;

namespace BLL
{
    public class BLLPermiso
    {
        MPPUsuario MPPU = new MPPUsuario();
        public List<BEPermisos> ObtenerPermisos(int usuarioID)
        {
            return MPPU.BuscarPermisos(usuarioID);
        }
    }
}
