using ocpp_server_modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworksApi.TCP.SERVER;
using System.Net;

namespace ocpp_server_control
{
    public static class ControlComunicaciones
    {
        private static Server objServidor = null;

        private static string obtenerIp()
        {
            string IPLocal = "0.0.0.0";
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    IPLocal = ip.ToString();
                }
            }

            return IPLocal;
        }

        private static void servidor_OnClientConnected(Object sender, ConnectedArguments R)
        {
            Respuesta r = new Respuesta("ControlComunicaciones.ClienteConectado");

            r.Mensaje += "Ip [" + R.Ip + "] - Id [" + R.Name + "]";

            ControlLog.Registrar(r);
        }

        private static void servidor_OnClientDisconnected(Object sender, DisconnectedArguments R)
        {
            Respuesta r = new Respuesta("ControlComunicaciones.ClienteDesconectado");

            r.Mensaje += "Ip [" + R.Ip + "] - Id [" + R.Name + "]";

            ControlLog.Registrar(r);
        }

        private static void servidor_OnServerError(Object sender, ErrorArguments R)
        {
            Respuesta r = new Respuesta("ControlComunicaciones.ServidorError");

            r.Mensaje += "Mensaje [" + R.ErrorMessage + "] - Excepcion [" + R.Exception + "]";

            ControlLog.Registrar(r);
        }

        private static void servidor_OnDataReceived(Object sender, ReceivedArguments R)
        {
            Respuesta r = new Respuesta("ControlComunicaciones.ServidorRecibido");

            r.Mensaje += "Ip [" + R.Ip + "] - Id [" + R.Name + "] - Dato [" + R.ReceivedData + "]";
            
            ControlLog.Registrar(r);

            if (R.ReceivedData.Contains("SOL_RESERVA"))
            {
                String Ip = obtenerIp();
                Respuesta r0 = ControlComunicaciones.Enviar(Ip, "LE ENVIE OBJETO");


                JSon.SerializarReser();

                ControlLog.Registrar(r0);
            }

        }

        public static Respuesta IniciarDetener()
        {
            Respuesta r = new Respuesta("ControlComunicaciones.IniciarDetener");

            try
            {
                if (objServidor == null) //Iniciar
                {
                    String Ip = obtenerIp();
                    String Puerto = "90";

                    objServidor = new Server(Ip, Puerto);

                    objServidor.OnClientConnected += new OnConnectedDelegate(servidor_OnClientConnected);
                    objServidor.OnClientDisconnected += new OnDisconnectedDelegate(servidor_OnClientDisconnected);
                    objServidor.OnServerError += new OnErrorDelegate(servidor_OnServerError);
                    objServidor.OnDataReceived += new OnReceivedDelegate(servidor_OnDataReceived);

                    objServidor.Start();

                    r.Anexo.Add("Comunicacion", true);
                    r.Mensaje += "Servidor iniciado con exito. Ip [" + Ip + "] - Puerto [" + Puerto + "]";
                }
                else //Detener
                {
                    objServidor.Stop();
                    objServidor = null;

                    r.Anexo.Add("Comunicacion", false);
                    r.Mensaje += "Servidor detenido correctamente";
                }
            }
            catch (Exception ex)
            {
                r.Estado = false;
                r.Mensaje = ex.Message;
            }
            finally
            {
                ControlLog.Registrar(r);
            }

            return r;
        }

        public static Boolean Detener()
        {
            Respuesta r = new Respuesta("ControlComunicaciones.Detener");

            try
            {
                if (objServidor == null)
                    throw new Exception("El servidor se encuentra detenido");

                objServidor.Stop();
                objServidor = null;

                r.Mensaje += "Servidor detenido correctamente";
            }
            catch (Exception ex)
            {
                r.Estado = false;
                r.Mensaje = ex.Message;
            }
            finally
            {
                ControlLog.Registrar(r);
            }

            return r.Estado;
        }

        public static Respuesta Enviar(string Ip, string Mensaje)
        {
            Respuesta r = new Respuesta("ControlComunicaciones.Enviar");

            try
            {
                r.Mensaje += "Ip[" + Ip + "] - Mensaje [" + Mensaje + "]";

                objServidor.SendTo(Ip, Mensaje);
                r.Mensaje += " - ENVIO EXITOSO";
            }
            catch(Exception ex)
            {
                r.Estado = false;
                r.Mensaje += " - ERROR: " + ex.Message;
            }
            finally
            {
                ControlLog.Registrar(r);
            }

            return r;
        }
    }
}
