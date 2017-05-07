using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class ColeccionVehiculo : Coleccion<Vehiculo>, IIterable
    {
        public Vehiculo BuscarPorPlaca(string pPlaca)
        {
            Vehiculo v = null;
            IteradorColeccionVehiculo i = (IteradorColeccionVehiculo)Iterador();

            while (i.tieneSiguiente())
            {
                v = i.Siguiente();

                if (v.Placa == pPlaca)
                    return v;
            }

            return null;
        }

        public Vehiculo BuscarPorTag(string pTag)
        {
            Vehiculo v = null;
            IteradorColeccionVehiculo i = (IteradorColeccionVehiculo)Iterador();

            while (i.tieneSiguiente())
            {
                v = i.Siguiente();

                if (v.Tag == pTag)
                    return v;
            }

            return null;
        }

        public object Iterador()
        {
            return new IteradorColeccionVehiculo(this);
        }
    }
}