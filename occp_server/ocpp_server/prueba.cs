﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ocpp_server
{
    public partial class prueba : Form
    {
        //Conexion servidorWebSocket;
        //private string IPPUNTOCARGA;

        public prueba()
        {
            InitializeComponent();
        }

        private void prueba_Load(object sender, EventArgs e)
        {
            frmPrincipal  formaPadre = (frmPrincipal)this.MdiParent;
            //servidorWebSocket = formaPadre.servidorWebSocket;
            //IPPUNTOCARGA = formaPadre.IPSERVIDOR;/*se debe poner la ip del punto de carga, si corre en la misma maquina es la misma*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //servidorWebSocket.enviarMensajeCliente(IPPUNTOCARGA, "Envio de Mensaje de prueba servidor...");            
        }
    }
}
