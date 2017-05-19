namespace ocpp_server
{
    partial class frmVehiculo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPropietario = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscarPorPlaca = new System.Windows.Forms.Button();
            this.btnBuscarPorTag = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEliminarPlaca = new System.Windows.Forms.Button();
            this.btnEliminarTag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Propietario";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(409, 291);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(90, 10);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(235, 20);
            this.txtPlaca.TabIndex = 6;
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(90, 38);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(235, 20);
            this.txtTag.TabIndex = 7;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(90, 64);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(235, 20);
            this.txtMarca.TabIndex = 8;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(90, 90);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(235, 20);
            this.txtModelo.TabIndex = 9;
            // 
            // txtPropietario
            // 
            this.txtPropietario.Location = new System.Drawing.Point(90, 116);
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(235, 20);
            this.txtPropietario.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(90, 142);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBuscarPorPlaca
            // 
            this.btnBuscarPorPlaca.Location = new System.Drawing.Point(331, 8);
            this.btnBuscarPorPlaca.Name = "btnBuscarPorPlaca";
            this.btnBuscarPorPlaca.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorPlaca.TabIndex = 12;
            this.btnBuscarPorPlaca.Text = "Buscar";
            this.btnBuscarPorPlaca.UseVisualStyleBackColor = true;
            this.btnBuscarPorPlaca.Click += new System.EventHandler(this.btnBuscarPorPlaca_Click);
            // 
            // btnBuscarPorTag
            // 
            this.btnBuscarPorTag.Location = new System.Drawing.Point(331, 36);
            this.btnBuscarPorTag.Name = "btnBuscarPorTag";
            this.btnBuscarPorTag.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorTag.TabIndex = 13;
            this.btnBuscarPorTag.Text = "Buscar";
            this.btnBuscarPorTag.UseVisualStyleBackColor = true;
            this.btnBuscarPorTag.Click += new System.EventHandler(this.btnBuscarPorTag_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(12, 181);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(475, 104);
            this.dgvLista.TabIndex = 14;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(171, 142);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 15;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminarPlaca
            // 
            this.btnEliminarPlaca.Location = new System.Drawing.Point(412, 8);
            this.btnEliminarPlaca.Name = "btnEliminarPlaca";
            this.btnEliminarPlaca.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPlaca.TabIndex = 16;
            this.btnEliminarPlaca.Text = "Eliminar";
            this.btnEliminarPlaca.UseVisualStyleBackColor = true;
            this.btnEliminarPlaca.Click += new System.EventHandler(this.btnEliminarPlaca_Click);
            // 
            // btnEliminarTag
            // 
            this.btnEliminarTag.Location = new System.Drawing.Point(412, 35);
            this.btnEliminarTag.Name = "btnEliminarTag";
            this.btnEliminarTag.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTag.TabIndex = 17;
            this.btnEliminarTag.Text = "Eliminar";
            this.btnEliminarTag.UseVisualStyleBackColor = true;
            this.btnEliminarTag.Click += new System.EventHandler(this.btnEliminarTag_Click);
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 326);
            this.Controls.Add(this.btnEliminarTag);
            this.Controls.Add(this.btnEliminarPlaca);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.btnBuscarPorTag);
            this.Controls.Add(this.btnBuscarPorPlaca);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPropietario);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(512, 365);
            this.Name = "frmVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculo - Agregar";
            this.Load += new System.EventHandler(this.frmVehiculoAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPropietario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscarPorPlaca;
        private System.Windows.Forms.Button btnBuscarPorTag;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEliminarPlaca;
        private System.Windows.Forms.Button btnEliminarTag;
    }
}