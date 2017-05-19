/**
 * Clase: ControlPuntoCarga.cs
 * Objetivo: Clase de control para la gestión de los puntos de carga.
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
    public static class ControlPuntoCarga
    {
        public static Respuesta Agregar(string pNumeroSerie, string pMarca, string pModelo)
        {
            Respuesta r = new Respuesta("ControlPuntoCarga.Agregar");

            try
            {
                int Id = ControlId.PuntoCarga();

                PuntoCarga p = Servidor.getInstancia().ColeccionPuntoCarga.BuscarPorId(Id);

                if (p != null)
                    throw new Exception("Ya existe un PuntoCarga con el Id " + Id);

                if (pNumeroSerie.Length <= 0)
                    throw new Exception("El campo NumeroSerie es obligatorio");

                if (pMarca.Length <= 0)
                    throw new Exception("El campo Marca es obligatorio");

                if (pModelo.Length <= 0)
                    throw new Exception("El campo Modelo es obligatorio");

                p = new PuntoCarga();

                p.Id = Id;
                p.NumeroSerie = pNumeroSerie;
                p.Marca = pMarca;
                p.Modelo = pModelo;

                Servidor.getInstancia().ColeccionPuntoCarga.Agregar(p);
                r.Anexo.Add("PuntoCarga",p);
                r.Mensaje += "Se agrego el exitosamente el PuntoCarga con Id " + Id;
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
            Respuesta r = new Respuesta("ControlPuntoCarga.Eliminar");

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

                PuntoCarga p = Servidor.getInstancia().ColeccionPuntoCarga.BuscarPorId(Id);

                if (p == null)
                    throw new Exception("No existe un PuntoCarga con el Id " + Id);

                Servidor.getInstancia().ColeccionPuntoCarga.Eliminar(p);
                r.Mensaje += "Se elimino exitosamente el punto de carga con Id " + Id;
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
            Respuesta r = new Respuesta("ControlPuntoCarga.BuscarPorId");

            try
            {
                PuntoCarga v = Servidor.getInstancia().ColeccionPuntoCarga.BuscarPorId(Convert.ToInt32 (pId));

                if (v == null)
                    throw new Exception("No existe punto de carga con el Id " + pId);

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

        public static Respuesta BuscarPorNumeroSerie(string pNumeroSerie)
        {
            Respuesta r = new Respuesta("ControlPuntoCarga.BuscarPorNumeroSerie");

            try
            {
                PuntoCarga v = Servidor.getInstancia().ColeccionPuntoCarga.BuscarPorNumeroSerie(pNumeroSerie);

                if (v == null)
                    throw new Exception("No existe punto de carga con el numero serie " + pNumeroSerie);

                r.Anexo.Add("Punto de Carga", v);
                r.Mensaje = "Punto de Carga con el numero serie " + pNumeroSerie + " fue encontrado";
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
            Respuesta r = new Respuesta("ControlPuntoCarga.Listar");

            try
            {
                ColeccionPuntoCarga cv = Servidor.getInstancia().ColeccionPuntoCarga;

                if (cv.Tamano() == 0)
                    throw new Exception("No existen puntos de carga");

                r.Anexo.Add("ColeccionPuntoCarga", cv);
                r.Mensaje = "Cantidad de puntos de carga " + cv.Tamano();
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
