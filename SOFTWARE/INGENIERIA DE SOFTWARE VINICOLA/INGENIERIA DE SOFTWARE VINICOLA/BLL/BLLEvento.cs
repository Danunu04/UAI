using DAL;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLEvento
    {
        Datos data = new Datos();

        public void RegistrarEvento(Evento evento)
        {
            data.EjecutarComando("RegistrarEvento", $"'{evento.NombreUsuario}', '{evento.Fecha}', '{evento.Modulo}', '{evento.Criticidad}'");

        }

    }
}
