/**
 * Clase: Respuesta.cs
 * Objetivo: encapsular objetos de tipo respuesta que me 
 * permitiran hacer gestión sobre los logs del sistema.
 * Fecha modificación: Mayo de 2017
 **/
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

            this.Anexo = new Dictionary<string, object>();
            this.Anexo.Add("Mensaje", null);
        }

        public Boolean Estado { get; set; }

        public string Mensaje { get; set; }

        public Dictionary<string,Object> Anexo { get; set; }
    }
}
