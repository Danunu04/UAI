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
        private static readonly SessionManager instance = new SessionManager();
        private static Usuario _user;


        public string idiomaActual;

        public string IdiomaActual
        {
            get { return idiomaActual; }
            set
            {
                idiomaActual = value;
                LanguageManager.ObtenerInstancia().CargarIdioma();
                LanguageManager.ObtenerInstancia().Notificar();
            }
        }
        private SessionManager() { }

      
        
        public static SessionManager ObtenerInstancia()
        {
            return instance;
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
