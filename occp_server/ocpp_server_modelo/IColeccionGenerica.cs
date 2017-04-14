using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public interface IColeccionGenerica<T, I> : IColeccion<T>, IObservable, IIterable<I>
    {
    }
}