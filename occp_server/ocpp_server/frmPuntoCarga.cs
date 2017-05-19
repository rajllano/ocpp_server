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
    public partial class frmPuntoCarga : Form
    {
        public frmPuntoCarga()
        {
            InitializeComponent();
        }

        private void btnBuscarPorPlaca_Click(object sender, EventArgs e)
        {
            Respuesta r = ControlPuntoCarga.BuscarPorId(txtId.Text);

            if (r.Estado)
            {
                txtId.Text = "";

                PuntoCarga v = (PuntoCarga)r.Anexo["Punto de Carga"];

                txtId.Text = v.Id.ToString();
                txtMarca.Text = v.Marca;
                txtModelo.Text = v.Modelo;
                txtSerie.Text = v.NumeroSerie;

                MessageBox.Show(r.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
                MessageBox.Show(r.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void btnEliminarPlaca_Click(object sender, EventArgs e)
        {
            Respuesta r = ControlPuntoCarga.Eliminar(txtId.Text);

            if (r.Estado)
            {
                MessageBox.Show(r.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                txtId.Text = "";
            }
            else
                MessageBox.Show(r.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Respuesta r = ControlPuntoCarga.Listar();

            if (r.Estado)
            {
                ColeccionPuntoCarga cv = (ColeccionPuntoCarga)r.Anexo["ColeccionPuntoCarga"];
                PuntoCarga v;

                this.dgvLista.Columns.Clear();

                this.dgvLista.Columns.Add("Id", "Id");
                this.dgvLista.Columns.Add("NumeroSerie", "NumeroSerie");
                this.dgvLista.Columns.Add("Marca", "Marca");
                this.dgvLista.Columns.Add("Modelo", "Modelo");

                IteradorColeccionPuntoCarga i = (IteradorColeccionPuntoCarga)cv.Iterador();

                while (i.tieneSiguiente())
                {
                    v = i.Siguiente();

                    this.dgvLista.Rows.Add(v.Id, v.NumeroSerie, v.Marca, v.Modelo);
                }
            }
            else
                MessageBox.Show(r.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
