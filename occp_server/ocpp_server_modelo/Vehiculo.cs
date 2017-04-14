using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class Vehiculo : IClonacion<Vehiculo>
    {
        public string Placa
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Tag
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Marca
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Modelo
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Propietario
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Vehiculo Clonar()
        {
            throw new NotImplementedException();
        }
    }
}