using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace SERVICIOS
{
    public class Validación
    {
        public static BEUsuario usuario;
        private static Validación Sesion; // evita instancias directas
        public Validación() { }

        public static Validación ObtenerInstancia()
        {
            return Sesion;
        }

        // Método para iniciar sesión recibiendo los datos de inicio de sesión
        public static void LogIn(BEUsuario nuevousuario)
        {
            if (Sesion == null)
            {
                Sesion = new Validación();  // Inicializamos la sesión
            }
            usuario = nuevousuario;
        }

        // Método para cerrar sesión
        public static void LogOut()
        {
            if (Sesion != null)
            {
                Sesion = null;
            }
            else
            {
                throw new Exception("Sesión no iniciada");
            }
        }
    }
}

