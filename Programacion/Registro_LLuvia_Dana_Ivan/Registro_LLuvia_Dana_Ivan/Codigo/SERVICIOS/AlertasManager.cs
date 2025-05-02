using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERVICIOS
{
    public class AlertasManager: IObserverAlerta
    {
        public void Alerta(double cantidadGotas)
        {
            Console.WriteLine($"Alerta: La cantidad de gotas caídas es {cantidadGotas} ml, Atencion.");
        }
    }
}
