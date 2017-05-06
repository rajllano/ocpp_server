using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class ColeccionVehiculo : Coleccion<Vehiculo>
    {
        public void Agregar(Vehiculo Elemento)
        {
            throw new NotImplementedException();
        }

        public Vehiculo Elemento(int Indice)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Vehiculo Elemento)
        {
            throw new NotImplementedException();
        }

        public void EliminarObservador(IObservador o)
        {
            throw new NotImplementedException();
        }

        public IIterador<IteradorColeccionVehiculo> Iterador()
        {
            throw new NotImplementedException();
        }

        public void NotificarObservador()
        {
            throw new NotImplementedException();
        }

        public void RegistrarObservador(IObservador o)
        {
            throw new NotImplementedException();
        }

        public int Tamano()
        {
            throw new NotImplementedException();
        }
    }
}