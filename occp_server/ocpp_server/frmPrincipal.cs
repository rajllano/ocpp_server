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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
     
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
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
    }
}
