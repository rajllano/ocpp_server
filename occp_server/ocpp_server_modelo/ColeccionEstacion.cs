using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class ColeccionEstacion : Coleccion<Estacion>, IIterable
    {
        public object Iterador()
        {
            return new IteradorColeccionEstacion(this);
        }
    }
}