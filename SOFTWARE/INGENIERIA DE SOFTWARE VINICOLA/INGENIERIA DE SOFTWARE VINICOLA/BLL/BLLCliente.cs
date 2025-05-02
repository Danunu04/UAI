using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCliente
    {
        Datos data = new Datos();
        public void AgregarCliente(Cliente cliente)
        {
            data.EjecutarComando("AgregarCliente", $"{cliente.DNI}, '{cliente.Nombre}', '{cliente.Apellido}', '{cliente.Domicilio}','{cliente.Email}', '{cliente.Telefono}'");
        }
        public void ModificarCliente(Cliente cliente)
        {
            data.EjecutarComando("ModificarCliente", $"{cliente.DNI}, '{cliente.Nombre}', '{cliente.Apellido}', '{cliente.Domicilio}','{cliente.Email}', '{cliente.Telefono}'");
        }
        public void EliminarCliente(int dni)
        {
            data.EjecutarComando("EliminarCliente", $"'{dni}'");
        }
    }
}
