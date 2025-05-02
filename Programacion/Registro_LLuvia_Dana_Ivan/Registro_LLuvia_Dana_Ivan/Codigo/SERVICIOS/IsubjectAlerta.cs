using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS
{
    public interface IsubjectAlerta
    {
        void AgregarObservador(IObserverAlerta Observador);
        void NotificarObservador();
        void EliminarObservador(IObserverAlerta Observador);
    }
}
