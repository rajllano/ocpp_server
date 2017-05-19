using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocpp_server_modelo
{
    public class ReservaJson
    {
        public int Id { get; set; }

        public string NumeroSerie { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public DateTime FechaHora { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int Tiempo { get; set; }

        public double ValorRecarga { get; set; }

        public double EnergiaRecarga { get; set; }

        

        
    }
}
