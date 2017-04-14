using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class Servidor
    {
        private static Servidor Instancia;

        private Servidor()
        {

        }

        public static Servidor getInstancia()
        {
            if (Instancia == null)
                Instancia = new Servidor();

            return Instancia;
        }

        public ColeccionPuntoCarga ColeccionPuntoCarga
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public ColeccionEstacion ColeccionEstacion
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public ColeccionReserva ColeccionReserva
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public ColeccionLog ColeccionLog
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public ColeccionVehiculo ColeccionVehiculo
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}