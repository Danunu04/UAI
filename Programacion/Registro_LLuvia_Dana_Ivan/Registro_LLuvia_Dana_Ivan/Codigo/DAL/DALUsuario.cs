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
    public class DALUsuario
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=musica.ivansantisv.com,14433;Initial Catalog=RegistroLluvias;Persist Security Info=True;User ID=sa;Password=Password12345678;Encrypt=False");
        public SqlCommand cmd;
        public DataTable Burcar(string consulta, ArrayList parametros)
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

        public int Set (string consulta, ArrayList parametros)
        {
            int filasAfectadas = 0; // Guardará cuántas filas fueron afectadas
            using (SqlConnection conn = new SqlConnection(@"Data Source=musica.ivansantisv.com,14433;Initial Catalog=RegistroLluvias;Persist Security Info=True;User ID=sa;Password=Password12345678;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        // Agregar los parámetros si los hay
                        if (parametros != null)
                        {
                            foreach (SqlParameter parametro in parametros)
                            {
                                cmd.Parameters.AddWithValue(parametro.ParameterName, parametro.Value);
                            }
                        }

                        // Abrir conexión si no está abierta
                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }

                        // Ejecutar el comando y capturar cuántas filas se afectaron
                        filasAfectadas = cmd.ExecuteNonQuery();
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
                        // Asegurarse de cerrar la conexión
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }

            return filasAfectadas; // Devolver cuántas filas fueron afectadas
        }
    }
}
