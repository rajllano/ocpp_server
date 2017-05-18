using System;
using NetworksApi.TCP.SERVER;
using System.Net;

namespace ocpp_server_conexion
{
    
    public class Conexion
    {
        //private Server objServidor;

        public Conexion(string uno, string dos)
        {
            /*objServidor = new Server(obtenerIp(), "90");

            objServidor.OnClientConnected += new OnConnectedDelegate(servidor_OnClientConnected);
            objServidor.OnClientDisconnected += new OnDisconnectedDelegate(servidor_OnClientDisconnected);
            objServidor.OnServerError += new OnErrorDelegate(servidor_OnServerError);
            objServidor.OnDataReceived += new OnReceivedDelegate(servidor_OnDataReceived);

            Console.WriteLine("Iniciando servidor...");
            objServidor.Start();
            Console.WriteLine("Servidor iniciado");*/
        }

        ~Conexion()
        {
            /*objServidor.Stop();
            objServidor = null;

            GC.Collect();*/
        }

        private string obtenerIp()
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

        public void servidor_OnClientConnected(Object sender, ConnectedArguments R)
        {
            Console.WriteLine("Conected: " + R.Name);
        }

        public void servidor_OnClientDisconnected(Object sender, DisconnectedArguments R)
        {
            Console.WriteLine("Disconected: " + R.Name);
        }

        public void servidor_OnServerError(Object sender, ErrorArguments R)
        {
            Console.WriteLine("Error: " + R.ErrorMessage);
        }

        public void servidor_OnDataReceived(Object sender, ReceivedArguments R)
        {
            Console.WriteLine("IP: " + R.Ip + " recibido: " + R.ReceivedData);
        }

        public void detenerServidor()
        {
            //objServidor.Stop();
        }

        public bool enviarMensajeCliente(string Ip, string Mensaje)
        {
            bool estado = false;
            /*Console.WriteLine("Se enviará mensaje desde servidor: " + estado);
            objServidor.SendTo(Ip, Mensaje);
            estado = true;
            Console.WriteLine("Estado conexion con servidor: " + estado); */

            return estado;
        }
    }
}
