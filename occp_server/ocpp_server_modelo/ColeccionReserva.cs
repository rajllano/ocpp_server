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

        public object Iterador()
        {
            return new IteradorColeccionReserva(this);
        }
    }
}