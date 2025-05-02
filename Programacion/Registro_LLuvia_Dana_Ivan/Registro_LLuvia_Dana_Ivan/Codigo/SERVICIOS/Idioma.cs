using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS
{
    public class Idioma : ISubject
    {
        public string IdiomaActual { get; private set; }
        private List<IObserver> Observadores = new List<IObserver>();

        // Método para agregar observadores sin duplicados
        public void AgregarObservador(IObserver observador)
        {
            if (!Observadores.Contains(observador))
            {
                Observadores.Add(observador);
            }
        }

        // Método para eliminar observadores
        public void EliminarObservador(IObserver observador)
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
                    obs.ActualizarIdioma(IdiomaActual); // Notifica a cada observador
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error notificando al observador: {ex.Message}");
                }
            }
        }

        // Cambia el idioma y notifica a los observadores
        public void CambiarIdioma(string nuevoIdioma)
        {
            IdiomaActual = nuevoIdioma;
            NotificarObservador();
        }
    }
}
