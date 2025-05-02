using BE;
using System.Drawing;
using System.Printing;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SERVICIOS;
using System.Diagnostics;

namespace MPP
{
    public class MPPEventos
    {
        DALEvento DALE = new DALEvento();
       
        public void EjecutarComando(Evento evento)
        {
            string NombreUsuario = evento.NombreUsuario;
            DateTime Fecha = evento.Fecha;
            string Modulo = evento.Modulo;
            string Operacion = evento.Operacion;
            int criticidad = evento.Criticidad;

            int UsuarioID = TraerUsuarioID(NombreUsuario);
            if(UsuarioID >= 0)
            {
                string Consulta = @"INSERT INTO [dbo].[Bitacora] 
                                    (criticidad, Operacion, Fecha, Modulo, UsuarioID)
                                    VALUES (@criticidad, @Operacion, @Fecha, @Modulo, @UsuarioID)";

                ArrayList Parametros = new ArrayList();
                Parametros.Add(new SqlParameter("@criticidad", criticidad));
                Parametros.Add(new SqlParameter("@Operacion", Operacion));
                Parametros.Add(new SqlParameter("@Fecha", Fecha));
                Parametros.Add(new SqlParameter("@Modulo", Modulo));
                Parametros.Add(new SqlParameter("@UsuarioID",UsuarioID));

                DALE.Escribir(Consulta, Parametros);
            }
           

        }

        private int TraerUsuarioID(string nombreUsuario)
        {
            int usuarioID = -1;
            string consulta = @"Select [UsuarioID]
                                From [Persona].[Usuario]
                                Where [Usuario]= @usuario";
            ArrayList Parametros = new ArrayList();
            Parametros.Add(new SqlParameter("@usuario", nombreUsuario));
            DataTable DT = DALE.Buscar(consulta, Parametros);
            if(DT.Rows.Count>0)
            {
                foreach(DataRow item in DT.Rows)
                {
                    usuarioID = Convert.ToInt32(item[0]);
                }
            }
            return usuarioID;
        }

        public object ListarTodos()
        {
            List<Evento> eventos = new List<Evento>();
            string Consulta = "SELECT* FROM[dbo].[Bitacora]";
            DataTable DT = DALE.LeerTodo(Consulta, null);

            if (DT.Rows.Count > 0)
            {
                foreach (DataRow item in DT.Rows)
                {
                    //Los traaduce y x cada row los agrega a mi lista de objetos
                    int ID = Convert.ToInt32(item[5]);
                    string NombreUsuario = TraerNUduario(ID);

                    if (NombreUsuario != "")
                    {
                        DateTime Fecha = Convert.ToDateTime(item["Fecha"]); // Usa el nombre de la columna en vez de un índice numérico.

                        string Modulo = item[3].ToString();
                        string Operacion = item[1].ToString();
                        int criticidad = Convert.ToInt32(item[0]);
                        int IDEvento = Convert.ToInt32(item[4]);

                        Evento even = new Evento(NombreUsuario, Fecha, Modulo, Operacion, criticidad);
                        even.IdEvento = IDEvento;
                        eventos.Add(even);
                    }
                    else
                    {
                        throw new Exception("error en la base, ubicado en la mpp");
                    }
                }
                return eventos;
            }
            else
            {
                return null;
            }
        }

        private string TraerNUduario(int usuarioID)
        {
            string Usuario = "";
            string consulta = @"Select [Usuario]
                                from [Persona].[Usuario]
                                where [UsuarioID] = @UsuarioID";
            ArrayList Parametros = new ArrayList();
            Parametros.Add(new SqlParameter("@UsuarioID", usuarioID));
            DataTable DT = DALE.Buscar(consulta, Parametros);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow item in DT.Rows)
                {
                    Usuario = item[0].ToString();
                }
            }
            return Usuario;
        }

        //ARREGLAR
        public object ListarTodosFiltrado(DateTime fecha, DateTime fechaFin, int critic, string usuario, string modulo, string operacion)
        {
            List<Evento> eventos = new List<Evento>();
            List<string> condiciones = new List<string>();
            List<SqlParameter> parametros = new List<SqlParameter>();

            if (fecha != DateTime.MinValue)
            {
                condiciones.Add("(Fecha >= @FechaInicio)");
                parametros.Add(new SqlParameter("@FechaInicio", fecha));
            }

            if (fechaFin != DateTime.MinValue)
            {
                condiciones.Add("(Fecha <= @FechaFinal)");
                parametros.Add(new SqlParameter("@FechaFinal", fechaFin));
            }

            if (critic != 0) // Asumiendo que 0 es un valor no crítico
            {
                condiciones.Add("(Criticidad = @Criticidad)");
                parametros.Add(new SqlParameter("@Criticidad", critic));
            }

            if (!string.IsNullOrEmpty(usuario))
            {
                int usuarioID = TraerUsuarioID(usuario);
                condiciones.Add("(UsuarioID = @UsuarioID)");
                parametros.Add(new SqlParameter("@UsuarioID", usuarioID));
            }

            if (!string.IsNullOrEmpty(modulo))
            {
                condiciones.Add("(Modulo = @Modulo)");
                parametros.Add(new SqlParameter("@Modulo", modulo));
            }

            if (!string.IsNullOrEmpty(operacion))
            {
                condiciones.Add("(Operacion = @Operacion)");
                parametros.Add(new SqlParameter("@Operacion", operacion));
            }

            string consultaFinal = "SELECT * FROM [dbo].[Bitacora] WHERE " + string.Join(" AND ", condiciones);

            // Conversión a ArrayList
            ArrayList parametrosArrayList = new ArrayList();
            foreach (var param in parametros)
            {
                parametrosArrayList.Add(param);
            }

            DataTable DT = DALE.LeerTodo(consultaFinal, parametrosArrayList);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow item in DT.Rows)
                {
                    int ID = Convert.ToInt32(item[5]);
                    string NombreUsuario = TraerNUduario(ID);

                    if (!string.IsNullOrEmpty(NombreUsuario))
                    {
                        DateTime Fecha = Convert.ToDateTime(item[2]);
                        string Modulo = item[3].ToString();
                        string Operacion = item[1].ToString();
                        int criticidad = Convert.ToInt32(item[0]);
                        int IDEvento = Convert.ToInt32(item[4]);

                        Evento even = new Evento(NombreUsuario, Fecha.Date, Modulo, Operacion, criticidad);
                        even.IdEvento = IDEvento;
                        eventos.Add(even);
                    }
                    else
                    {
                        throw new Exception("Error en la base, ubicado en la mpp");
                    }
                }
                return eventos;
            }
            else
            {
                return null;
            }

        }
    }
}
