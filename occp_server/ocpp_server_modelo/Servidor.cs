using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class Servidor
    {
        private static Servidor Instancia;

        public static Servidor getInstancia()
        {
            if (Instancia == null)
                Instancia = new Servidor();

            return Instancia;
        }

        public ColeccionPuntoCarga ColeccionPuntoCarga { get; set; }

        public ColeccionEstacion ColeccionEstacion { get; set; }

        public ColeccionReserva ColeccionReserva { get; set; }

        public ColeccionVehiculo ColeccionVehiculo { get; set; }

        private Servidor()
        {
            this.ColeccionPuntoCarga = new ColeccionPuntoCarga();
            this.ColeccionEstacion = new ColeccionEstacion();
            this.ColeccionReserva = new ColeccionReserva();
            this.ColeccionVehiculo = new ColeccionVehiculo();
        }

        ~Servidor()
        {
            this.ColeccionPuntoCarga = null;
            this.ColeccionEstacion = null;
            this.ColeccionReserva = null;
            this.ColeccionVehiculo = null;

            GC.Collect();
        }
    }
}