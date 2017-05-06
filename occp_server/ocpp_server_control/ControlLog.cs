using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocpp_server_control
{
    public static class ControlLog
    {
        public static void Registrar(string Mensaje)
        {
            DateTime Fecha = DateTime.Now;
            String NombreArchivo = "";

            NombreArchivo = Fecha.Day.ToString().PadLeft(2,'0');
            NombreArchivo += Fecha.Month.ToString().PadLeft(2, '0'); ;
            NombreArchivo += Fecha.Year.ToString() + "_";
            NombreArchivo += Fecha.Hour.ToString().PadLeft(2,'0');

            try
            {
                StreamWriter Archivo = new StreamWriter(@"C:\Log\" + NombreArchivo + ".txt");
                Archivo.WriteLine("[" + Fecha.ToString() + "] " + Mensaje);
                Archivo.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("[" + Fecha.ToString() + "] " + e.ToString());
            }
        }
    }
}
