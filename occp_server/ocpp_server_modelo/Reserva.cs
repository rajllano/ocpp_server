/**
 * Clase: Reserva.cs
 * Objetivo: Clase que define una reserva.
 * Fecha modificación: Mayo de 2017
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class Reserva
    {
        public int Id { get; set; }

        public PuntoCarga PuntoCarga { get; set; }

        public Vehiculo Vehiculo { get; set; }

        public DateTime FechaHora { get; set; }

        public int Tiempo { get; set; }

        public double ValorRecarga { get; set; }

        public double EnergiaRecarga { get; set; }

        public DateTime FechaRegistro { get; set; }

        public string NumeroSerie { get; set; }

        public EEstadoReserva EEstadoReserva { get; set; }
    }
}