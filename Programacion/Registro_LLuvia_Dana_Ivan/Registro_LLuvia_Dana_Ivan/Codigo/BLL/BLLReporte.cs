using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;

namespace BLL
{
    public class BLLReporte
    {
        MPPReporte MPPR = new MPPReporte();

        public void CargarDatos(int responsable, string localidad, double cantidad, DateTime fecha)
        {

            MPPR.CargarDatos(responsable, localidad, cantidad, fecha);
        }


        public object ListarTodo()
        {
            return MPPR.ListarTodos();
        }
    }
}
