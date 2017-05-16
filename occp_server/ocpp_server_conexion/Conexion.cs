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
        private string _IPPuntoCarga;
        private string _puertoPuntoCarga;
        private string _IPServidor;
        private string _puertoServidor;
        Server objServidor;

        public string IP_PUNTO_CARGA
        {
            set
            {
                _IPPuntoCarga = value;
            }
            get
            {
                return this._IPPuntoCarga;
            }
        }

        public string PUERTO_PUNTO_CARGA
        {
            set
            {
                _puertoPuntoCarga = value;
            }
            get
            {
                return this._puertoPuntoCarga;
            }
        }

        private string IP_SERVIDOR
        {
            set
            {
                _IPServidor = value;
            }
            get
            {
                return this._IPServidor;
            }
        }

        private string PUERTO_SERVIDOR
        {
            set
            {
                _puertoServidor = value;
            }
            get
            {
                return this._puertoServidor;
            }
        }

        public Conexion()
        {
            this.IP_PUNTO_CARGA = obtenerIp();
            this.PUERTO_PUNTO_CARGA = "90";
            this.IP_SERVIDOR = obtenerIp();
            this.PUERTO_SERVIDOR = "90";
            objServidor = new Server(this.IP_SERVIDOR, this.PUERTO_SERVIDOR);
            objServidor.OnDataReceived += new OnReceivedDelegate(servidor_OnDataReceived);
            objServidor.Start();
        }

        public void servidor_OnDataReceived(Object sender, ReceivedArguments R)
        {
            Console.WriteLine("IP: " + R.Ip + "envia: " + R.ReceivedData);
        }

        public bool enviarMensajeCliente(string vNombrePuntoCarga, string vMensaje)
        {
            bool estadoConexion;
            
            try
            {   
                estadoConexion = true;
                objServidor.SendTo(this.IP_PUNTO_CARGA, vMensaje);
                Console.WriteLine("Estado conexion con servidor: " + estadoConexion);
            }
            catch (Exception ex)
            {
                estadoConexion = false;
                Console.WriteLine("Error: " + ex.Message);
                //.Mensaje += ex.Message;
            }
            finally
            {
                objServidor.Stop();
                //ControlLog.Registrar(r);
            }

            return estadoConexion;
        }

        public string obtenerIp()
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
    }

}
