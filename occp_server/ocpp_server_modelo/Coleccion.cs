using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class Coleccion<T>
    {
        public List<T> Lista { get; set; }

        public Coleccion()
        {
            this.Lista = new List<T>();
        }

        ~Coleccion()
        {
            this.Lista = null;

            GC.Collect();
        }
    }
}