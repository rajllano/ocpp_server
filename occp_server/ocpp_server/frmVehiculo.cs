using ocpp_server_control;
using ocpp_server_modelo;
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
    public partial class frmVehiculo : Form
    {
        public frmVehiculo()
        {
            InitializeComponent();
        }

        private void frmVehiculoAgregar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Respuesta r = ControlVehiculo.Agregar(txtPlaca.Text, txtTag.Text, txtMarca.Text, txtModelo.Text, txtPropietario.Text);

            if (r.Estado)
            {
                MessageBox.Show(r.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                LimpiarCampos();
            }
            else
                MessageBox.Show(r.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void btnBuscarPorPlaca_Click(object sender, EventArgs e)
        {
            Respuesta r = ControlVehiculo.BuscarPorPlaca(txtPlaca.Text);

            if (r.Estado)
            {
                LimpiarCampos();

                Vehiculo v = (Vehiculo)r.Anexo["Vehiculo"];

                txtPlaca.Text = v.Placa;
                txtTag.Text = v.Tag;
                txtMarca.Text = v.Marca;
                txtModelo.Text = v.Modelo;
                txtPropietario.Text = v.Propietario;

                MessageBox.Show(r.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
                MessageBox.Show(r.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void LimpiarCampos()
        {
            this.txtPlaca.Text = "";
            this.txtTag.Text = "";
            this.txtMarca.Text = "";
            this.txtModelo.Text = "";
            this.txtPropietario.Text = "";

            this.txtPlaca.Focus();
        }

        private void btnBuscarPorTag_Click(object sender, EventArgs e)
        {
            Respuesta r = ControlVehiculo.BuscarPorTag(txtTag.Text);

            if (r.Estado)
            {
                LimpiarCampos();

                Vehiculo v = (Vehiculo)r.Anexo["Vehiculo"];

                txtPlaca.Text = v.Placa;
                txtTag.Text = v.Tag;
                txtMarca.Text = v.Marca;
                txtModelo.Text = v.Modelo;
                txtPropietario.Text = v.Propietario;

                MessageBox.Show(r.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
                MessageBox.Show(r.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void frmVehiculo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void txtPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtTag_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Respuesta r = ControlVehiculo.Listar();

            if (r.Estado)
            {
                ColeccionVehiculo cv = (ColeccionVehiculo)r.Anexo["Vehiculo"];
                Vehiculo v;

                this.dgvLista.Columns.Clear();

                this.dgvLista.Columns.Add("Placa","Placa");
                this.dgvLista.Columns.Add("Tag","Tag");
                this.dgvLista.Columns.Add("Modelo", "Modelo");
                this.dgvLista.Columns.Add("Marca", "Marca");
                this.dgvLista.Columns.Add("Propietario", "Propietario");

                IteradorColeccionVehiculo i = (IteradorColeccionVehiculo)cv.Iterador();

                while (i.tieneSiguiente())
                {
                    v = i.Siguiente();

                    this.dgvLista.Rows.Add(v.Placa,v.Tag,v.Modelo, v.Marca,v.Propietario);
                }
            }
            else
                MessageBox.Show(r.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }
}
