/**
 * Clase: ColeccionEstacion.cs
 * Objetivo: Claseque hereda y define colección de estaciones y la gestión de iteración de las coleccion.
 * Fecha modificación: Mayo de 2017
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class ColeccionEstacion : Coleccion<Estacion>, IIterable
    {
        public Estacion BuscarPorId(int Id)
        {
            Estacion e = null;
            IteradorColeccionEstacion i = (IteradorColeccionEstacion)Iterador();

            while(i.tieneSiguiente())
            {
                e = i.Siguiente();

                if (e.Id == Id)
                    return e;
            }

            return null;
        }

        public object Iterador()
        {
            return new IteradorColeccionEstacion(this);
        }
    }
}