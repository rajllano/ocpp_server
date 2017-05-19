/**
 * Clase: ControlReserva.cs
 * Objetivo: Clase de control para la gestión de los reservas.
 * Fecha modificación: Mayo de 2017
 **/
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
        public static Respuesta AgregarPorPlaca(string pVehiculoPlaca, string pPuntoCargaId, string pDia, string pMes, string pAno, string pHora, string pMinuto, string pTiempo)
        {
            Respuesta r = new Respuesta("ControlReserva.AgregarPorPlaca");

            try
            {
                Vehiculo v = Servidor.getInstancia().ColeccionVehiculo.BuscarPorPlaca(pVehiculoPlaca);

                if(v==null)
                    throw new Exception("El vehiculo de placa " + pVehiculoPlaca + " no existe");

                int PuntoCargaId = 0;

                try
                {
                    PuntoCargaId = Convert.ToInt32(pPuntoCargaId);
                }
                catch
                {
                    throw new Exception("El Id del punto de carga debe ser numerico");
                }

                PuntoCarga p = Servidor.getInstancia().ColeccionPuntoCarga.BuscarPorId(PuntoCargaId);

                if(p==null)
                    throw new Exception("El punto de carga " + pPuntoCargaId + " no existe");

                r = Agregar(r, v, p, pDia, pMes, pAno, pHora, pMinuto, pTiempo);
            }
            catch(Exception ex)
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

        public static Respuesta AgregarPorTag(string pVehiculoTag, string pPuntoCargaId, string pDia, string pMes, string pAno, string pHora, string pMinuto, string pTiempo)
        {
            Respuesta r = new Respuesta("ControlReserva.AgregarPorTag");

            try
            {
                Vehiculo v = Servidor.getInstancia().ColeccionVehiculo.BuscarPorTag(pVehiculoTag);

                if (v == null)
                    throw new Exception("El vehiculo de placa " + pVehiculoTag + " no existe");

                int PuntoCargaId = 0;

                try
                {
                    PuntoCargaId = Convert.ToInt32(pPuntoCargaId);
                }
                catch
                {
                    throw new Exception("El Id del punto de carga debe ser numerico");
                }

                PuntoCarga p = Servidor.getInstancia().ColeccionPuntoCarga.BuscarPorId(PuntoCargaId);

                if (p == null)
                    throw new Exception("El punto de carga " + pPuntoCargaId + " no existe");

                r = Agregar(r, v, p, pDia, pMes, pAno, pHora, pMinuto, pTiempo);
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

        private static Respuesta Agregar(Respuesta r, Vehiculo v, PuntoCarga p, string pDia, string pMes, string pAno, string pHora, string pMinuto, string pTiempo)
        {
            try
            {
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

                rv.Id = ControlId.Reserva();
                rv.FechaRegistro = DateTime.Now;
                rv.Vehiculo = v;
                rv.EEstadoReserva = EEstadoReserva.APROBADA;
                rv.EnergiaRecarga = 0;
                rv.PuntoCarga = p;

                Servidor.getInstancia().ColeccionReserva.Agregar(rv);
                r.Anexo.Add("Reserva",rv);
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

        public static Respuesta Eliminar(string pId)
        {
            Respuesta r = new Respuesta("ControlReserva.Eliminar");

            try
            {
                int Id;

                try
                {
                    Id = Convert.ToInt32(pId);
                }
                catch
                {
                    throw new Exception("El Id debe contener valores numericos");
                }

                Reserva  p = Servidor.getInstancia().ColeccionReserva.BuscarPorId(Id);

                if (p == null)
                    throw new Exception("No existe una reserva con el Id " + Id);

                Servidor.getInstancia().ColeccionReserva.Eliminar(p);
                r.Mensaje += "Se elimino exitosamente la reserva con Id " + Id;
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

        public static Respuesta BuscarPorId(string pId)
        {
            Respuesta r = new Respuesta("ControlReserva.BuscarPorId");
            
            try
            {
                Reserva  v = Servidor.getInstancia().ColeccionReserva.BuscarPorId(Convert.ToInt32(pId));

                if (v == null)
                    throw new Exception("No existe una reserva con el Id " + pId);

                r.Anexo.Add("Punto de Carga", v);
                r.Mensaje = "Punto de Carga con el Id " + pId + " fue encontrado";
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

        public static Respuesta Listar()
        {
            Respuesta r = new Respuesta("ControlReserva.Listar");

            try
            {
                ColeccionReserva cv = Servidor.getInstancia().ColeccionReserva;

                if (cv.Tamano() == 0)
                    throw new Exception("No existen reservas");

                r.Anexo.Add("ColeccionReserva", cv);
                r.Mensaje = "Cantidad de reservas " + cv.Tamano();
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
