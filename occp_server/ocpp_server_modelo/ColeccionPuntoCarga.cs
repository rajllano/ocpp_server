﻿/**
 * Clase: ColeccionPuntoCarga.cs
 * Objetivo: Claseque hereda y define colección de puntos de carga y la gestión de iteración de las coleccion.
 * Fecha modificación: Mayo de 2017
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class ColeccionPuntoCarga : Coleccion<PuntoCarga>, IIterable
    {
        public PuntoCarga BuscarPorId(int Id)
        {
            PuntoCarga p = null;
            IteradorColeccionPuntoCarga i = (IteradorColeccionPuntoCarga)Iterador();

            while (i.tieneSiguiente())
            {
                p = i.Siguiente();

                if (p.Id == Id)
                    return p;
            }

            return null;
        }

        public PuntoCarga BuscarPorNumeroSerie(string numeroSerie)
        {
            PuntoCarga p = null;
            IteradorColeccionPuntoCarga i = (IteradorColeccionPuntoCarga)Iterador();

            while (i.tieneSiguiente())
            {
                p = i.Siguiente();

                if (p.NumeroSerie == numeroSerie)
                    return p;
            }

            return null;
        }

        public object Iterador()
        {
            return new IteradorColeccionPuntoCarga(this);
        }
    }
}