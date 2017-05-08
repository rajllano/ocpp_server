using ocpp_server_modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocpp_server_control
{
    public static class ControlReserva
    {
        public static Respuesta AgregarPlaca(string pVehiculoPlaca, string pPuntoCargaId, string pDia, string pMes, string pAno, string pHora, string pMinuto, string pTiempo)
        {
            Respuesta r = new Respuesta("ControlReserva.Agregar");

            try
            {
                Vehiculo v = Servidor.getInstancia().ColeccionVehiculo.BuscarPorPlaca(pVehiculoPlaca);

                if (v == null)
                    throw new Exception("El Vehiculo no existe");

                int PuntoCargaId;

                try
                {
                    PuntoCargaId = Convert.ToInt32(pPuntoCargaId);
                }
                catch
                {
                    throw new Exception("El PuntoCargaId debe contener valores numericos");
                }

                PuntoCarga p = Servidor.getInstancia().ColeccionPuntoCarga.BuscarPorId(PuntoCargaId);

                if(p == null)
                    throw new Exception("El PuntoCarga no existe");

                int Dia, Mes, Ano;

                try
                {
                    Dia = Convert.ToInt32(pDia);
                    Mes = Convert.ToInt32(pMes);
                    Ano = Convert.ToInt32(pAno);
                }
                catch
                {
                    throw new Exception("Los campos Dia, Mes, Año deben ser numericos");
                }

                int Hora, Minuto;

                try
                {
                    Hora = Convert.ToInt32(pHora);
                    Minuto = Convert.ToInt32(pMinuto);
                }
                catch
                {
                    throw new Exception("Los campos Hora, Minuto deben ser numericos");
                }

                Reserva rv = new Reserva();

                try
                {
                    rv.FechaHora = Convert.ToDateTime(Dia + "/" + Mes + "/" + Ano + " " + Hora + ":" + Minuto);
                }
                catch
                {
                    throw new Exception("Por favor verifique los valores de fecha y hora");
                }

                rv.Id = 1;
                rv.FechaRegistro = DateTime.Now;
                rv.Vehiculo = v;
                rv.EEstadoReserva = EEstadoReserva.APROBADA;
                rv.EnergiaRecarga = 0;
                rv.PuntoCarga = p;

                Servidor.getInstancia().ColeccionReserva.Agregar(rv);
                r.Mensaje += "Se agrego el exitosamente la Reserva con Id " + rv.Id;
            }
            catch (Exception ex)
            {
                r.Estado = false;
                r.Mensaje += ex.Message;
            }
            finally
            {
                ControlLog.Registrar(r);
            }

            return r;
        }
    }
}
