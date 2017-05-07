using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class IteradorColeccionPuntoCarga : IIterador<PuntoCarga>
    {
        private ColeccionPuntoCarga Coleccion = null;
        private int Indice;

        public IteradorColeccionPuntoCarga(ColeccionPuntoCarga c)
        {
            this.Coleccion = c;
            this.Indice = -1;
        }

        ~IteradorColeccionPuntoCarga()
        {
            this.Coleccion = null;

            GC.Collect();
        }

        public PuntoCarga Siguiente()
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