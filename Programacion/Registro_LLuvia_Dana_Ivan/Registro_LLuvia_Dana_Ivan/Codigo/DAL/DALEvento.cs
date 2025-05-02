using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    
    public class DALEvento
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=musica.ivansantisv.com,14433;Initial Catalog=RegistroLluvias;Persist Security Info=True;User ID=sa;Password=Password12345678;Encrypt=False");
        public SqlCommand cmd;

        
        public DataTable Buscar(string consulta, ArrayList parametros)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter DA;
            cmd = new SqlCommand(consulta, conn);
            cmd.CommandType = CommandType.Text;

            try
            {
                if (parametros != null)
                {
                    foreach (SqlParameter dato in parametros)
                    {
                        cmd.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                DA = new SqlDataAdapter(cmd);
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

        

        public bool Escribir(string consulta, ArrayList parametros)
        {
            cmd = new SqlCommand(consulta, conn);
            cmd.CommandType = CommandType.Text;

            try
            {
                // Abro la conexión si no está abierta
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                // Si hay parámetros, los agrego al comando
                if (parametros != null)
                {
                    foreach (SqlParameter dato in parametros)
                    {
                        cmd.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }

                // Ejecutar el comando que no devuelve resultados
                int filasAfectadas = cmd.ExecuteNonQuery();

                // Si afectó filas, la operación fue exitosa
                return filasAfectadas > 0;
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
                // Cierro la conexión si estaba abierta
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public DataTable LeerTodo(string consulta, ArrayList parametros)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter DA;

            cmd = new SqlCommand(consulta, conn);
            cmd.CommandType = CommandType.Text;

            try
            {
                // Abro la conexión si no está abierta
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                DA = new SqlDataAdapter(cmd);

                // Si hay parámetros, los agrego al comando
                if (parametros != null)
                {
                    foreach (SqlParameter dato in parametros)
                    {
                        cmd.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }

                // Lleno el DataTable con los resultados
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
                // Cierro la conexión si estaba abierta
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return dt;
        }
    }
}
