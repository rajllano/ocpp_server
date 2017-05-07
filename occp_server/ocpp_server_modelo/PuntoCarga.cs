using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class PuntoCarga : IClonacion<PuntoCarga>
    {
        public int Id { get; set; }

        public string NumeroSerie { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public EEstadoPuntoCarga EEstadoPuntoCarga { get; set; }

        public EEstadoConectorPuntoCarga EEstadoConectorPuntoCarga { get; set; }

        public PuntoCarga Clonar()
        {
            PuntoCarga p = new PuntoCarga();

            p.Id = this.Id;
            p.NumeroSerie = this.NumeroSerie;
            p.Marca = this.Marca;
            p.Modelo = this.Modelo;
            p.EEstadoPuntoCarga = this.EEstadoPuntoCarga;
            p.EEstadoConectorPuntoCarga = this.EEstadoConectorPuntoCarga;

            return p;
        }
    }
}