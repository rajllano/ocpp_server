﻿namespace ocpp_server
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.BarraEstatus = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnVehiculos = new System.Windows.Forms.ToolStripButton();
            this.btnPuntoCarga = new System.Windows.Forms.ToolStripButton();
            this.btnReserva = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnLogs = new System.Windows.Forms.ToolStripButton();
            this.btnSimulacion = new System.Windows.Forms.ToolStripButton();
            this.btnIniciarServidor = new System.Windows.Forms.ToolStripButton();
            this.btnEstacion = new System.Windows.Forms.ToolStripButton();
            this.BarraEstatus.SuspendLayout();
            this.BarraHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraEstatus
            // 
            this.BarraEstatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.BarraEstatus.Location = new System.Drawing.Point(0, 431);
            this.BarraEstatus.Name = "BarraEstatus";
            this.BarraEstatus.Size = new System.Drawing.Size(632, 22);
            this.BarraEstatus.TabIndex = 0;
            this.BarraEstatus.Text = "hola mundo";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(42, 17);
            this.lblEstado.Text = "Estado";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVehiculos,
            this.btnEstacion,
            this.btnPuntoCarga,
            this.btnReserva,
            this.toolStripSeparator1,
            this.btnSalir,
            this.btnLogs,
            this.btnSimulacion,
            this.btnIniciarServidor});
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(632, 25);
            this.BarraHerramientas.TabIndex = 1;
            this.BarraHerramientas.Text = "ToolStrip";
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVehiculos.Image = global::ocpp_server.Properties.Resources.carro;
            this.btnVehiculos.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(23, 22);
            this.btnVehiculos.Text = "Vehiculo";
            this.btnVehiculos.ToolTipText = "Vehiculos";
            this.btnVehiculos.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // btnPuntoCarga
            // 
            this.btnPuntoCarga.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPuntoCarga.Image = global::ocpp_server.Properties.Resources.gasolinera;
            this.btnPuntoCarga.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnPuntoCarga.Name = "btnPuntoCarga";
            this.btnPuntoCarga.Size = new System.Drawing.Size(23, 22);
            this.btnPuntoCarga.Text = "PuntoCarga";
            this.btnPuntoCarga.ToolTipText = "PuntoCarga";
            this.btnPuntoCarga.Click += new System.EventHandler(this.OpenFile);
            // 
            // btnReserva
            // 
            this.btnReserva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReserva.Image = global::ocpp_server.Properties.Resources.reloj;
            this.btnReserva.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(23, 22);
            this.btnReserva.Text = "Estacion";
            this.btnReserva.ToolTipText = "Reservas";
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = global::ocpp_server.Properties.Resources.salir;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(23, 22);
            this.btnSalir.Text = "Ayuda";
            this.btnSalir.ToolTipText = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLogs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLogs.Image = global::ocpp_server.Properties.Resources.log;
            this.btnLogs.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(23, 22);
            this.btnLogs.Text = "Vista previa de impresión";
            this.btnLogs.ToolTipText = "Logs";
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnSimulacion
            // 
            this.btnSimulacion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSimulacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSimulacion.Image = global::ocpp_server.Properties.Resources.simulacion;
            this.btnSimulacion.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnSimulacion.Name = "btnSimulacion";
            this.btnSimulacion.Size = new System.Drawing.Size(23, 22);
            this.btnSimulacion.Text = "Vista previa de impresión";
            this.btnSimulacion.ToolTipText = "Simulacion";
            this.btnSimulacion.Click += new System.EventHandler(this.btnSimulacion_Click);
            // 
            // btnIniciarServidor
            // 
            this.btnIniciarServidor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnIniciarServidor.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciarServidor.Image")));
            this.btnIniciarServidor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIniciarServidor.Name = "btnIniciarServidor";
            this.btnIniciarServidor.Size = new System.Drawing.Size(89, 22);
            this.btnIniciarServidor.Text = "Iniciar Servidor";
            this.btnIniciarServidor.Click += new System.EventHandler(this.btnIniciarServidor_Click);
            // 
            // btnEstacion
            // 
            this.btnEstacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEstacion.Image = ((System.Drawing.Image)(resources.GetObject("btnEstacion.Image")));
            this.btnEstacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEstacion.Name = "btnEstacion";
            this.btnEstacion.Size = new System.Drawing.Size(23, 22);
            this.btnEstacion.Text = "Estacion";
            this.btnEstacion.Click += new System.EventHandler(this.btnEstacion_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.BarraEstatus);
            this.Controls.Add(this.BarraHerramientas);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "OCPP Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);            
            this.BarraEstatus.ResumeLayout(false);
            this.BarraEstatus.PerformLayout();
            this.BarraHerramientas.ResumeLayout(false);
            this.BarraHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip BarraEstatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton btnVehiculos;
        private System.Windows.Forms.ToolStripButton btnPuntoCarga;
        private System.Windows.Forms.ToolStripButton btnReserva;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSimulacion;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStrip BarraHerramientas;
        private System.Windows.Forms.ToolStripButton btnLogs;
        private System.Windows.Forms.ToolStripButton btnIniciarServidor;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripButton btnEstacion;
    }
}



