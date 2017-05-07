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
        public static Respuesta Agregar(string pId, string pNumeroSerie, string pMarca, string pModelo)
        {
            Respuesta r = new Respuesta("ControlPuntoCarga.Agregar");

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
    }
}
