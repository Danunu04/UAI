using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using SERVICIOS;
using DAL;

namespace MPP
{
    public class MPPSesion
    {
        DALSesion DALS = new DALSesion();
        CriptoManager CriptoManager = new CriptoManager();
        public BEUsuario ValidarUSUARIO(string nombreUsuario, string contraseña)
        {
            BEUsuario BEU = null;
            string Consulta = "SELECT [Usuario], [Contraseña], [Nombre], [Apellido], [Dni],[Estado], [Rol] \r\nFROM [Persona].[Usuario] \r\nWHERE [Usuario] = @nombreUsuario";
            ArrayList parametros = new ArrayList();
            parametros.Add(new SqlParameter("@nombreUsuario", nombreUsuario));
            parametros.Add(new SqlParameter("@Contraseña", contraseña));

            // Ejecutar la consulta y obtener el resultado
            DataTable DT = DALS.Buscar(Consulta, parametros);

            if (DT.Rows.Count > 0 && DT.Rows.Count < 5)
            {
                foreach (DataRow item in DT.Rows)
                {
                    string UsuarioDB = Convert.ToString(item[0]);
                    string ContraseñaDB = CriptoManager.GetAES256(Convert.ToString(item[1]));

                    string UsuarioParametros = parametros[0].ToString();
                    string ContraseñaParametros = parametros[1].ToString();

                    if (UsuarioDB.Equals(nombreUsuario) &&
                            ContraseñaDB.Equals(contraseña))
                    {
                        string Nombre = Convert.ToString(item[2]);
                        string Apellido = Convert.ToString(item[3]);
                        int Dni = Convert.ToInt32(item[4]);
                        bool Estado = Convert.ToBoolean(item[5]);
                        string Rol = Convert.ToString(item[6]);
                        BEU = new BEUsuario(Nombre, Apellido, Dni, UsuarioDB, ContraseñaDB,Estado,Rol);
                    }
                }
            }
            return BEU;
        }
    }
}
