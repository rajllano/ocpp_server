using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class IteradorColeccionEstacion : IIterador<Estacion>
    {
        private ColeccionEstacion Coleccion = null;
        private int Indice;

        public IteradorColeccionEstacion(ColeccionEstacion c)
        {
            this.Coleccion = c;
            this.Indice = -1;
        }

        ~IteradorColeccionEstacion()
        {
            this.Coleccion = null;

            GC.Collect();
        }

        public Estacion Siguiente()
        {
            Indice++;

            if(Indice < this.Coleccion.Tamano())
            {
                return this.Coleccion.Elemento(Indice);
            }

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