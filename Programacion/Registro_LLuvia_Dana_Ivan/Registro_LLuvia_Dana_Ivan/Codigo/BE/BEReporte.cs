using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEReporte
    {
        public BEReporte(int R, double C, DateTime F, string L)
        {
            Responsable = R;
            CantidadAgua = C;
            FechaHora = F;
            Localidad = L;
        }

        private int _Responsable;

        public int Responsable
        {
            get { return _Responsable; }
            set { _Responsable = value; }
        }

        private double _CantidadAgua;

        public double CantidadAgua
        {
            get { return _CantidadAgua; }
            set { _CantidadAgua = value; }
        }

        private DateTime _FechaHora;

        public DateTime FechaHora
        {
            get { return _FechaHora; }
            set { _FechaHora = value; }
        }

        private string _Localidad;

        public string Localidad
        {
            get { return _Localidad; }
            set { _Localidad = value; }
        }


        
    }
}
