using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class Estacion : IClonacion<Estacion>
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public string Ubicacion { get; set; }

        public ColeccionPuntoCarga ColeccionPuntoCarga { get; set; }

        public Estacion()
        {
            this.ColeccionPuntoCarga = new ColeccionPuntoCarga();
        }

        public Estacion Clonar()
        {
            Estacion e = new Estacion();

            e.Id = this.Id;
            e.Nombre = this.Nombre;
            e.Direccion = this.Direccion;
            e.Ubicacion = this.Ubicacion;

            e.ColeccionPuntoCarga = new ColeccionPuntoCarga();

            return e;
        }
    }
}