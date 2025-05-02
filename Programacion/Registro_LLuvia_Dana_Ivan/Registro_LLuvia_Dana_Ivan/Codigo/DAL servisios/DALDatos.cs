using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_servisios
{
    public class DALDatos
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=musica.ivansantisv.com,14433;Initial Catalog=RegistroLluvias;Persist Security Info=True;User ID=sa;Password=Password12345678;Encrypt=False");
        public SqlCommand cmd;
        public DataTable Alerta(string consulta, ArrayList parametros)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter DA;

            cmd = new SqlCommand(consulta, conn);
            cmd.CommandType = CommandType.Text;

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                DA = new SqlDataAdapter(cmd);

                if (parametros != null)
                {
                    foreach (SqlParameter dato in parametros)
                    {
                        cmd.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }

                DA.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw new Exception("Error SQL: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error general: " + ex.Message, ex);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return dt;
        }
    }
}
