namespace pryEspinosaIE
{
    partial class frmCargaProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaProveedores));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.txtApertura = new System.Windows.Forms.TextBox();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.lblApertura = new System.Windows.Forms.Label();
            this.lblExpediente = new System.Windows.Forms.Label();
            this.lblJuzg = new System.Windows.Forms.Label();
            this.lblJurisdicción = new System.Windows.Forms.Label();
            this.lblDirección = new System.Windows.Forms.Label();
            this.lblLiquidador = new System.Windows.Forms.Label();
            this.cmbJuzg = new System.Windows.Forms.ComboBox();
            this.cmbJurisdicción = new System.Windows.Forms.ComboBox();
            this.cmbLiquidador = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvDatos.Location = new System.Drawing.Point(21, 218);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(683, 187);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nº";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Entidad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apertura";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nº Expediente";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Juzg.";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Jurisdiccion";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Direccion";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Liquidador Responsable";
            this.Column8.Name = "Column8";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(118, 12);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(118, 54);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(100, 20);
            this.txtEntidad.TabIndex = 2;
            // 
            // txtApertura
            // 
            this.txtApertura.Location = new System.Drawing.Point(118, 99);
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.Size = new System.Drawing.Size(100, 20);
            this.txtApertura.TabIndex = 3;
            // 
            // txtExpediente
            // 
            this.txtExpediente.Location = new System.Drawing.Point(118, 145);
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(100, 20);
            this.txtExpediente.TabIndex = 4;
            this.txtExpediente.TextChanged += new System.EventHandler(this.txtExpediente_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(398, 102);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(557, 443);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(98, 29);
            this.btnGrabar.TabIndex = 9;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(51, 431);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(35, 13);
            this.lblDatos.TabIndex = 10;
            this.lblDatos.Text = "label1";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(443, 443);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 29);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(12, 9);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(100, 23);
            this.lblNumero.TabIndex = 12;
            this.lblNumero.Text = "Número";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntidad
            // 
            this.lblEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidad.Location = new System.Drawing.Point(12, 51);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(100, 23);
            this.lblEntidad.TabIndex = 13;
            this.lblEntidad.Text = "Entidad";
            this.lblEntidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApertura
            // 
            this.lblApertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApertura.Location = new System.Drawing.Point(12, 96);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(100, 23);
            this.lblApertura.TabIndex = 14;
            this.lblApertura.Text = "Apertura";
            this.lblApertura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExpediente
            // 
            this.lblExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpediente.Location = new System.Drawing.Point(12, 142);
            this.lblExpediente.Name = "lblExpediente";
            this.lblExpediente.Size = new System.Drawing.Size(100, 23);
            this.lblExpediente.TabIndex = 15;
            this.lblExpediente.Text = "Expediente";
            this.lblExpediente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJuzg
            // 
            this.lblJuzg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuzg.Location = new System.Drawing.Point(292, 6);
            this.lblJuzg.Name = "lblJuzg";
            this.lblJuzg.Size = new System.Drawing.Size(100, 23);
            this.lblJuzg.TabIndex = 16;
            this.lblJuzg.Text = "Juzg";
            this.lblJuzg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJurisdicción
            // 
            this.lblJurisdicción.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJurisdicción.Location = new System.Drawing.Point(292, 51);
            this.lblJurisdicción.Name = "lblJurisdicción";
            this.lblJurisdicción.Size = new System.Drawing.Size(100, 23);
            this.lblJurisdicción.TabIndex = 17;
            this.lblJurisdicción.Text = "Jurisdicción";
            this.lblJurisdicción.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDirección
            // 
            this.lblDirección.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirección.Location = new System.Drawing.Point(292, 99);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(100, 23);
            this.lblDirección.TabIndex = 18;
            this.lblDirección.Text = "Dirección";
            this.lblDirección.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLiquidador
            // 
            this.lblLiquidador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiquidador.Location = new System.Drawing.Point(292, 142);
            this.lblLiquidador.Name = "lblLiquidador";
            this.lblLiquidador.Size = new System.Drawing.Size(100, 23);
            this.lblLiquidador.TabIndex = 19;
            this.lblLiquidador.Text = "Liquidador";
            this.lblLiquidador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbJuzg
            // 
            this.cmbJuzg.FormattingEnabled = true;
            this.cmbJuzg.Items.AddRange(new object[] {
            "Comercial N° 2, Secretaría N° 3",
            "Comercial N° 2, Secretaría N° 4",
            "Comercial N° 2, Secretaría N° 5",
            "Comercial N° 2, Secretaría N° 6",
            "Comercial N° 2, Secretaría N° 7",
            "Comercial N° 2, Secretaría N° 8",
            "Comercial N° 2, Secretaría N° 9",
            "Comercial N° 2, Secretaría N° 10",
            "Comercial N° 2, Secretaría N° 11",
            "Comercial N° 2, Secretaría N° 12",
            "Comercial N° 2, Secretaría N° 13",
            "Comercial N° 2, Secretaría N° 14",
            "Comercial N° 2, Secretaría N° 15",
            "Comercial N° 2, Secretaría N° 16",
            "Comercial N° 2, Secretaría N° 17",
            "Comercial N° 2, Secretaría N° 18",
            "Comercial N° 2, Secretaría N° 19",
            "Comercial N° 2, Secretaría N° 20",
            "Comercial N° 2, Secretaría N° 21",
            "Comercial N° 2, Secretaría N° 22",
            "Comercial N° 2, Secretaría N° 23",
            "Comercial N° 2, Secretaría N° 24",
            "Comercial N° 2, Secretaría N° 25",
            "Comercial N° 2, Secretaría N° 26",
            "Comercial N° 2, Secretaría N° 27",
            "Comercial N° 2, Secretaría N° 28",
            "Comercial N° 2, Secretaría N° 29",
            "Comercial N° 2, Secretaría N° 30",
            "Comercial N° 2, Secretaría N° 31",
            "Comercial N° 2, Secretaría N° 32",
            "Comercial N° 2, Secretaría N° 33",
            "Comercial N° 2, Secretaría N° 34",
            "Comercial N° 2, Secretaría N° 35",
            "Comercial N° 2, Secretaría N° 36",
            "Comercial N° 2, Secretaría N° 37",
            "Comercial N° 2, Secretaría N° 38",
            "Comercial N° 2, Secretaría N° 39",
            "Comercial N° 2, Secretaría N° 40",
            "Comercial N° 2, Secretaría N° 41",
            "Comercial N° 2, Secretaría N° 42",
            "Comercial N° 2, Secretaría N° 43",
            "Comercial N° 2, Secretaría N° 44",
            "Comercial N° 2, Secretaría N° 45",
            "Comercial N° 2, Secretaría N° 46",
            "Comercial N° 2, Secretaría N° 47",
            "Comercial N° 2, Secretaría N° 48",
            "Comercial N° 2, Secretaría N° 49",
            "Comercial N° 2, Secretaría N° 50",
            "Comercial N° 2, Secretaría N° 51",
            "Comercial N° 2, Secretaría N° 52",
            "Comercial N° 2, Secretaría N° 53",
            "Comercial N° 2, Secretaría N° 54",
            "Comercial N° 2, Secretaría N° 55",
            "Comercial N° 2, Secretaría N° 56",
            "Comercial N° 2, Secretaría N° 57",
            "Comercial N° 2, Secretaría N° 58",
            "Comercial N° 2, Secretaría N° 59",
            "Comercial N° 2, Secretaría N° 60",
            "Comercial N° 2, Secretaría N° 61",
            "Comercial N° 2, Secretaría N° 62",
            "Comercial N° 2, Secretaría N° 63",
            "Comercial N° 2, Secretaría N° 64",
            "Comercial N° 2, Secretaría N° 65",
            "Comercial N° 2, Secretaría N° 66",
            "Comercial N° 2, Secretaría N° 67",
            "Comercial N° 2, Secretaría N° 68",
            "Comercial N° 2, Secretaría N° 69",
            "Comercial N° 2, Secretaría N° 70",
            "Comercial N° 2, Secretaría N° 71",
            "Comercial N° 2, Secretaría N° 72",
            "Comercial N° 2, Secretaría N° 73",
            "Comercial N° 2, Secretaría N° 74",
            "Comercial N° 2, Secretaría N° 75",
            "Comercial N° 2, Secretaría N° 76",
            "Comercial N° 2, Secretaría N° 77",
            "Comercial N° 2, Secretaría N° 78",
            "Comercial N° 2, Secretaría N° 79",
            "Comercial N° 2, Secretaría N° 80",
            "Comercial N° 2, Secretaría N° 81",
            "Comercial N° 2, Secretaría N° 82",
            "Comercial N° 2, Secretaría N° 83",
            "Comercial N° 2, Secretaría N° 84",
            "Comercial N° 2, Secretaría N° 85",
            "Comercial N° 2, Secretaría N° 86",
            "Comercial N° 2, Secretaría N° 87",
            "Comercial N° 2, Secretaría N° 88",
            "Comercial N° 2, Secretaría N° 89",
            "Comercial N° 2, Secretaría N° 90",
            "Comercial N° 2, Secretaría N° 91",
            "Comercial N° 2, Secretaría N° 92",
            "Comercial N° 2, Secretaría N° 93",
            "Comercial N° 2, Secretaría N° 94",
            "Comercial N° 2, Secretaría N° 95",
            "Comercial N° 2, Secretaría N° 96",
            "Comercial N° 2, Secretaría N° 97",
            "Comercial N° 2, Secretaría N° 98",
            "Comercial N° 2, Secretaría N° 99",
            "Comercial N° 2, Secretaría N° 100",
            "Comercial N° 2, Secretaría N° 101",
            "Comercial N° 2, Secretaría N° 102",
            "Comercial N° 2, Secretaría N° 103",
            "Comercial N° 2, Secretaría N° 104",
            "Comercial N° 2, Secretaría N° 105",
            "Comercial N° 2, Secretaría N° 106",
            "Comercial N° 2, Secretaría N° 107",
            "Comercial N° 2, Secretaría N° 108",
            "Comercial N° 2, Secretaría N° 109",
            "Comercial N° 2, Secretaría N° 110",
            "Comercial N° 2, Secretaría N° 111",
            "Comercial N° 2, Secretaría N° 112",
            "Comercial N° 2, Secretaría N° 113",
            "Comercial N° 2, Secretaría N° 114",
            "Comercial N° 2, Secretaría N° 115",
            "Comercial N° 2, Secretaría N° 116",
            "Comercial N° 2, Secretaría N° 117",
            "Comercial N° 2, Secretaría N° 118",
            "Comercial N° 2, Secretaría N° 119",
            "Comercial N° 2, Secretaría N° 120",
            "Comercial N° 2, Secretaría N° 121",
            "Comercial N° 2, Secretaría N° 122",
            "Comercial N° 2, Secretaría N° 123",
            "Comercial N° 2, Secretaría N° 124",
            "Comercial N° 2, Secretaría N° 125",
            "Comercial N° 2, Secretaría N° 126",
            "Comercial N° 2, Secretaría N° 127",
            "Comercial N° 2, Secretaría N° 128",
            "Comercial N° 2, Secretaría N° 129",
            "Comercial N° 2, Secretaría N° 130",
            "Comercial N° 2, Secretaría N° 131",
            "Comercial N° 2, Secretaría N° 132",
            "Comercial N° 2, Secretaría N° 133",
            "Comercial N° 2, Secretaría N° 134",
            "Comercial N° 2, Secretaría N° 135",
            "Comercial N° 2, Secretaría N° 136",
            "Comercial N° 2, Secretaría N° 137",
            "Comercial N° 2, Secretaría N° 138",
            "Comercial N° 2, Secretaría N° 139",
            "Comercial N° 2, Secretaría N° 140",
            "Comercial N° 2, Secretaría N° 141",
            "Comercial N° 2, Secretaría N° 142",
            "Comercial N° 2, Secretaría N° 143",
            "Comercial N° 2, Secretaría N° 144",
            "Comercial N° 2, Secretaría N° 145",
            "Comercial N° 2, Secretaría N° 146",
            "Comercial N° 2, Secretaría N° 147",
            "Comercial N° 2, Secretaría N° 148",
            "Comercial N° 2, Secretaría N° 149",
            "Comercial N° 2, Secretaría N° 150",
            "Comercial N° 2, Secretaría N° 151",
            "Comercial N° 2, Secretaría N° 152",
            "Comercial N° 2, Secretaría N° 153",
            "Comercial N° 2, Secretaría N° 154",
            "Comercial N° 2, Secretaría N° 155",
            "Comercial N° 2, Secretaría N° 156",
            "Comercial N° 2, Secretaría N° 157",
            "Comercial N° 2, Secretaría N° 158",
            "Comercial N° 2, Secretaría N° 159"});
            this.cmbJuzg.Location = new System.Drawing.Point(398, 9);
            this.cmbJuzg.Name = "cmbJuzg";
            this.cmbJuzg.Size = new System.Drawing.Size(100, 21);
            this.cmbJuzg.TabIndex = 20;
            // 
            // cmbJurisdicción
            // 
            this.cmbJurisdicción.FormattingEnabled = true;
            this.cmbJurisdicción.Items.AddRange(new object[] {
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA"});
            this.cmbJurisdicción.Location = new System.Drawing.Point(398, 51);
            this.cmbJurisdicción.Name = "cmbJurisdicción";
            this.cmbJurisdicción.Size = new System.Drawing.Size(100, 21);
            this.cmbJurisdicción.TabIndex = 21;
            // 
            // cmbLiquidador
            // 
            this.cmbLiquidador.FormattingEnabled = true;
            this.cmbLiquidador.Items.AddRange(new object[] {
            "Dra. María Cristina Ubbriaco",
            "Sr. Ricardo Crosetto",
            "Dra. María Alejandra Spagnolo",
            "Dra. María Cristina Ubbriaco",
            "Cont. Orlando Marcelo Suarez",
            "Cont. Orlando Marcelo Suarez",
            "Dr. Carlos Eduardo Sercovich",
            "Dr. Martín Riera ",
            "Dra. Alicia Nilda Sturla",
            "Cont. Edgardo Gustavo Silva",
            "Cont. Orlando Marcelo Suarez",
            "Dr. Oscar Guillermo Carreras",
            "Dra. Claudia Marcela Pariente",
            "Cont. Héctor Jorge García",
            "Dra. Claudia Marcela Pariente",
            "Dra. María Cristina Ubbriaco",
            "Cont. Orlando Marcelo Suarez",
            "Dr. Carlos Eduardo Sercovich",
            "Dra. Claudia Marcela Pariente",
            "Dr. Carlos Eduardo Sercovich",
            "Dra. María Cristina Ubbriaco",
            "Dr. Carlos Eduardo Sercovich",
            "Dra. Verónica Ortíz Auger",
            "Cont. Edgardo Gustavo Silva",
            "Dra. María Cristina Ubbriaco",
            "Dra. Claudia Marcela Pariente",
            "Cont. Orlando Marcelo Suarez",
            "Dra. Claudia Marcela Pariente",
            "Dra. María Cristina Ubbriaco",
            "Dr. Oscar Guillermo Carreras",
            "Dr. Martín Riera ",
            "Cont. Orlando Marcelo Suarez",
            "Dra. Alicia Nilda Sturla",
            "Dra. Alicia Nilda Sturla",
            "Dra. Andrea Susana Rojas ",
            "Dra. Gabriela Inés Trapaglia",
            "Dr. Oscar Guillermo Carreras",
            "Cont. Héctor Jorge García",
            "Dr. Domingo Gómez Bisgarra",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Andrea Susana Rojas ",
            "Cont. Edgardo Gustavo Silva",
            "Dr. Martín Riera",
            "Dra. María Cristina Ubbriaco",
            "Dra. María Cristina Ubbriaco",
            "Sr. Ricardo Crosetto",
            "Dr. Luis Petrate Arguello",
            "Cont. Edgardo Gustavo Silva",
            "Dr. Domingo Gómez Bisgarra",
            "Dra. Claudia Marcela Pariente",
            "Cont. Héctor Jorge García",
            "Cont. Héctor Jorge García",
            "Dr. Martín Riera",
            "Dr. Carlos Eduardo Sercovich",
            "Dr. Martín Riera ",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. María Cristina Ubbriaco",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Claudia Marcela Pariente",
            "Cont. Orlando Marcelo Suarez",
            "Dra. María Cristina Ubbriaco",
            "Cont. Héctor Jorge García",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Gabriela Inés Trapaglia",
            "Dr. Ezequiel Cará",
            "Dra. Alicia Nilda Sturla",
            "Dr. Oscar Guillermo Carreras",
            "Dra. Claudia Marcela Pariente",
            "Cont. Edgardo Gustavo Silva",
            "Dra. Andrea Susana Rojas ",
            "Dra. Alicia Nilda Sturla",
            "Dra. Alicia Nilda Sturla",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Claudia Marcela Pariente",
            "Dra. María Cristina Ubbriaco",
            "Dra. Alicia Nilda Sturla",
            "Dra. María Cristina Ubbriaco",
            "Dra. Andrea Susana Rojas ",
            "Dra. María Cristina Ubbriaco",
            "Dra. María Cristina Ubbriaco",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Gabriela Inés Trapaglia",
            "Dr. Ezequiel Cará",
            "Dr. Luis Petrate Arguello",
            "Dra. María Cristina Ubbriaco",
            "Dra. María Alejandra Spagnolo",
            "Cont. Edgardo Gustavo Silva",
            "Dr. Carlos Eduardo Sercovich",
            "Cont. Héctor Jorge García",
            "Dr. Carlos Eduardo Sercovich",
            "Dra. Verónica Ortíz Auger",
            "Dra. María Cristina Ubbriaco",
            "Dra. Claudia Marcela Pariente",
            "Dr. Oscar Guillermo Carreras",
            "Dr. Oscar Guillermo Carreras",
            "Dr. Oscar Guillermo Carreras",
            "Cont. Edgardo Gustavo Silva",
            "Cont. Edgardo Gustavo Silva",
            "Cont. Héctor Jorge García",
            "Cont. Héctor Jorge García",
            "Dr. Oscar Guillermo Carreras",
            "Dr. Ezequiel Cará",
            "Dr. Oscar Guillermo Carreras",
            "Dr. Oscar Guillermo Carreras",
            "Dr. Oscar Guillermo Carreras",
            "Dra. Andrea Susana Rojas ",
            "Dr. Luis Petrate Arguello",
            "Dra. Claudia Marcela Pariente",
            "Dr. Luis Petrate Arguello",
            "Cont. Héctor Jorge García",
            "Dr. Luis Petrate Arguello",
            "Cont. Orlando Marcelo Suarez",
            "Dra. Andrea Susana Rojas ",
            "Dr. Luis Petrate Arguello",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Claudia Marcela Pariente",
            "Dr. Domingo Gómez Bisgarra",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Gabriela Inés Trapaglia",
            "Cont. Héctor Jorge García",
            "Dra. María Cristina Ubbriaco",
            "Dr. Oscar Guillermo Carreras",
            "Cont. Roberto Falvo",
            "Dra. María Cristina Ubbriaco",
            "Cont. Héctor Jorge García",
            "Dr. Luis Petrate Arguello",
            "Dra. María Cristina Ubbriaco",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Alicia Nilda Sturla",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Claudia Marcela Pariente",
            "Dr. Luis Petrate Arguello",
            "Cont. Héctor Jorge García",
            "Dr. Carlos Eduardo Sercovich",
            "Dr. Ezequiel Cará",
            "Dr. Domingo Gómez Bisgarra",
            "Dra. Gabriela Inés Trapaglia",
            "Dr. Carlos Eduardo Sercovich",
            "Dr. Carlos Eduardo Sercovich",
            "Dr. Oscar Guillermo Carreras",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. María Mendía",
            "Dr. Ezequiel Cará",
            "Dra. Alicia Nilda Sturla",
            "Cont. Roberto Falvo",
            "Dra. María Cristina Ubbriaco",
            "Cont. Héctor Jorge García",
            "Dres. María Mendía y Martín Riera",
            "Dra. Alicia Nilda Sturla",
            "Dra. Gabriela Inés Trapaglia",
            "Cont. Edgardo Gustavo Silva",
            "Dr. Domingo Gómez Bisgarra",
            "Dres. María Mendía y Martín Riera",
            "Dras. Andrea Rojas y Claudia Pariente"});
            this.cmbLiquidador.Location = new System.Drawing.Point(398, 145);
            this.cmbLiquidador.Name = "cmbLiquidador";
            this.cmbLiquidador.Size = new System.Drawing.Size(100, 21);
            this.cmbLiquidador.TabIndex = 22;
            // 
            // frmCargaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 496);
            this.Controls.Add(this.cmbLiquidador);
            this.Controls.Add(this.cmbJurisdicción);
            this.Controls.Add(this.cmbJuzg);
            this.Controls.Add(this.lblLiquidador);
            this.Controls.Add(this.lblDirección);
            this.Controls.Add(this.lblJurisdicción);
            this.Controls.Add(this.lblJuzg);
            this.Controls.Add(this.lblExpediente);
            this.Controls.Add(this.lblApertura);
            this.Controls.Add(this.lblEntidad);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtExpediente);
            this.Controls.Add(this.txtApertura);
            this.Controls.Add(this.txtEntidad);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.dgvDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargaProveedores";
            this.Text = "CargaProveedores";
            this.Load += new System.EventHandler(this.frmCargaProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.TextBox txtApertura;
        private System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.Label lblExpediente;
        private System.Windows.Forms.Label lblJuzg;
        private System.Windows.Forms.Label lblJurisdicción;
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.Label lblLiquidador;
        private System.Windows.Forms.ComboBox cmbJuzg;
        private System.Windows.Forms.ComboBox cmbJurisdicción;
        private System.Windows.Forms.ComboBox cmbLiquidador;
    }
}