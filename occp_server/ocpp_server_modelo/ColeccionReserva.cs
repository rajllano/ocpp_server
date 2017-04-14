using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class ColeccionReserva : IColeccionGenerica<Reserva, IteradorColeccionReserva>
    {
        public void Agregar(Reserva Elemento)
        {
            throw new NotImplementedException();
        }

        public Reserva Elemento(int Indice)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Reserva Elemento)
        {
            throw new NotImplementedException();
        }

        public void EliminarObservador(IObservador o)
        {
            throw new NotImplementedException();
        }

        public IIterador<IteradorColeccionReserva> Iterador()
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