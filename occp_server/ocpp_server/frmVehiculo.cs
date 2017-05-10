﻿using ocpp_server_control;
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

                Vehiculo v = (Vehiculo)r.Anexo;

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

                Vehiculo v = (Vehiculo)r.Anexo;

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
            txtPlaca.Focus();
        }

        private void txtPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTag.Focus();
            }
        }
    }
}
