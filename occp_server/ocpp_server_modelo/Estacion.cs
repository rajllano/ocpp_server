using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class Estacion : IClonacion<Estacion>
    {
        public int Id
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Nombre
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int Direccion
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int Ubicacion
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
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

        public Estacion Clonar()
        {
            throw new NotImplementedException();
        }
    }
}