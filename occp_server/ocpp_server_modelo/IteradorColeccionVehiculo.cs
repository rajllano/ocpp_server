using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class IteradorColeccionVehiculo : IIterador<Vehiculo>
    {
        private ColeccionVehiculo Coleccion = null;
        private int Indice;

        public IteradorColeccionVehiculo(ColeccionVehiculo c)
        {
            this.Coleccion = c;
            this.Indice = -1;
        }

        ~IteradorColeccionVehiculo()
        {
            this.Coleccion = null;

            GC.Collect();
        }

        public Vehiculo Siguiente()
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