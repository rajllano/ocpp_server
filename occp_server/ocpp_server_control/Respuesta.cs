using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocpp_server_control
{
    public class Respuesta
    {
        public Respuesta(string Estado)
        {
            this.Mensaje = "[" + Estado + "] ";

            this.Estado = true;
            this.Objeto = null;
        }

        public Boolean Estado { get; set; }

        public string Mensaje { get; set; }

        public Object Objeto { get; set; }
    }
}
