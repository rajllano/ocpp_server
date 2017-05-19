/**
 * Clase: ControlEstacion.cs
 * Objetivo: Clase de control para la gestión de estaciones.
 * Fecha modificación: Mayo de 2017
 **/
using ocpp_server_modelo;
using System;

namespace ocpp_server_control
{
    public static class ControlEstacion
    {
        public static Respuesta Agregar(Estacion e)
        {
            return Agregar(e.Nombre,e.Direccion,e.Ubicacion);
        }

        public static Respuesta Agregar(string pNombre, string pDireccion, string pUbicacion)
        {
            Respuesta r = new Respuesta("ControlEstacion.Agregar");

            try
            {
                int Id = ControlId.Estacion();

                Estacion e = Servidor.getInstancia().ColeccionEstacion.BuscarPorId(Id);

                if (e != null)
                    throw new Exception("Ya existe una Estacion con el Id " + Id);

                if(pNombre.Length <= 0)
                    throw new Exception("El campo Nombre es obligatorio");

                if (pDireccion.Length <= 0)
                    throw new Exception("El campo Direccion es obligatorio");

                if (pUbicacion.Length <= 0)
                    throw new Exception("El campo Ubicacion es obligatorio");

                e = new Estacion();

                e.Id = Id;
                e.Nombre = pNombre;
                e.Direccion = pDireccion;
                e.Ubicacion = pUbicacion;

                Servidor.getInstancia().ColeccionEstacion.Agregar(e);

                r.Anexo.Add("Estacion", e);
                r.Mensaje += "Se agrego el exitosamente la Estacion con Id " + Id;
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

        public static Respuesta Eliminar(string pId)
        {
            Respuesta r = new Respuesta("ControlEstacion.Eliminar");

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

                Estacion e = Servidor.getInstancia().ColeccionEstacion.BuscarPorId(Id);

                if (e == null)
                    throw new Exception("No existe una Estacion con el Id " + Id);
                
                Servidor.getInstancia().ColeccionEstacion.Eliminar(e);
                r.Mensaje += "Se elimino exitosamente la Estacion con Id " + Id;
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

        public static Respuesta BuscarPorId(int pId)
        {
            Respuesta r = new Respuesta("ControlEstacion.BuscarPorId");

            try
            {
                Estacion v = Servidor.getInstancia().ColeccionEstacion.BuscarPorId(pId);

                if (v == null)
                    throw new Exception("No existe una estacion de id " + pId.ToString());

                r.Anexo.Add("Estacion", v);
                r.Mensaje = "La estacion de id " + pId.ToString() + " fue encontrada";
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
            Respuesta r = new Respuesta("ControlEstacion.Listar");

            try
            {
                ColeccionEstacion  cv = Servidor.getInstancia().ColeccionEstacion;

                if (cv.Tamano() == 0)
                    throw new Exception("No existen estaciones");

                r.Anexo.Add("ColeccionEstacion", cv);
                r.Mensaje = "Cantidad de estaciones " + cv.Tamano();
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
