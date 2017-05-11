/**
 * Clase: ControlVehiculo.cs
 * Objetivo: Clase de control para la gestión de los vehiculos.
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
    public static class ControlVehiculo
    {
        public static Respuesta Agregar(string pPlaca, string pTag, string pMarca, string pModelo, string pPropietario)
        {
            Respuesta r = new Respuesta("ControlVehiculo.Agregar");

            try
            {
                if (pPlaca.Length <= 0)
                    throw new Exception("El campo Placa es obligatorio");

                if (pTag.Length <= 0)
                    throw new Exception("El campo Tag es obligatorio");

                if (pMarca.Length <= 0)
                    throw new Exception("El campo Marca es obligatorio");

                if (pModelo.Length <= 0)
                    throw new Exception("El campo Modelo es obligatorio");

                if (pPropietario.Length <= 0)
                    throw new Exception("El campo Propietario es obligatorio");

                Vehiculo v = Servidor.getInstancia().ColeccionVehiculo.BuscarPorPlaca(pPlaca);

                if(v != null)
                    throw new Exception("Ya existe un vehiculo con esa placa");

                v = Servidor.getInstancia().ColeccionVehiculo.BuscarPorTag(pTag);

                if(v!=null)
                    throw new Exception("Ya existe un vehiculo con ese Tag");

                v = new Vehiculo();

                v.Placa = pPlaca;
                v.Tag = pTag;
                v.Marca = pMarca;
                v.Modelo = pModelo;
                v.Propietario = pPropietario;

                Servidor.getInstancia().ColeccionVehiculo.Agregar(v);
                r.Mensaje += "Se agrego el exitosamente el Vehiculo de placa " + pPlaca;
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

        public static Respuesta EliminarPorPlaca(string pPlaca)
        {
            Respuesta r = new Respuesta("ControlVehiculo.EliminarPorPlaca");

            try
            {
                Vehiculo v = Servidor.getInstancia().ColeccionVehiculo.BuscarPorPlaca(pPlaca);

                if(v == null)
                    throw new Exception("No existe un Vehiculo de placa " + pPlaca);

                Servidor.getInstancia().ColeccionVehiculo.Eliminar(v);
                r.Mensaje += "Se elimino exitosamente el Vehiculo con Id " + pPlaca;
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

        public static Respuesta EliminarPorTag(string pTag)
        {
            Respuesta r = new Respuesta("ControlVehiculo.EliminarPorTag");

            try
            {
                Vehiculo v = Servidor.getInstancia().ColeccionVehiculo.BuscarPorTag(pTag);

                if (v == null)
                    throw new Exception("No existe un Vehiculo de Tag " + pTag);

                Servidor.getInstancia().ColeccionVehiculo.Eliminar(v);
                r.Mensaje += "Se elimino exitosamente el Vehiculo con Tag " + pTag;
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

        public static Respuesta BuscarPorPlaca(string pPlaca)
        {
            Respuesta r = new Respuesta("ControlVehiculo.BuscarPorPlaca");

            try
            {
                Vehiculo v = Servidor.getInstancia().ColeccionVehiculo.BuscarPorPlaca(pPlaca);

                if(v == null)
                    throw new Exception("No existe un vehiculo con esa placa");

                r.Anexo = v;
                r.Mensaje = "Vehiculo encontrado";
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

        public static Respuesta BuscarPorTag(string pTag)
        {
            Respuesta r = new Respuesta("ControlVehiculo.BuscarPorTag");

            try
            {
                Vehiculo v = Servidor.getInstancia().ColeccionVehiculo.BuscarPorTag(pTag);

                if (v == null)
                    throw new Exception("No existe vehiculo con ese Tag");

                r.Anexo = v;
                r.Mensaje = "Vehiculo encontrado";
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
