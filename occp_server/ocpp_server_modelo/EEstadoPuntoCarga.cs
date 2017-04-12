using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public enum EEstadoPuntoCarga
    {
        CARGANDO = 1,
        DESOCUPADO = 2,
        OPERATIVO = 3,
        RESERVADO = 4
    }
}