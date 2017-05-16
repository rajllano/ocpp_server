namespace ocpp_server
{
    partial class frmSimulacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtCantidadEstaciones = new System.Windows.Forms.TextBox();
            this.txtCantidadPuntosCarga = new System.Windows.Forms.TextBox();
            this.txtCantidadVehiculos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadReservas = new System.Windows.Forms.TextBox();
            this.txtProgreso = new System.Windows.Forms.TextBox();
            this.btnInicializar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.HiloSimulacion = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puntos de Carga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vehiculos";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(230, 161);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtCantidadEstaciones
            // 
            this.txtCantidadEstaciones.Location = new System.Drawing.Point(128, 19);
            this.txtCantidadEstaciones.Name = "txtCantidadEstaciones";
            this.txtCantidadEstaciones.Size = new System.Drawing.Size(177, 20);
            this.txtCantidadEstaciones.TabIndex = 5;
            // 
            // txtCantidadPuntosCarga
            // 
            this.txtCantidadPuntosCarga.Location = new System.Drawing.Point(128, 53);
            this.txtCantidadPuntosCarga.Name = "txtCantidadPuntosCarga";
            this.txtCantidadPuntosCarga.Size = new System.Drawing.Size(177, 20);
            this.txtCantidadPuntosCarga.TabIndex = 6;
            // 
            // txtCantidadVehiculos
            // 
            this.txtCantidadVehiculos.Location = new System.Drawing.Point(128, 87);
            this.txtCantidadVehiculos.Name = "txtCantidadVehiculos";
            this.txtCantidadVehiculos.Size = new System.Drawing.Size(177, 20);
            this.txtCantidadVehiculos.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reservas";
            // 
            // txtCantidadReservas
            // 
            this.txtCantidadReservas.Location = new System.Drawing.Point(128, 126);
            this.txtCantidadReservas.Name = "txtCantidadReservas";
            this.txtCantidadReservas.Size = new System.Drawing.Size(177, 20);
            this.txtCantidadReservas.TabIndex = 9;
            // 
            // txtProgreso
            // 
            this.txtProgreso.Location = new System.Drawing.Point(25, 212);
            this.txtProgreso.Multiline = true;
            this.txtProgreso.Name = "txtProgreso";
            this.txtProgreso.Size = new System.Drawing.Size(593, 200);
            this.txtProgreso.TabIndex = 10;
            // 
            // btnInicializar
            // 
            this.btnInicializar.Location = new System.Drawing.Point(128, 161);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(75, 23);
            this.btnInicializar.TabIndex = 11;
            this.btnInicializar.Text = "Inicializar";
            this.btnInicializar.UseVisualStyleBackColor = true;
            this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(333, 161);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 489);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInicializar);
            this.Controls.Add(this.txtProgreso);
            this.Controls.Add(this.txtCantidadReservas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidadVehiculos);
            this.Controls.Add(this.txtCantidadPuntosCarga);
            this.Controls.Add(this.txtCantidadEstaciones);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSimulacion";
            this.Text = "frmSimulacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtCantidadEstaciones;
        private System.Windows.Forms.TextBox txtCantidadPuntosCarga;
        private System.Windows.Forms.TextBox txtCantidadVehiculos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadReservas;
        private System.Windows.Forms.TextBox txtProgreso;
        private System.Windows.Forms.Button btnInicializar;
        private System.Windows.Forms.Button btnCancelar;
        private System.ComponentModel.BackgroundWorker HiloSimulacion;
    }
}