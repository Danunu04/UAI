using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPerfil
    {
        Datos Data = new Datos();

        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=VINICOLA;Integrated Security=True");

        public bool VerificarTipo(string Nombre)
        {
            DataTable dt = Data.LlenarTabla("Nombre, Tipo", "Familia");

            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == Nombre)
                {
                    return Convert.ToBoolean(row[1].ToString());
                }
            }
            return false;
        }
    }
}

