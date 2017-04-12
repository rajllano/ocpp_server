using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class IteradorColeccion : IIterador
    {
        private List<Object> Lista;

        public IteradorColeccion(List<Object> Lista)
        {
            this.Lista = Lista;
        }

        public object Siguiente()
        {
            throw new NotImplementedException();
        }

        public bool tieneSiguiente()
        {
            throw new NotImplementedException();
        }
    }
}