using ocpp_server_modelo;
using System;

namespace ocpp_server_control
{
    public static class ControlEstacion
    {
        private static Respuesta Agregar(string pId, string pNombre, string pDireccion, string pUbicacion)
        {
            Respuesta r = new Respuesta("ControlEstacion.Agregar");

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

                if (e != null)
                    throw new Exception("Ya existe una Estacion con el Id " + Id);

                if(pNombre != null || pNombre.Length <= 0)
                    throw new Exception("El campo Nombre es obligatorio");

                if (pDireccion != null || pDireccion.Length <= 0)
                    throw new Exception("El campo Direccion es obligatorio");

                if (pUbicacion != null || pUbicacion.Length <= 0)
                    throw new Exception("El campo Ubicacion es obligatorio");

                e = new Estacion();

                e.Id = Id;
                e.Nombre = pNombre;
                e.Direccion = pDireccion;
                e.Ubicacion = pUbicacion;

                Servidor.getInstancia().ColeccionEstacion.Agregar(e);
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

        private static Respuesta Eliminar(string pId)
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

        public static Respuesta AgregarPuntoCarga(string pEstacionId, string pPuntoCargaId)
        {
            Respuesta r = new Respuesta("ControlEstacion.AgregarPuntoCarga");

            try
            {
                int EstacionId;
                
                try
                {
                    EstacionId = Convert.ToInt32(pEstacionId);
                }
                catch
                {
                    throw new Exception("El EstacionId debe contener valores numericos");
                }

                int PuntoCargaId;

                try
                {
                    PuntoCargaId = Convert.ToInt32(pPuntoCargaId);
                }
                catch
                {
                    throw new Exception("El PuntoCargaId debe contener valores numericos");
                }

                Estacion e = Servidor.getInstancia().ColeccionEstacion.BuscarPorId(EstacionId);

                if(e==null)
                    throw new Exception("No existe una Estacion con el Id " + EstacionId);

                PuntoCarga p = Servidor.getInstancia().ColeccionPuntoCarga.BuscarPorId(PuntoCargaId);

                if(p==null)
                    throw new Exception("No existe el PuntoCarga con el Id " + PuntoCargaId);

                if(e.ColeccionPuntoCarga.BuscarPorId(PuntoCargaId) != null)
                    throw new Exception("Ya se encuentra asociado el Punto de Carga a la Estacion");

                e.ColeccionPuntoCarga.Agregar(p);
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

        
    }
}
