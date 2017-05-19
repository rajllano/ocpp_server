namespace ocpp_server
{
    partial class frmReserva
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gtAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btListar = new System.Windows.Forms.Button();
            this.ddlPuntoCarga = new System.Windows.Forms.ComboBox();
            this.ddlPlaca = new System.Windows.Forms.ComboBox();
            this.ddlDia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlMes = new System.Windows.Forms.ComboBox();
            this.ddlAno = new System.Windows.Forms.ComboBox();
            this.ddlHora = new System.Windows.Forms.ComboBox();
            this.ddlMinuto = new System.Windows.Forms.ComboBox();
            this.ddlTiempo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(121, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(42, 20);
            this.txtId.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Id Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Punto de Carga";
            // 
            // gtAgregar
            // 
            this.gtAgregar.Location = new System.Drawing.Point(202, 155);
            this.gtAgregar.Name = "gtAgregar";
            this.gtAgregar.Size = new System.Drawing.Size(75, 23);
            this.gtAgregar.TabIndex = 28;
            this.gtAgregar.Text = "Agregar";
            this.gtAgregar.UseVisualStyleBackColor = true;
            this.gtAgregar.Click += new System.EventHandler(this.gtAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(342, 305);
            this.btnCancelar.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(12, 184);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(405, 115);
            this.dgvLista.TabIndex = 26;
            // 
            // btListar
            // 
            this.btListar.Location = new System.Drawing.Point(121, 155);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(75, 23);
            this.btListar.TabIndex = 29;
            this.btListar.Text = "Listar";
            this.btListar.UseVisualStyleBackColor = true;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // ddlPuntoCarga
            // 
            this.ddlPuntoCarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPuntoCarga.FormattingEnabled = true;
            this.ddlPuntoCarga.Location = new System.Drawing.Point(121, 74);
            this.ddlPuntoCarga.Name = "ddlPuntoCarga";
            this.ddlPuntoCarga.Size = new System.Drawing.Size(234, 21);
            this.ddlPuntoCarga.TabIndex = 30;
            // 
            // ddlPlaca
            // 
            this.ddlPlaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPlaca.FormattingEnabled = true;
            this.ddlPlaca.Location = new System.Drawing.Point(121, 48);
            this.ddlPlaca.Name = "ddlPlaca";
            this.ddlPlaca.Size = new System.Drawing.Size(234, 21);
            this.ddlPlaca.TabIndex = 31;
            // 
            // ddlDia
            // 
            this.ddlDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDia.FormattingEnabled = true;
            this.ddlDia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "30"});
            this.ddlDia.Location = new System.Drawing.Point(121, 101);
            this.ddlDia.Name = "ddlDia";
            this.ddlDia.Size = new System.Drawing.Size(42, 21);
            this.ddlDia.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Fecha (D/M/A H:M)";
            // 
            // ddlMes
            // 
            this.ddlMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMes.FormattingEnabled = true;
            this.ddlMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.ddlMes.Location = new System.Drawing.Point(169, 101);
            this.ddlMes.Name = "ddlMes";
            this.ddlMes.Size = new System.Drawing.Size(42, 21);
            this.ddlMes.TabIndex = 34;
            // 
            // ddlAno
            // 
            this.ddlAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAno.FormattingEnabled = true;
            this.ddlAno.Items.AddRange(new object[] {
            "2017"});
            this.ddlAno.Location = new System.Drawing.Point(217, 101);
            this.ddlAno.Name = "ddlAno";
            this.ddlAno.Size = new System.Drawing.Size(42, 21);
            this.ddlAno.TabIndex = 35;
            // 
            // ddlHora
            // 
            this.ddlHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlHora.FormattingEnabled = true;
            this.ddlHora.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.ddlHora.Location = new System.Drawing.Point(265, 101);
            this.ddlHora.Name = "ddlHora";
            this.ddlHora.Size = new System.Drawing.Size(42, 21);
            this.ddlHora.TabIndex = 36;
            // 
            // ddlMinuto
            // 
            this.ddlMinuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMinuto.FormattingEnabled = true;
            this.ddlMinuto.Items.AddRange(new object[] {
            "1",
            "30"});
            this.ddlMinuto.Location = new System.Drawing.Point(313, 101);
            this.ddlMinuto.Name = "ddlMinuto";
            this.ddlMinuto.Size = new System.Drawing.Size(42, 21);
            this.ddlMinuto.TabIndex = 37;
            // 
            // ddlTiempo
            // 
            this.ddlTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTiempo.FormattingEnabled = true;
            this.ddlTiempo.Items.AddRange(new object[] {
            "30",
            "60"});
            this.ddlTiempo.Location = new System.Drawing.Point(121, 128);
            this.ddlTiempo.Name = "ddlTiempo";
            this.ddlTiempo.Size = new System.Drawing.Size(42, 21);
            this.ddlTiempo.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tiempo";
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 340);
            this.Controls.Add(this.ddlTiempo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ddlMinuto);
            this.Controls.Add(this.ddlHora);
            this.Controls.Add(this.ddlAno);
            this.Controls.Add(this.ddlMes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ddlDia);
            this.Controls.Add(this.ddlPlaca);
            this.Controls.Add(this.ddlPuntoCarga);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.gtAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(445, 319);
            this.Name = "frmReserva";
            this.Text = "frmReserva";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gtAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.ComboBox ddlPuntoCarga;
        private System.Windows.Forms.ComboBox ddlPlaca;
        private System.Windows.Forms.ComboBox ddlDia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlMes;
        private System.Windows.Forms.ComboBox ddlAno;
        private System.Windows.Forms.ComboBox ddlHora;
        private System.Windows.Forms.ComboBox ddlMinuto;
        private System.Windows.Forms.ComboBox ddlTiempo;
        private System.Windows.Forms.Label label5;
    }
}