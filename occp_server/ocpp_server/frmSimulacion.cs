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
    public partial class frmSimulacion : Form
    {
        public frmSimulacion()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Respuesta r;

            txtProgreso.Clear();

            ///////////
            //Vehiculos
            ///////////

            if(txtCantidadVehiculos.Text.Trim().Length>0)
            {
                txtProgreso.AppendText("Simulacion de vehiculos... INICIADA" + Environment.NewLine);
                r = ControlSimulacion.Vehiculos(Convert.ToInt32(txtCantidadVehiculos.Text));
                txtProgreso.AppendText(r.Mensaje + Environment.NewLine);
                txtProgreso.AppendText("Simulacion de vehiculos... TERMINADA" + Environment.NewLine + Environment.NewLine);
            }
            
            ///////////////////////////////
            //Estaciones y Puntos de Carga
            ///////////////////////////////

            if(txtCantidadEstaciones.Text.Trim().Length > 0 && txtCantidadPuntosCarga.Text.Trim().Length > 0)
            {
                txtProgreso.AppendText("Simulacion de Estacion y Puntos Carga... INICIADA" + Environment.NewLine);
                r = ControlSimulacion.Estacion(Convert.ToInt32(txtCantidadEstaciones.Text), Convert.ToInt32(txtCantidadPuntosCarga.Text));
                txtProgreso.AppendText(r.Mensaje + Environment.NewLine);
                txtProgreso.AppendText("Simulacion de Estacion y Puntos Carga... TERMINADA" + Environment.NewLine);
            }
        }

        private void btnInicializar_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta = MessageBox.Show("Esta a punto de eliminar todos los datos guardados. Esta seguro que desea continuar con la operación?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(Respuesta == DialogResult.Yes)
            {
                ocpp_server_modelo.Servidor.getInstancia().Inicializar();
                txtProgreso.AppendText("Se han eliminado todos los datos" + Environment.NewLine);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
