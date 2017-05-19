using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ocpp_server_control;
using ocpp_server_modelo;

namespace ocpp_server_control
{
    public static class JSon
    {
        private static string Cadena;

        public static string  SerializarReserva(Reserva objReserva)
        {   
            Reserva c = new Reserva();
            Cadena = JsonConvert.SerializeObject(objReserva);
            return Cadena;
        }
    }
}
