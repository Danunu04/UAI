using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.SqlClient;
using System.Data;
using Servicios;


namespace DAL
{
    public  class DALAccesoDatos
    {
        //Casa Santi (PC): DESKTOP-E4N9PK3\\SQLEXPRESS01
        //Casa Ailu: DESKTOP-A6VSJ93\\SQLEXPRESS

        public SqlConnection Con = new SqlConnection("Data Source=DESKTOP-E4N9PK3\\SQLEXPRESS01;Initial Catalog=Productos_Defectuosos;Integrated Security=True;"); 
        public SqlCommand Cmd;

        public void Conectar()
        {
            if(Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        public void Desconectar()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        public void Ejecutar(string Consulta)
        {
            Conectar();
            Cmd = new SqlCommand(Consulta, Con);
            Cmd.ExecuteNonQuery(); //ejecuta la consulta sin esperar ningun valor de vuelta.
            Desconectar();
        }


       public DataTable DevuelveUsuariosBD(string Consulta)
        {
            Conectar();

            SqlCommand Cmd = new SqlCommand(Consulta, Con);
            DataTable dt = new DataTable();
            SqlDataReader DR = Cmd.ExecuteReader();
            dt.Load(DR);

            Desconectar();
            return dt;

        }


        

    }
}
