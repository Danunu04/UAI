using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using Servicios;
using System.Globalization;

namespace BLL
{
    public class Bll
    {
        DALUsuario DALU = new DALUsuario();
        DALProducto DALP = new DALProducto();
        

        public string CambiarEstado(float Porcentaje)
        {
            if (Porcentaje >= 65)
            {
                return "Desechable";
            }
            else
            {
                return "Reacondicionable";
            }    
        }

        public void GuardarProducto(CLSProducto Producto)
        {
            
            
                DALP.GuardarProductoBDD(Producto);
             
        }

        public List<CLSProducto> RecibirListaProductos()
        {
           return DALP.DevolverProductosDB();

        }



        public void EliminarProducto(CLSProducto Producto)
        {
            try
            {
                DALP.EliminarProducto(Producto);
            }
            catch
            {
                throw new Exception("Tudo mal");
            }
        }

        
        public void BuscarProducto(CLSProducto Producto)
        {
            try
            {
                DALP.BuscarProducto(Producto.Codigo);
            }
            catch
            {
                throw new Exception("Tudo mal");
            }
        }





        public void GuardarUsuario(CLSUsuario Usuario)
        {
            DALU.GuardarUsuarioBDD(Usuario);
        }


        public void EliminarUsuario(CLSUsuario usuario)
        {
            try
            {
                DALU.EliminarUsuario(usuario);
            }
            catch
            {
                throw new Exception("Tudo mal");
            }
        }

        public CLSUsuario BuscarUsuario(string mail)
        {
            try
            {
                return DALU.BuscarUsuario(mail);
            }
            catch
            {
                throw new Exception("Tudo mal");
            }
        }

        public bool VerificarUsuario(string mail, string contrasenia)
        {

            

            if (DALU.BuscarMail(mail) == true)
            {
                if(DALU.BuscarContrasenia(mail, contrasenia)== true)
                {
                    
                    return true;
                }
                else
                {
                    throw new Exception("Contraseña incorrecta.");
                }



            }
            else
            {
               // return false; por si no funca
                throw new Exception("Usuario no existe.");
                
            }

        }


        public List<CLSUsuario> RecibirListaEmpleados()
        {
            return DALU.DevolverUsuariosDB();

        }



        public void EditarUsuario(CLSUsuario U)
        {
             DALU.EditarUsuarioBDD(U);
        }

    }
}
