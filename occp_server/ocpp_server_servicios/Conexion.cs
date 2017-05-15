using System;
using System.Collections.Generic;
using NetworksApi.TCP.SERVER;
using System.Net;

namespace ocpp_server_servicios
{
    public class Conexion
    {
        private Server Servidor;

        public Conexion(string Puerto)
        {
            string Ip = obtenerIp();

            Servidor = new Server(Ip, Puerto);
            //Servidor.OnClientConnected += new OnConnectedDelegate(servidor_OnClientConnected);
            //Servidor.OnClientDisconnected += new OnDisconnectedDelegate(servidor_OnClientDisconnected);
            //Servidor.OnDataReceived += new OnReceivedDelegate(servidor_OnDataReceived);
            //Servidor.OnServerError += new OnErrorDelegate(servidor_OnServerError);

            Servidor.Start();
        }

        /*private void btEnviarPrivado_Click(object sender, EventArgs e)
        {
            if (txtMensaje.Text != "")
            {
                Servidor.SendTo((string)lbUsuarios.SelectedItem, txtMensaje.Text);
            }
            else
            {
                MessageBox.Show("Escriba mensaje");
            }
        }

        private void btDesconectarPuntoCarga_Click(object sender, EventArgs e)
        {
            servidor.DisconnectClient((string)lbUsuarios.SelectedItem);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        public void servidor_OnClientConnected(Object sender, ConnectedArguments R)
        {
            servidor.BroadCast(R.Name + "se ha conectado.");
            actualizarListasUsuarios_Ips(lbUsuarios, R.Name, false);
            actualizarListasUsuarios_Ips(lbIPs, R.Ip, false);
        }

        public void servidor_OnClientDisconnected(Object sender, DisconnectedArguments R)
        {
            servidor.BroadCast(R.Name + "se ha desconectado.");
            actualizarListasUsuarios_Ips(lbUsuarios, R.Name, true);
            actualizarListasUsuarios_Ips(lbIPs, R.Ip, true);
        }

        public void servidor_OnDataReceived(Object sender, ReceivedArguments R)
        {
            actualizarLogForma(R.ReceivedData);
            servidor.BroadCast(R.Name + "envia: " + R.ReceivedData);
        }

        public void servidor_OnServerError(Object sender, ErrorArguments R)
        {
            MessageBox.Show(R.ErrorMessage);
        }


        private void lbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbIPs.SelectedIndex = lbUsuarios.SelectedIndex;
        }

        private void lbIPs_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbUsuarios.SelectedIndex = lbIPs.SelectedIndex;
        }*/

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
