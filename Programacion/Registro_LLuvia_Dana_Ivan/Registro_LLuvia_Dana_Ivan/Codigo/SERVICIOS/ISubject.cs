using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS
{
    public interface ISubject
    {
        void AgregarObservador(IObserver Observador);
        void NotificarObservador();
        void EliminarObservador(IObserver Observador);
    }
}
