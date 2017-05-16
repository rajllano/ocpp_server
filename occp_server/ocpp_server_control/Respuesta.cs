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
            this.Anexo = null;
            this.Anexo2 = new Dictionary<string, object>();
        }

        public Boolean Estado { get; set; }

        public string Mensaje { get; set; }

        public Object Anexo { get; set; }

        public Dictionary<string,Object> Anexo2 { get; set; }
    }
}
