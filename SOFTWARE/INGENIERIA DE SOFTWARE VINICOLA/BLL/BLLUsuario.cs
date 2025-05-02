using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BLL
{
    public class BLLUsuario
    {
        DALUsuario DataUsuario = new DALUsuario();  
        Datos data = new Datos();
       
        public void RegistrarUsuario (Usuario usuario)
        {
            data.EjecutarComando("InsertarUsuario" , $"{usuario.DNI}, '{usuario.Nombre}', '{usuario.Apellido}', '{usuario.Mail}', '{usuario.NumTelefono}', '{usuario.UserName}', '{usuario.Password}', '{usuario.Rol}'");
        }

        public void ModificarUsuario (Usuario usuario)
        {
            data.EjecutarComando("ModificarUsuario", $"{usuario.DNI}, '{usuario.Nombre}', '{usuario.Apellido}', '{usuario.Mail}', '{usuario.NumTelefono}', '{usuario.UserName}', '{usuario.Rol}'");
        }
        public void EliminarUsuario(int dni)
        {
            data.EjecutarComando("EliminarUsuario", $"'{dni}'");
        }
      
        public bool IntentoFallido(string Username)
        {
            if (data.RevisarDisponibilidad(Username, "Username", "Usuario"))
            {
                data.EjecutarComando("IntentoFallido", Username);
            }
            if(DataUsuario.RevisarSanciones(Username, 3, "Username, IntentosFallidos"))
            {
                data.EjecutarComando("BloqueoUsuarioUsername", $"{Username}, 1");
                return true;
            }
            return false;
        }
        public Usuario RevisarLogin(string username, string password)
        {
            return DataUsuario.RevisarLogin(username, password);
        }
        public void ReiniciarIntentosFallidos(string Username)
        {
            data.EjecutarComando("ReiniciarIntentosFallidos", Username );
        }
        public bool RevisarDesactivado(string Username)
        {
            return DataUsuario.RevisarSanciones(Username, "Username, Desactivado");
        }

        public bool RevisarBloqueado(string Username)
        {
            return DataUsuario.RevisarSanciones(Username, "Username, Bloqueado");
        }

        public bool RevisarBloqueado(int DNI)
        {
            return DataUsuario.RevisarSanciones(DNI, "DNI, Bloqueado");
        }
        public bool BloquearUsuario(int DNI)
        {
            data.EjecutarComando("BloqueoUsuarioDNI", $"{DNI}, 1");
            return false;
        }
        
        public void DesbloquearDNI(int DNI)
        {
            data.EjecutarComando("BloqueoUsuarioDNI", $"{DNI}, 0");
            
        }
        public void ActualizarContraseña(int dni, string nuevaContraseña)
        {
            DataUsuario.ActualizarContraseña(dni, nuevaContraseña);
        }
    }
}
