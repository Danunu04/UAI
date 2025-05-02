using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Servicios
{
    public class Archivo
    {
        public string DestinoFactura { get; set; }
        public string DestinoBitacora { get; set; }

        public string conn { get; set; }


        //public ControlarArchivo()
        //{
        //    string RutaArchivo = "Destinos.txt";//nombre del archivo

        //    try
        //    {

        //        if(File.Exists(RutaArchivo))
        //        {
        //            FileStream FS = new FileStream(RutaArchivo,FileMode.Open);
        //            StreamReader sr = new StreamReader(FS);


        //            string[] VL = new string[0];
        //            string Registro;


        //            while (sr.Peek() == 1)//ver dps de hacerlo a nuestro modo lo del sr.peek
        //            {
        //                Registro = sr.ReadLine();

        //                VL = Registro.Split('|');//??
        //                DestinoFactura = VL[0];
        //                conn= VL[1];
        //                DestinoBitacora = VL[2];
        //            }
        //            sr.Close();
        //            FS.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception("Error al leer el archivo de configuración",ex);
        //    }


        //}








        //public string GenerarNombre()
        //{
        //    Random Rnd = new Random();
        //    string Nombre;

        //    int Numero = Rnd.Next(0,10001);

        //    char Letra = (char)Rnd.Next('A', 'Z' + 1);
        //    Nombre = "BIT" + Numero.ToString() + Letra;

        //    string NombreArchivo =Path.Combine( DestinoBitacora, $"{Nombre}.pdf");

        //    if (File.Exists(NombreArchivo))
        //    {
        //        return GenerarNombre();
        //    }

        //    return Nombre;
        //}
    }
}
