using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class ColeccionVehiculo : Coleccion<Vehiculo>, IIterable
    {
        public object Iterador()
        {
            throw new NotImplementedException();
        }
    }
}