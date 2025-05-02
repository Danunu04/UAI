using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CLSProducto
    {

        public CLSProducto(int cod, int res, string nom, float cost, float gast, string esta)
        {
              
            
            Codigo = cod; 
            Responsable_Doc = res;
            NombreProducto = nom;
            Costo = cost;
            GastoPrevio = gast;
            Estado = esta;

        }
        public CLSProducto()
        {
            
        }

        //Ver que hacer con las caracteristicas del producto
        public int Responsable_Doc { get; set; }
        public int Codigo { get; set; }
        public string NombreProducto { get; set; }
        public float Costo { get; set; }
        public float GastoPrevio { get; set; }
        public string Estado { get; set; }

    }
}
