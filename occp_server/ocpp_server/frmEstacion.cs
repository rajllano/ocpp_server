using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ocpp_server_control;
using ocpp_server_modelo;

namespace ocpp_server
{
    public partial class frmEstacion : Form
    {
        public frmEstacion()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Respuesta r = ControlEstacion.Listar();

            if (r.Estado)
            {
                ColeccionEstacion cv = (ColeccionEstacion)r.Anexo["ColeccionEstacion"];
                Estacion v;

                this.dgvLista.Columns.Clear();

                this.dgvLista.Columns.Add("Id", "Id");
                this.dgvLista.Columns.Add("Nombre", "Nombre");
                this.dgvLista.Columns.Add("Direccion", "Direccion");
                this.dgvLista.Columns.Add("Ubicacion", "Ubicacion");                

                IteradorColeccionEstacion i = (IteradorColeccionEstacion)cv.Iterador();

                while (i.tieneSiguiente())
                {
                    v = i.Siguiente();

                    this.dgvLista.Rows.Add(v.Id, v.Nombre, v.Direccion, v.Ubicacion);
                }
            }
            else
                MessageBox.Show(r.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarPlaca_Click(object sender, EventArgs e)
        {
            Respuesta r = ControlEstacion.Eliminar(txtId.Text);

            if (r.Estado)
            {
                MessageBox.Show(r.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                txtId.Text = "";                
            }
            else
                MessageBox.Show(r.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void btnBuscarPorPlaca_Click(object sender, EventArgs e)
        {
            Respuesta r = ControlEstacion.BuscarPorId(Convert.ToInt32(txtId.Text));

            if (r.Estado)
            {
                txtId.Text= "";

                Estacion v = (Estacion)r.Anexo["Estacion"];

                txtId.Text = v.Id.ToString();
                txtNombre.Text = v.Nombre;
                txtDireccion.Text = v.Direccion;
                txtUbicacion.Text = v.Ubicacion;
                
                MessageBox.Show(r.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
                MessageBox.Show(r.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }
}
