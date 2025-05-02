using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;
using SERVICIOS;
using DAL;

namespace BLL
{
    public class BLLEventos
    {
        MPPEventos MPPE = new MPPEventos();
        DALEvento DE = new DALEvento();
        public object ListarFiltrado(DateTime fecha, DateTime fechaFin, int critic, string usuario, string modulo, string operacion)
        {
            return MPPE.ListarTodosFiltrado(fecha, fechaFin, critic, usuario, modulo, operacion);
        }

        public object ListarTodo()
        {
            return MPPE.ListarTodos();
        }

        public void RegistrarEvento(Evento evento)
        {
            MPPE.EjecutarComando(evento);

        }
    }
}

