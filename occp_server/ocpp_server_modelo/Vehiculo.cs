using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class Vehiculo : IClonacion<Vehiculo>
    {
        public string Placa { get; set; }

        public string Tag { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Propietario { get; set; }

        public Vehiculo Clonar()
        {
            Vehiculo h = new Vehiculo();

            h.Placa = this.Placa;
            h.Tag = this.Tag;
            h.Marca = this.Marca;
            h.Modelo = this.Modelo;
            h.Propietario = this.Propietario;

            return h;
        }
    }
}