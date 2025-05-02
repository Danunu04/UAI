using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BE;
using SERVICIOS;

namespace DAL
{
    public class Datos
    {
        public SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=VINICOLA;Integrated Security=True");

        public void EjecutarComando(string comando,string parametros)
        {
            con.Open();
            string query = "exec " + comando + " " + parametros;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public bool RevisarDisponibilidad(string data,string columna,string tabla)
        {
            DataTable dt = LlenarTabla(columna, tabla);
               
                foreach(DataRow row in dt.Rows)
        
                {
                    if(row[0].ToString() == data)
                    {
                        return true;
                    }
                }
          return false;
        

       

        }
        public DataTable LlenarTabla(string columna, string tabla)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"SELECT {columna} FROM {tabla}", con);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable LlenarTabla(string columna, string tabla, string condicion)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"SELECT {columna} FROM {tabla} WHERE {condicion}", con);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            con.Close();
            return dt;

        }
        public DataTable RegistrarEvento(Evento evento)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"INSERT INTO Evento VALUES @NombreUsuario, @Fecha, @Modulo, @Criticidad");
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            con.Close();
            return dt;

        }
    }

}
