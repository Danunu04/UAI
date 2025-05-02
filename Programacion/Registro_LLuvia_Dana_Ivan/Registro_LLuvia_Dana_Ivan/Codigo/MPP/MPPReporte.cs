using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Collections;
using System.Data.SqlClient;

namespace MPP
{
    public class MPPReporte
    {
        DALReporte DALR = new DALReporte();
       

        public void CargarDatos(int responsable, string localidad, double cantidad, DateTime fecha)
        {
            
            string Consulta = "INSERT INTO [Medicion ].[Informe]\r\n(\r\n    [Cantidad],\r\n    [IngenieroID],\r\n    [Fecha],\r\n    [Localidad]\r\n)\r\nVALUES\r\n( @Cantidad,       -- Aquí se usará la variable cantidad\r\n    @Responsables,   -- Aquí se usará la variable Responsables\r\n    @Fecha,         -- Aquí se usará la variable fecha\r\n    @Localidad      -- Aquí se usará la variable localidad\r\n);";
            ArrayList Parametros = new ArrayList();
            Parametros.Add(new SqlParameter("@Responsables", responsable));
            Parametros.Add(new SqlParameter("@Localidad", localidad));
            Parametros.Add(new SqlParameter("@Cantidad", cantidad));
            Parametros.Add(new SqlParameter("@Fecha", fecha));
            DALR.Escribir(Consulta, Parametros);
        }

        public List<BEReporte> ListarTodos()
        {

            List<BEReporte> registros = new List<BEReporte>();
            string Consulta = "[Medicion ].[Informe_SelAll]";
            DataTable DT = DALR.LeerTodo(Consulta, null);

            if (DT.Rows.Count > 0)
            {
                foreach (DataRow item in DT.Rows)
                {
                    //Los traaduce y x cada row los agrega a mi lista de objetos
                    double cantidad = Convert.ToDouble(item[2]);
                    int Responsables = Convert.ToInt32(item[4]);
                    DateTime fecha = Convert.ToDateTime(item[3]);
                    string localidad = Convert.ToString(item[1]);

                    BEReporte BER = new BEReporte(Responsables, cantidad, fecha, localidad);
                    registros.Add(BER);//Agregados

                }
                return registros;
            }
            else
            {
                return null;
            }
        }
    }
}
