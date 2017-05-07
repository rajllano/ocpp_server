using ocpp_server_control;
using System;
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
    public partial class Servidor : Form
    {
        public Servidor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Respuesta r1 = ControlEstacion.Agregar("1", "Estacion1", "Direccion1", "Ubicacion1");
            Respuesta r2 = ControlEstacion.Agregar("2", "Estacion2", "Direccion2", "Ubicacion2");
            Respuesta r3 = ControlEstacion.Agregar("2", "Estacion3", "Direccion3", "Ubicacion3");
        }
    }
}
