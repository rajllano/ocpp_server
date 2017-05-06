using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class ColeccionReserva : Coleccion<Reserva>, IColeccionGenerica<Reserva>
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

        public object Iterador()
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
    }
}