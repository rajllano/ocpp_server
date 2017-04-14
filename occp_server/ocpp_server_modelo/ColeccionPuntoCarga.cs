using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class ColeccionPuntoCarga : Coleccion<object>, IColeccionGenerica<PuntoCarga, IteradorColeccionPuntoCarga>
    {
        public void Agregar(PuntoCarga Elemento)
        {
            throw new NotImplementedException();
        }

        public PuntoCarga Elemento(int Indice)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(PuntoCarga Elemento)
        {
            throw new NotImplementedException();
        }

        public void EliminarObservador(IObservador o)
        {
            throw new NotImplementedException();
        }

        public IIterador<IteradorColeccionPuntoCarga> Iterador()
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