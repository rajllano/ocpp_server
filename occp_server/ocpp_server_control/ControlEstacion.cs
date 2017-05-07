using ocpp_server_modelo;
using System;

namespace ocpp_server_control
{
    public static class ControlEstacion
    {
        private static Respuesta Agregar(string Id, string Nombre, string Direccion, string Ubicacion)
        {
            Respuesta r = new Respuesta("ControlEstacion.Agregar");

            try
            {
                int EstacionId;

                try
                {
                    EstacionId = Convert.ToInt32(Id);
                }
                catch
                {
                    throw new Exception("El Id debe contener valores numericos");
                }

                Estacion e = Servidor.getInstancia().ColeccionEstacion.BuscarPorId(EstacionId);

                if (e != null)
                    throw new Exception("Ya existe una estacion con el Id " + Id);

                e = new Estacion();

                e.Nombre = Nombre;
                e.Direccion = Direccion;
                e.Ubicacion = Ubicacion;

                Servidor.getInstancia().ColeccionEstacion.Agregar(e);
            }
            catch(Exception ex)
            {
                r.Estado = false;
                r.Mensaje += ex.Message;

                ControlLog.Registrar(r);
            }

            return r;
        }

        private static Respuesta Eliminar(string Id)
        {
            Respuesta r = new Respuesta("ControlEstacion.Eliminar");

            try
            {
                int EstacionId;

                try
                {
                    EstacionId = Convert.ToInt32(Id);
                }
                catch
                {
                    throw new Exception("El Id debe contener valores numericos");
                }

                Estacion e = Servidor.getInstancia().ColeccionEstacion.BuscarPorId(EstacionId);

                if(e == null)
                {
                    r.Estado = false;
                    r.Mensaje = "No existe Id " + Id.ToString();
                }
                else
                    Servidor.getInstancia().ColeccionEstacion.Eliminar(e);
            }
            catch (Exception ex)
            {
                r.Estado = false;
                r.Mensaje += ex.Message;

                ControlLog.Registrar(r);
            }

            return r;
        }

        public static Respuesta AgregarPuntoCarga(string IdEstacion, string IdPuntoCarga)
        {
            Respuesta r = new Respuesta("ControlEstacion.AgregarPuntoCarga");

            try
            {


            }
            catch(Exception ex)
            {
                r.Estado = false;
                r.Mensaje += ex.Message;

                ControlLog.Registrar(r);
            }

            return r;
        }
    }
}
