using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class IteradorColeccionReserva : IIterador<Reserva>
    {
        private ColeccionReserva Coleccion = null;
        private int Indice;

        public IteradorColeccionReserva(ColeccionReserva c)
        {
            this.Coleccion = c;
            this.Indice = -1;
        }

        ~IteradorColeccionReserva()
        {
            this.Coleccion = null;

            GC.Collect();
        }

        public Reserva Siguiente()
        {
            Indice++;

            if (Indice < this.Coleccion.Tamano())
                return this.Coleccion.Elemento(Indice);

            return null;
        }

        public bool tieneSiguiente()
        {
            if (this.Indice + 1 < this.Coleccion.Tamano())
                return true;

            return false;
        }
    }
}