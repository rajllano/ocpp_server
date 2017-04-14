using ocpp_server_modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public interface IIterable<I>
    {
        IIterador<I> Iterador();
    }
}