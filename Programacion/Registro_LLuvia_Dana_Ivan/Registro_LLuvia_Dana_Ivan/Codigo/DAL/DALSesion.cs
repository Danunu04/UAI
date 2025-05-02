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
    public class DALSesion
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

        public void EjecutarConsulta(string consulta, ArrayList parametros)
        {
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

                cmd.ExecuteNonQuery();
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
        }

        public void TraerID(string consulta, ArrayList parametros)
        {
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

                // No se utiliza SqlDataAdapter ni DataTable ya que es para traer un ID
                cmd.ExecuteScalar();
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
        }

        public void Cargar(string consulta, ArrayList parametros)
        {
            cmd = new SqlCommand(consulta, conn);
            cmd.CommandType = CommandType.Text;

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                if (parametros != null)
                {
                    foreach (SqlParameter dato in parametros)
                    {
                        cmd.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }

                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    throw new Exception("La consulta no afectó a ninguna fila.");
                }
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
        }

        public DataTable BuscarPermisos(string consulta, ArrayList parametros)
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
    }
}

