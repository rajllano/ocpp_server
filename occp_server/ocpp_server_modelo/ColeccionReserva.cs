/**
 * Clase: ColeccionReserva.cs
 * Objetivo: Claseque hereda y define colección de reservas y la gestión de iteración de las coleccion.
 * Fecha modificación: Mayo de 2017
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class ColeccionReserva : Coleccion<Reserva>, IIterable
    {
        public Reserva BuscarPorId(int pId)
        {
            Reserva r = null;

            IteradorColeccionReserva i = (IteradorColeccionReserva)this.Iterador();

            while (i.tieneSiguiente())
            {
                r = i.Siguiente();

                if (r.Id == pId)
                    return r;
            }

            return r;
        }

        public Reserva BuscarPorPlaca(string pPlaca)
        {
            Reserva r = null;

            IteradorColeccionReserva i = (IteradorColeccionReserva)this.Iterador();

            while (i.tieneSiguiente())
            {
                r = i.Siguiente();

                if (r.Vehiculo.Placa == pPlaca)
                    return r;
            }

            return r;
        }

        public Reserva BuscarPorTag(string pTag)
        {
            Reserva r = null;

            IteradorColeccionReserva i = (IteradorColeccionReserva)this.Iterador();

            while (i.tieneSiguiente())
            {
                r = i.Siguiente();

                if (r.Vehiculo.Tag == pTag)
                    return r;
            }

            return r;
        }

        //Puede mejorar
        public Reserva BuscarPorNumeroSerie(string pNumeroSerie)
        {
            Reserva r = null;

            IteradorColeccionReserva i = (IteradorColeccionReserva)this.Iterador();

            while (i.tieneSiguiente())
            {
                r = i.Siguiente();

                if (r.PuntoCarga.NumeroSerie == pNumeroSerie)
                    return r;
            }

            return r;
        }

        public object Iterador()
        {
            return new IteradorColeccionReserva(this);
        }
    }
}