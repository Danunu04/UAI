using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using BE;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;
using SERVICIOS;


namespace MPP
{
    public class MPPUsuario
    {DALSesion DALS = new DALSesion();
     DALUsuario DALU = new DALUsuario();

        public void Cargar(string nombre, string aapellido, int dni, string usuario, string contraseña, bool estado, string rol)
        {
            string Consulta = "INSERT INTO [Persona].[Usuario] \r\n(Nombre, Apellido, Dni, Usuario, Contraseña, Estado, Rol) \r\nVALUES \r\n(@Nombre, @Apellido, @Dni, @Usuario, @Contraseña, 1, @Rol);";
            ArrayList Parametros = new ArrayList();
            Parametros.Add(new SqlParameter("@Nombre", nombre));
            Parametros.Add(new SqlParameter("@Apellido", aapellido));
            Parametros.Add(new SqlParameter("@Dni", dni));
            Parametros.Add(new SqlParameter("@Usuario", usuario));
            Parametros.Add(new SqlParameter("@Contraseña", contraseña));
            Parametros.Add(new SqlParameter("@Rol", rol));
            DALS.Cargar(Consulta, Parametros);

        }

        public bool Errores(string usuario)
        {
            bool error = false;
            string Consulta = "SELECT[Usuario], [Intentos] FROM [dbo].[UsuarioIntentos] WHERE [Usuario]= @Usuario";
            ArrayList Parametros = new ArrayList();
            Parametros.Add(new SqlParameter("@Usuario", usuario));

            DataTable DT = DALS.Buscar(Consulta, Parametros);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow item in DT.Rows)
                {
                    string UsuarioDB = Convert.ToString(item[0]);
                    if (UsuarioDB.Equals(usuario))
                    {
                        int intentos = Convert.ToInt32(item[1]);
                        if(intentos>=3)
                        {
                            Consulta = "UPDATE [Persona].[Usuario]\r\nSET [Estado] = 0\r\nWHERE [Usuario] = @Usuario";
                            DALS.EjecutarConsulta(Consulta, Parametros);
                            error = true;
                            return error;
                        }
                        else
                        {
                            Consulta = "UPDATE [dbo].[UsuarioIntentos]\r\nSET [Intentos] = [Intentos] + 1\r\nWHERE [Usuario] = @Usuario";
                            DALS.EjecutarConsulta(Consulta, Parametros);
                        }
                    }
                    else
                    {
                        Exception ex = new Exception("No se encontró el usuario");
                    }
                }
            }
            return error;
        }

        public List<BEUsuario> listarRol()
        {
            BEUsuario BEU = null;
            List<BEUsuario> Usuario = new List<BEUsuario>();
            bool error = false;
            string Consulta = "SELECT* FROM [Persona].[Usuario]";

            DataTable DT = DALS.Buscar(Consulta, null);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow item in DT.Rows)
                {
                    string Nombre = Convert.ToString(item[0]);
                    string Apellido = Convert.ToString(item[1]);
                    int Dni = Convert.ToInt32(item[2]);
                    string usuario = Convert.ToString(item[4]);
                    string Contraseña = Convert.ToString(item[5]);
                    bool Estado = Convert.ToBoolean(item[6]);
                    string Rol = Convert.ToString(item[7]);
                    BEU = new BEUsuario(Nombre, Apellido, Dni, usuario, Contraseña, Estado, Rol);
                    Usuario.Add(BEU);
                }
            }
            return Usuario;
        }

        public void ReiniciarErrores(string usuario)
        {
            int UsuarioID = TraerUsuario(usuario);
            string Consulta = "UPDATE [dbo].[UsuarioIntentos]\r\nSET [Intentos] = 0\r\nWHERE [UsuarioID] = @UsuarioID";
            ArrayList Parametros = new ArrayList();
            Parametros.Add(new SqlParameter("@UsuarioID", UsuarioID));

            DataTable DT = DALS.Buscar(Consulta, Parametros);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow item in DT.Rows)
                {
                    string UsuarioDB = Convert.ToString(item[0]);
                    if (UsuarioDB.Equals(usuario))
                    {
                        DALS.EjecutarConsulta(Consulta, Parametros);
                    }
                }
            }
        }

        private int TraerUsuario(string usuario)
        {
            int UsuarioID = 0;
            string Consulta = "SELECT [UsuarioID], [Usuario] FROM [Persona].[Usuario] WHERE [Usuario]= @Usuario";
            ArrayList Parametros = new ArrayList();
            Parametros.Add(new SqlParameter("@Usuario", usuario));
            DataTable DT = DALS.Buscar(Consulta, Parametros); // Asegúrate de que este método devuelva un DataTable

            if (DT.Rows.Count > 0)
            {
                foreach (DataRow item in DT.Rows)
                {
                    string UsuarioDB = Convert.ToString(item[1]);
                    if (UsuarioDB.Equals(usuario))
                    {
                        UsuarioID = Convert.ToInt32(item[0]);
                    }
                }
            }
            return UsuarioID;
        }

        public bool RevisarErrores(string usuario)
        {
            bool Estado = false;
            string Consulta = "SELECT[Usuario], [Estado] FROM [Persona].[Usuario] WHERE [Usuario]= @Usuario";
            ArrayList Parametros = new ArrayList();
            Parametros.Add(new SqlParameter ("@Usuario", usuario));

            DataTable DT = DALS.Buscar(Consulta, Parametros);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow item in DT.Rows)
                {
                    string UsuarioDB = Convert.ToString(item[0]);
                    if (UsuarioDB.Equals(usuario))
                    {
                        Estado = Convert.ToBoolean(item[1]);
                        return Estado;
                    }
                    else
                    {
                        Exception ex = new Exception("No se encontró el usuario");
                    }
                }
            }
            return Estado;
        }

        public BEUsuario ValidarUsuario(string usuario, string contraseña)
        {
            BEUsuario BEU = null;
            string Consulta = "SELECT [Usuario], [Contraseña], [Nombre], [Apellido], [Dni], [Estado], [Rol] FROM [Persona].[Usuario] WHERE [Usuario]= @Usuario";
            ArrayList Parametros = new ArrayList();
            Parametros.Add(new SqlParameter("@Usuario", usuario));
            Parametros.Add (new SqlParameter("@Contraseña", contraseña));
            DataTable DT = DALS.Buscar(Consulta, Parametros);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow Fila in DT.Rows)
                {
                    string UsuarioDB = Convert.ToString(Fila[0]);
                    string ContraseñaBD = Convert.ToString(Fila[1]);
                    if (UsuarioDB.Equals(usuario)&&ContraseñaBD.Equals(contraseña))
                    {
                        string Nombre = Convert.ToString(Fila[2]);
                        string Apellido = Convert.ToString(Fila[3]);
                        int Dni = Convert.ToInt32(Fila[4]);
                        bool Estado = Convert.ToBoolean(Fila[5]);
                        string Rol = Convert.ToString(Fila[6]);
                        BEU = new BEUsuario(Nombre, Apellido, Dni, UsuarioDB, ContraseñaBD, Estado, Rol);
                    }
                   
                }
            }
            return BEU;
        }

        public List<BEPermisos> BuscarPermisos(int UsuarioID)
        {
            var Permisos = new List<BEPermisos>();
            string Consulta = @"SELECT p.Nombre, p.IsPerfil
                                FROM [dbo].[UsuarioPersimo] up
                                JOIN Permiso p ON up.PermisoID = p.PermisoID
                                WHERE up.UsuarioID = @UsuarioID";
            ArrayList Parametros = new ArrayList();
            Parametros.Add(new SqlParameter("@UsuarioID", UsuarioID));
            DataTable DT = DALS.BuscarPermisos(Consulta, Parametros);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow item in DT.Rows)
                {
                    string nombre = Convert.ToString(item[0]);
                    bool esPerfil = Convert.ToBoolean(item[1]);
                    BEPermisos Per = new BEPermisos(nombre, esPerfil);
                    Permisos.Add(Per);
                }
            }
            return Permisos;
        }

        public int TraerID(string usuario)
        {
            int UsuarioID = 0;
            string Consulta = "SELECT [UsuarioID], [Usuario] FROM [Persona].[Usuario] WHERE [Usuario]= @Usuario";
            ArrayList Parametros = new ArrayList();
            Parametros.Add(new SqlParameter("@Usuario", usuario));
            DataTable DT = DALS.Buscar(Consulta, Parametros);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow Fila in DT.Rows)
                {
                    string UsuarioDB = Convert.ToString(Fila[1]);
                    if (UsuarioDB.Equals(usuario))
                    {
                        UsuarioID = Convert.ToInt32(Fila[0]);
                    }

                }
            }
            return UsuarioID;
        }

        public string TraerIdioma(string usuario)
        {
            string idioma = "";
            string consulta = "Select [Idioma] From [Persona].[Usuario] WHERE [Usuario]= @Usuario";
            ArrayList Parametros = new ArrayList();
            Parametros.Add(new SqlParameter("@Usuario", usuario));
            DataTable DT = DALU.Burcar(consulta, Parametros);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow Fila in DT.Rows)
                {
                     idioma = Convert.ToString(Fila[0]);
                }
            }
            return idioma;
        }

        public void EscribirIdioma(string idi, BEUsuario user)
        {
            string usuario = user.Usuario.ToString();
            string consulta = @"UPDATE [Persona].[Usuario]    
                                SET [Idioma] = @Idioma    
                                WHERE [Usuario] = @Usuario";
            ArrayList Parametros = new ArrayList();
            Parametros.Add(new SqlParameter("@Idioma", idi));
            Parametros.Add(new SqlParameter("@Usuario", usuario));
            DALU.Set(consulta, Parametros);
        }
    }
}
