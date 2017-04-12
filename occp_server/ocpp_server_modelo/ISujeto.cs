using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public interface ISujeto
    {
        void RegistrarObservador(IObservador o);
        void EliminarObservador(IObservador o);
        void NotificarObservador();
    }
}