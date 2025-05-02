using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios;
using System.Runtime.Remoting.Messaging;
using System.Data;

namespace DAL
{
    public class DALUsuario
    {
        public List<CLSUsuario> ListaUsuarios { get; set; }

        DALAccesoDatos DALDatos = new DALAccesoDatos();

        public DALUsuario()
        {
            ListaUsuarios = new List<CLSUsuario>();
        }

        public void GuardarUsuarioLista(CLSUsuario usuario)
        {
            ListaUsuarios.Add(usuario);
        }

        public void GuardarUsuarioBDD(CLSUsuario U)
        {
            string Consulta = "USE [Productos_Defectuosos] INSERT INTO Usuarios (Documento,Nombre,Apellido,Fec_Nac,Mail,Contrasenia,Rol,Idioma,Estado) VALUES (" + U.Documento + ",'" + U.Nombre + "','" + U.Apellido + "', '" + U.Fecha_Nacimiento + "', '" + U.Mail + "', '" + U.Contraseña + "', '" + U.Rol + "', '" + U.Idioma + "', '"+ U.Estado + "');";
            DALDatos.Ejecutar(Consulta);
        }

        public void EditarUsuarioBDD(CLSUsuario U)
        {
            string Consulta = "USE [Productos_Defectuosos]; UPDATE Usuarios SET " + "Nombre = '" + U.Nombre + "', " + "Apellido = '" + U.Apellido + "', " +
                  "Fec_Nac = '" + U.Fecha_Nacimiento + "', " +
                  "Mail = '" + U.Mail + "', " +
                  "Contrasenia = '" + U.Contraseña + "', " +
                  "Rol = '" + U.Rol + "', " +
                  "Idioma = '" + U.Idioma + "', " +
                  "Estado = '" + U.Estado + "' " +
                  "WHERE Documento = " + U.Documento + ";";


            DALDatos.Ejecutar(Consulta);
        }


        public void EliminarUsuario(CLSUsuario usuario)
        {
            ListaUsuarios.Remove(usuario);
        }

        public CLSUsuario BuscarUsuario(string mail)
        {
            CLSUsuario user = new CLSUsuario();

            ListaUsuarios.ForEach((CLSUsuario Usuario) =>
            {
                if (Usuario.Mail == mail)
                {
                    user = Usuario;
                }

            });
            return user;
        }




        public bool BuscarMail(string mail)
        {
            bool Existe = false;
            ListaUsuarios = DevolverUsuariosDB();

            ListaUsuarios.ForEach((CLSUsuario Usuario) =>
            {
                if (Usuario.Mail == mail)
                {
                    Existe = true;
                    
                }

            });
            return Existe;
        }

        public bool BuscarContrasenia(string mail, string contraseña)
        {
            bool Existe = false;

            ListaUsuarios = DevolverUsuariosDB();

            ListaUsuarios.ForEach((CLSUsuario Usuario) =>
            {
                if (Usuario.Contraseña == contraseña && Usuario.Mail == mail)
                {
                    Existe = true;
                }

            });
            return Existe;
        }



        public List<CLSUsuario> DevolverUsuariosDB()
        {
            List<CLSUsuario> list = new List<CLSUsuario>();

            DataTable DT = DALDatos.DevuelveUsuariosBD("SELECT * FROM Usuarios;");

            foreach(DataRow linea in DT.Rows)
            {
                CLSUsuario user = new CLSUsuario(Convert.ToInt32(linea[0]), linea[1].ToString(), linea[2].ToString(),Convert.ToDateTime(linea[3]), linea[4].ToString(), linea[5].ToString(), linea[6].ToString(), linea[7].ToString(),Convert.ToInt32(linea[8]));

                list.Add(user);
            }

            return list;
        }

    }
}
