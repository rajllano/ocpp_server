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
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
        }

       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            Respuesta r = ControlReserva.Listar();

            if (r.Estado)
            {
                ColeccionReserva  cv = (ColeccionReserva)r.Anexo["ColeccionReserva"];
                Reserva v;

                this.dgvLista.Columns.Clear();

                this.dgvLista.Columns.Add("Id", "Id");
                this.dgvLista.Columns.Add("PuntoCarga", "NumeroSerie");
                this.dgvLista.Columns.Add("Vehiculo", "Vehiculo");
                this.dgvLista.Columns.Add("FechaHora", "FechaHora");

                IteradorColeccionReserva  i = (IteradorColeccionReserva)cv.Iterador();

                while (i.tieneSiguiente())
                {
                    v = i.Siguiente();

                    this.dgvLista.Rows.Add(v.Id, v.PuntoCarga.NumeroSerie, v.Vehiculo.Placa, v.FechaHora);
                }
            }
            else
                MessageBox.Show(r.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void gtAgregar_Click(object sender, EventArgs e)
        {

            Respuesta r0 = ControlPuntoCarga.BuscarPorNumeroSerie(ddlPuntoCarga.Text);
            PuntoCarga p = (PuntoCarga)r0.Anexo["Punto de Carga"];
            
            Respuesta r = ControlReserva.AgregarPorPlaca(ddlPlaca.Text, p.Id.ToString(), ddlDia.Text, ddlMes.Text, ddlAno.Text, ddlHora.Text, ddlMinuto.Text, ddlTiempo.Text);

            if (r.Estado)
            {
                MessageBox.Show(r.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                               
            }
            else
                MessageBox.Show(r.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            cargarPlacas();
            cargarPuntosCarga();
        }

        private void cargarPlacas()
        {
            Respuesta r = ControlVehiculo.Listar();

            if (r.Estado)
            {
                ColeccionVehiculo cv = (ColeccionVehiculo)r.Anexo["ColeccionVehiculo"];
                Vehiculo v;
                
                IteradorColeccionVehiculo  i = (IteradorColeccionVehiculo)cv.Iterador();

                while (i.tieneSiguiente())
                {
                    v = i.Siguiente();
                    this.ddlPlaca.Items.Add(v.Placa);
                }
            }
            else
                MessageBox.Show(r.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }


        private void cargarPuntosCarga()
        {
            Respuesta r = ControlPuntoCarga.Listar();

            if (r.Estado)
            {
                 ColeccionPuntoCarga  cv = (ColeccionPuntoCarga)r.Anexo["ColeccionPuntoCarga"];
                PuntoCarga v;

                IteradorColeccionPuntoCarga  i = (IteradorColeccionPuntoCarga)cv.Iterador();

                while (i.tieneSiguiente())
                {
                    v = i.Siguiente();
                    this.ddlPuntoCarga.Items.Add(v.NumeroSerie);
                }
            }
            else
                MessageBox.Show(r.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

    }
}
