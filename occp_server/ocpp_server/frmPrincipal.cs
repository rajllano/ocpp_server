using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using ocpp_server_control;

namespace ocpp_server
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            frmVehiculo Forma = new frmVehiculo();

            Forma.MdiParent = this;
            Forma.Show();
            Forma.WindowState = FormWindowState.Maximized;
        }

        private void OpenFile(object sender, EventArgs e)
        {
            frmPuntoCarga Forma = new frmPuntoCarga();

            Forma.MdiParent = this;
            Forma.Show();
            Forma.WindowState = FormWindowState.Maximized;
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        
        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimulacion_Click(object sender, EventArgs e)
        {
            frmSimulacion Forma = new frmSimulacion();

            Forma.MdiParent = this;
            Forma.Show();
            Forma.WindowState = FormWindowState.Maximized;
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {

        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            frmReserva Forma = new frmReserva();

            Forma.MdiParent = this;
            Forma.Show();
            Forma.WindowState = FormWindowState.Maximized;
        }

        private void btnIniciarServidor_Click(object sender, EventArgs e)
        {
            Respuesta r = ControlComunicaciones.IniciarDetener();

            if(Convert.ToBoolean(r.Anexo["Comunicacion"]))
            {
                btnIniciarServidor.Text = "Detener Servidor";
                lblEstado.Text = "Servidor Iniciado";
            }
            else
            {
                btnIniciarServidor.Text = "Iniciar Servidor";
                lblEstado.Text = "Servidor Detenido";
            }
        }

        private void btnDetenerServidor_Click(object sender, EventArgs e)
        {
            Boolean Estado = ControlComunicaciones.Detener();

            if (Estado)
                this.lblEstado.Text = "Servidor Detenido";
            else
                this.lblEstado.Text = "Error deteniendo el servidor";
        }

        private void btnEstacion_Click(object sender, EventArgs e)
        {
            frmEstacion Forma = new frmEstacion();

            Forma.MdiParent = this;
            Forma.Show();
            Forma.WindowState = FormWindowState.Maximized;
        }
    }
}
