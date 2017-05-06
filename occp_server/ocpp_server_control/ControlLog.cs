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
            String NombreArchivo = Fecha.Day.ToString() + Fecha.Month.ToString() + Fecha.Year.ToString() + "_" + Fecha.Hour.ToString();

            try
            {
                StreamWriter Archivo = new StreamWriter(@"C:\Log\" + NombreArchivo + ".txt");
                Archivo.WriteLine("[" + Fecha.ToString() + "]" + Mensaje + "\n");
                Archivo.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("[" + Fecha.ToString() + "] " + e.ToString());
            }
        }
    }
}
