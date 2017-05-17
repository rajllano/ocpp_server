namespace ocpp_server
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.BarraHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 0;
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
            this.btnPuntoCarga,
            this.btnReserva,
            this.toolStripSeparator1,
            this.btnSalir,
            this.btnLogs,
            this.btnSimulacion,
            this.toolStripButton1});
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
            this.btnVehiculos.Text = "Nuevo";
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
            this.btnReserva.Text = "Guardar";
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
            this.btnSimulacion.ToolTipText = "Logs";
            this.btnSimulacion.Click += new System.EventHandler(this.btnSimulacion_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(64, 22);
            this.toolStripButton1.Text = "Prueba";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.BarraHerramientas);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "OCPP Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.BarraHerramientas.ResumeLayout(false);
            this.BarraHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}



