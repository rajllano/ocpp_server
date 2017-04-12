using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ocpp_server_modelo;

namespace ocpp_server_control
{
    public static class ControlAplicacion
    {
        private static Servidor Instancia = null;
        
        public static Servidor getInstancia()
        {
            if (Instancia == null)
                Instancia = new Servidor();

            return Instancia;
        }
    }
}
