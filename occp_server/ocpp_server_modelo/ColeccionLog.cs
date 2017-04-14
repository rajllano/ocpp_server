using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class ColeccionLog : Coleccion<object>, IObservador, IColeccionGenerica<Log, IteradorColeccionLog>
    {
        public void Actualizar(object o)
        {
            throw new NotImplementedException();
        }

        public void Agregar(Log Elemento)
        {
            throw new NotImplementedException();
        }

        public Log Elemento(int Indice)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Log Elemento)
        {
            throw new NotImplementedException();
        }

        public void EliminarObservador(IObservador o)
        {
            throw new NotImplementedException();
        }

        public IIterador<IteradorColeccionLog> Iterador()
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