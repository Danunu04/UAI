using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP_Servicios;

namespace SERVICIOS
{
    public class AlertaSubject : IsubjectAlerta
    { 
        MPPDatos MPPD = new MPPDatos(); 
        public double Cantidaddegotas { get; private set; }
        private List<IObserverAlerta> Observadores = new List<IObserverAlerta>();

        // Método para agregar observadores sin duplicados
        public void AgregarObservador(IObserverAlerta observador)
        {
            if (!Observadores.Contains(observador))
            {
                Observadores.Add(observador);
            }
        }

        // Método para eliminar observadores
        public void EliminarObservador(IObserverAlerta observador)
        {
            if (Observadores.Contains(observador))
            {
                Observadores.Remove(observador);
            }
        }

        // Notifica a todos los observadores
        public void NotificarObservador()
        {
            foreach (var obs in Observadores)
            {
                try
                {
                    obs.Alerta(Cantidaddegotas); // Notifica a cada observador
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error notificando al observador: {ex.Message}");
                }
            }
        }
        public void SetCantidadGotas(double cantidad)
        {
            Cantidaddegotas = MPPD.TraerCantidadCritica();
            if (Cantidaddegotas > 0.60)
            {
                NotificarObservador();
            }
        }
    }
}
