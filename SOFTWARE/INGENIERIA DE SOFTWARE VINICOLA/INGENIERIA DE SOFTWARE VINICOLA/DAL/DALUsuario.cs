using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DALUsuario
    {
        Datos datos = new Datos();

        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=VINICOLA;Integrated Security=True");

        public Usuario RevisarLogin(string username, string password)
        {
            Usuario user = null;
            DataTable dt = datos.LlenarTabla("*", "Usuario");

            foreach (DataRow row in dt.Rows) 
            { 
                if(row[5].ToString() == username && row[6].ToString() == password)
                {
                    user = new Usuario(Convert.ToInt32(row[0]), row[1].ToString(), row[2].ToString(), row[3].ToString(), (Convert.ToInt32(row[4])), row[5].ToString(), row[6].ToString(), row[7].ToString());

                }
            
            }
            return user;
        }
      
    
    public bool RevisarSanciones(string Username, string columna)
    {
        DataTable dt = datos.LlenarTabla(columna, "Usuario");
        foreach (DataRow row in dt.Rows)
        {
            if (row[0].ToString() == Username)
            {
                return Convert.ToBoolean(row[1]);
            }
        }
        return false;
    }
    public bool RevisarSanciones(string Username, int num, string columna)
    {
            DataTable dt = datos.LlenarTabla(columna, "Usuario");
            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == Username && Convert.ToInt32(row[1]) >= num ) 
                {
                    return true; 
                
                
                }
            }
            return false;

    }
    public bool RevisarSanciones(int num, string columnas)
    {
            DataTable dt = datos.LlenarTabla(columnas, "Usuario");
            foreach(DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row[0]) == num)
                {
                    return Convert.ToBoolean(row[1]);
                }
            }
            return false;
    }
        public void ActualizarContraseña(int dni, string nuevaContraseña)
        {
            try
            {
                string query = "UPDATE Usuario SET Password = @nuevaContraseña WHERE DNI= @dni";
                SqlCommand cmd = new SqlCommand(query, datos.con);
                cmd.Parameters.AddWithValue("@nuevaContraseña", nuevaContraseña);
                cmd.Parameters.AddWithValue("@dni", dni);

                datos.con.Open();
                
                cmd.ExecuteNonQuery();
                datos.con.Close();


            }
            catch (Exception ex)
            {
               
                


            }
        }
        public int ObtenerCodFactura()
        {
            con.Open();
            SqlCommand com = new SqlCommand($"SELECT TOP 1 * FROM Factura ORDER BY IdFactura DESC", con);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();

            return Convert.ToInt32(dt.Rows[0][0]);
        }
            
            
            
            
    }


}



   

