using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS
{
    public sealed class SessionManager
    {
        private static SessionManager Instancia = null;
        private static Usuario _user;
       
      
        private SessionManager() { }

      
        
        public static SessionManager ObtenerInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new SessionManager();
            }
            return Instancia;
        }

       
        public void IniciarSesion(Usuario userNuevo)
        {
            _user = userNuevo;
        }

        
        public void CerrarSesion()
        {
            
            _user = null;
        }

     
        public Usuario Usuario
        {
            get { return _user; }
        }

        public static Usuario ObtenerDatosUsuario()
        {
            return _user;
        }
        
      
    
    
    
    }   
    

}
