using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Idioma : Isujeto
    {
        public string idioma { get; set; }
        List<IObserver> Observadores = new List<IObserver>();
        public void AgregarObservador(IObserver Observador)
        {
            Observadores.Add(Observador);
        }

        public void EliminarObservador(IObserver Observador)
        {
            Observadores.Remove(Observador);
        }

        public void NotificarObservador()
        {
            foreach (var obs in Observadores)
            {
                obs.Actualizar(idioma);
            }
        }

        public void CambiarIdioma(string idi)
        {
            idioma = idi;
            NotificarObservador();
        }
    }
}
