using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ocpp_server_control;
using ocpp_server_modelo;
using NetworksApi.TCP.SERVER;
using System.Net;

namespace ocpp_server_control
{
    public static class JSon
    {
        private static string Cadena;

        public static string  SerializarReserva(ReservaJson  objReserva)
        {   
            ReservaJson  c = new ReservaJson();
            Cadena = JsonConvert.SerializeObject(objReserva);
            return Cadena;
        }

        public static ReservaJson  DeserializarReservas(string pCadena)
        {
            ReservaJson  p = JsonConvert.DeserializeObject<ReservaJson>(pCadena);

            return p;
        }




        private static string obtenerIp()
        {
            string IPLocal = "0.0.0.0";
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    IPLocal = ip.ToString();
                }
            }

            return IPLocal;
        }

    }
}
