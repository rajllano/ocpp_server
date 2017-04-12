using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class ColeccionLog : Coleccion, IObservador
    {
        public void Actualizar(object o)
        {
            Log l = new ocpp_server_modelo.Log();

            l.FechaHora = DateTime.Now;
            l.Evento = o.ToString();

            this.Agregar(l);
        }
    }
}