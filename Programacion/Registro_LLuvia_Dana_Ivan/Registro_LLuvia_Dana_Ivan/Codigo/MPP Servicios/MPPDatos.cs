using DAL_servisios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP_Servicios
{
    public class MPPDatos
    {
        DALDatos DALD = new DALDatos();
        public double TraerCantidadCritica()
        {
            double Cantidad = 0;

            string consulta = "SELECT *     FROM [Medicion].[Informe]    WHERE [Cantidad] >= 15  AND    Fecha >= DATEADD(DAY, -3, GETDATE());";
            DataTable DT = DALD.Alerta(consulta, null);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow item in DT.Rows)
                {
                    //Los traaduce y x cada row los agrega a mi lista de objetos
                    Cantidad = Convert.ToDouble(item[3]);
                    int Responsables = Convert.ToInt32(item[1]);
                    DateTime fecha = Convert.ToDateTime(item[4]);
                    string localidad = Convert.ToString(item[2]);
                }
                return Cantidad;
            }
            else { return 0; }
        }
    }
}
