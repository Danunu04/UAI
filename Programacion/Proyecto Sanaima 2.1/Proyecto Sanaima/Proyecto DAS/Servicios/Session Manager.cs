using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Servicios
{
    public class Session_Manager
    {
        
        CLSUsuario Usuario;
        private static Session_Manager instancia;


        public static Session_Manager Instancia()
        {
            if(instancia == null)
            {
                
               // throw new Exception("No hay sesión iniciada");
                instancia = new Session_Manager();
            }
            return instancia;
        }

        public CLSUsuario GetUsuario()
        {
            return this.Usuario;
        }

       

        public static void DesLogear()
        {
            if(Instancia().Usuario == null) 
            {

                throw new Exception("Debe haber algun cliente logeado primero.");

            }
            else
            {

                Instancia().Usuario = null;
            }

        }


        public static void Logear(CLSUsuario UsuarioDB)
        {
            if (Instancia().Usuario == null)
            {

                Instancia().Usuario = UsuarioDB;
                
            }
            else
            {

                throw new Exception("Ya hay un cliente logeado, espere a que cierre sesión.");

            }

        }




    }
}
