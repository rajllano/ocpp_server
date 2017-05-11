/**
 * Clase: ColeccionVehiculo.cs
 * Objetivo: Claseque hereda y define colección de vehiculos y la gestión de iteración de las coleccion.
 * Fecha modificación: Mayo de 2017
 **/
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