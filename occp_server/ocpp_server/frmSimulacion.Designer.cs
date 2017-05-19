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
            this.label1.Location = new System.Drawing.Point(21, 45);
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
            this.label3.Location = new System.Drawing.Point(21, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vehiculos";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(128, 123);
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
            this.txtCantidadEstaciones.Size = new System.Drawing.Size(75, 20);
            this.txtCantidadEstaciones.TabIndex = 5;
            this.txtCantidadEstaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadEstaciones_KeyPress);
            // 
            // txtCantidadPuntosCarga
            // 
            this.txtCantidadPuntosCarga.Location = new System.Drawing.Point(128, 45);
            this.txtCantidadPuntosCarga.Name = "txtCantidadPuntosCarga";
            this.txtCantidadPuntosCarga.Size = new System.Drawing.Size(75, 20);
            this.txtCantidadPuntosCarga.TabIndex = 6;
            this.txtCantidadPuntosCarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadPuntosCarga_KeyPress);
            // 
            // txtCantidadVehiculos
            // 
            this.txtCantidadVehiculos.Location = new System.Drawing.Point(128, 71);
            this.txtCantidadVehiculos.Name = "txtCantidadVehiculos";
            this.txtCantidadVehiculos.Size = new System.Drawing.Size(75, 20);
            this.txtCantidadVehiculos.TabIndex = 7;
            this.txtCantidadVehiculos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadVehiculos_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reservas";
            // 
            // txtCantidadReservas
            // 
            this.txtCantidadReservas.Location = new System.Drawing.Point(128, 97);
            this.txtCantidadReservas.Name = "txtCantidadReservas";
            this.txtCantidadReservas.Size = new System.Drawing.Size(75, 20);
            this.txtCantidadReservas.TabIndex = 9;
            this.txtCantidadReservas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadReservas_KeyPress);
            // 
            // txtProgreso
            // 
            this.txtProgreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProgreso.Location = new System.Drawing.Point(12, 152);
            this.txtProgreso.Multiline = true;
            this.txtProgreso.Name = "txtProgreso";
            this.txtProgreso.Size = new System.Drawing.Size(409, 116);
            this.txtProgreso.TabIndex = 10;
            // 
            // btnInicializar
            // 
            this.btnInicializar.Location = new System.Drawing.Point(12, 123);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(75, 23);
            this.btnInicializar.TabIndex = 11;
            this.btnInicializar.Text = "Inicializar";
            this.btnInicializar.UseVisualStyleBackColor = true;
            this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(346, 274);
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
            this.ClientSize = new System.Drawing.Size(433, 309);
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