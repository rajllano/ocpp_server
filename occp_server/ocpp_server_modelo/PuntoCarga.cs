using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class PuntoCarga : IClonacion<PuntoCarga>
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

        public string NumeroSerie
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

        public EEstadoPuntoCarga EEstadoPuntoCarga
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public EEstadoConectorPuntoCarga EEstadoConectorPuntoCarga
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public PuntoCarga Clonar()
        {
            throw new NotImplementedException();
        }
    }
}