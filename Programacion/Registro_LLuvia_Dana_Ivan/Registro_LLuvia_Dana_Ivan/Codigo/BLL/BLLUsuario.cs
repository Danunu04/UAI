using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;
using BE;

namespace BLL
{
    public class BLLUsuario
    {
        MPPUsuario MPPU = new MPPUsuario();

        public void Cargar(string Nombre, string Aapellido, int Dni, string Usuario, string Contraseña, bool Estado, string Rol)
        {
           MPPU.Cargar(Nombre, Aapellido, Dni, Usuario, Contraseña, Estado, Rol);
        }

        public bool IntentoFallido(string usuario)
        {
            return MPPU.Errores(usuario);
        }

        public object ListarRoles()
        {
            return MPPU.listarRol();
        }

        public void ReiniciarIntentosFallidos(string usuario)
        {
            MPPU.ReiniciarErrores(usuario);
        }

        public bool RevisarEstado(string usuario)
        {
            return MPPU.RevisarErrores(usuario);
        }

        public void SetearIdioma(string idi, BEUsuario user)
        {
            MPPU.EscribirIdioma(idi, user);
        }

        public string TraerIdioma(string usuario)
        {
            return MPPU.TraerIdioma(usuario);
        }

        public int TraerUsuaeioID(string usuario)
        {
            return MPPU.TraerID(usuario);
        }

        public BEUsuario TraerUsuarioValido(string usuario, string Contraseña)
        {
            return MPPU.ValidarUsuario(usuario, Contraseña);
        }
    }
}
