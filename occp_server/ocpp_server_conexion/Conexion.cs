using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworksApi.TCP.SERVER;
using System.Net;

namespace ocpp_server_conexion
{
    
    public class Conexion
    {
        Server objServidor;

        public Conexion(string vIPServidor, string vPuertoServidor)
        {
            objServidor = new Server(vIPServidor, vPuertoServidor);
            objServidor.OnClientConnected += new OnConnectedDelegate(servidor_OnClientConnected);
            objServidor.OnClientDisconnected += new OnDisconnectedDelegate(servidor_OnClientDisconnected);
            objServidor.OnServerError += new OnErrorDelegate(servidor_OnServerError);
            objServidor.OnDataReceived += new OnReceivedDelegate(servidor_OnDataReceived);
            objServidor.Start();
            Console.WriteLine("Servidor iniciado...");
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
            Console.WriteLine("IP: " + R.Ip + " envia: " + R.ReceivedData);
        }

        public void detenerServidor()
        {
            objServidor.Stop();
        }

        public bool enviarMensajeCliente(string vNombrePuntoCarga, string vMensaje)
        {
            bool estado = false;
            Console.WriteLine("Se enviará mensaje desde servidor: " + estado);
            objServidor.SendTo(vNombrePuntoCarga, vMensaje);
            estado = true;
            Console.WriteLine("Estado conexion con servidor: " + estado);            

            return estado;
        }

    }

}
