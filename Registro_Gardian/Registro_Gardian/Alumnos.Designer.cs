namespace Registro_Gardian
{
    partial class Alumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alumnos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbdatos = new System.Windows.Forms.GroupBox();
            this.pictqrcode = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl();
            this.txtagapmat = new System.Windows.Forms.MaskedTextBox();
            this.txtagappat = new System.Windows.Forms.MaskedTextBox();
            this.txtagnom = new System.Windows.Forms.MaskedTextBox();
            this.txtagnl = new System.Windows.Forms.MaskedTextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lblnuminstit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbinfomodif = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnmodifalm = new System.Windows.Forms.Button();
            this.txtmodapmat = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmodnom = new System.Windows.Forms.MaskedTextBox();
            this.txtmodappat = new System.Windows.Forms.MaskedTextBox();
            this.gbbuscarmodif = new System.Windows.Forms.GroupBox();
            this.btnmodifbuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmodnl = new System.Windows.Forms.MaskedTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbbaja = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblnombrealm = new System.Windows.Forms.Label();
            this.btninfeliminar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbajanc = new System.Windows.Forms.MaskedTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvalumno = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnrecuperarqr = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnbuscaralm = new System.Windows.Forms.Button();
            this.btnconstodos = new System.Windows.Forms.Button();
            this.cmblistado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtconsalmn = new System.Windows.Forms.MaskedTextBox();
            this.qrrecuperado = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictqrcode)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbinfomodif.SuspendLayout();
            this.gbbuscarmodif.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbbaja.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalumno)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrrecuperado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 396);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(524, 388);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.gbdatos);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(516, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar";
            // 
            // gbdatos
            // 
            this.gbdatos.Controls.Add(this.label12);
            this.gbdatos.Controls.Add(this.pictqrcode);
            this.gbdatos.Controls.Add(this.txtagapmat);
            this.gbdatos.Controls.Add(this.txtagappat);
            this.gbdatos.Controls.Add(this.txtagnom);
            this.gbdatos.Controls.Add(this.txtagnl);
            this.gbdatos.Controls.Add(this.btnagregar);
            this.gbdatos.Controls.Add(this.lblnuminstit);
            this.gbdatos.Controls.Add(this.label2);
            this.gbdatos.Controls.Add(this.label3);
            this.gbdatos.Controls.Add(this.label4);
            this.gbdatos.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdatos.Location = new System.Drawing.Point(3, 6);
            this.gbdatos.Name = "gbdatos";
            this.gbdatos.Size = new System.Drawing.Size(513, 347);
            this.gbdatos.TabIndex = 13;
            this.gbdatos.TabStop = false;
            this.gbdatos.Text = "Datos";
            // 
            // pictqrcode
            // 
            this.pictqrcode.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
            this.pictqrcode.Image = ((System.Drawing.Image)(resources.GetObject("pictqrcode.Image")));
            this.pictqrcode.Location = new System.Drawing.Point(170, 193);
            this.pictqrcode.Name = "pictqrcode";
            this.pictqrcode.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two;
            this.pictqrcode.Size = new System.Drawing.Size(174, 148);
            this.pictqrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictqrcode.TabIndex = 14;
            this.pictqrcode.TabStop = false;
            this.pictqrcode.Text = "qrCodeImgControl1";
            // 
            // txtagapmat
            // 
            this.txtagapmat.Location = new System.Drawing.Point(150, 109);
            this.txtagapmat.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.txtagapmat.Name = "txtagapmat";
            this.txtagapmat.Size = new System.Drawing.Size(136, 23);
            this.txtagapmat.TabIndex = 16;
            // 
            // txtagappat
            // 
            this.txtagappat.Location = new System.Drawing.Point(150, 80);
            this.txtagappat.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.txtagappat.Name = "txtagappat";
            this.txtagappat.Size = new System.Drawing.Size(136, 23);
            this.txtagappat.TabIndex = 15;
            // 
            // txtagnom
            // 
            this.txtagnom.Location = new System.Drawing.Point(150, 53);
            this.txtagnom.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.txtagnom.Name = "txtagnom";
            this.txtagnom.Size = new System.Drawing.Size(136, 23);
            this.txtagnom.TabIndex = 14;
            // 
            // txtagnl
            // 
            this.txtagnl.Location = new System.Drawing.Point(150, 25);
            this.txtagnl.Mask = "00000000";
            this.txtagnl.Name = "txtagnl";
            this.txtagnl.Size = new System.Drawing.Size(72, 23);
            this.txtagnl.TabIndex = 13;
            this.txtagnl.TextChanged += new System.EventHandler(this.txtagnl_TextChanged);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(358, 44);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(99, 41);
            this.btnagregar.TabIndex = 11;
            this.btnagregar.Text = "&Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lblnuminstit
            // 
            this.lblnuminstit.AutoSize = true;
            this.lblnuminstit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnuminstit.Location = new System.Drawing.Point(28, 28);
            this.lblnuminstit.Name = "lblnuminstit";
            this.lblnuminstit.Size = new System.Drawing.Size(63, 16);
            this.lblnuminstit.TabIndex = 2;
            this.lblnuminstit.Text = "No. Lista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido materno";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(516, 359);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbinfomodif);
            this.groupBox1.Controls.Add(this.gbbuscarmodif);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(92, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 296);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // gbinfomodif
            // 
            this.gbinfomodif.Controls.Add(this.label5);
            this.gbinfomodif.Controls.Add(this.label7);
            this.gbinfomodif.Controls.Add(this.btnmodifalm);
            this.gbinfomodif.Controls.Add(this.txtmodapmat);
            this.gbinfomodif.Controls.Add(this.label6);
            this.gbinfomodif.Controls.Add(this.txtmodnom);
            this.gbinfomodif.Controls.Add(this.txtmodappat);
            this.gbinfomodif.Location = new System.Drawing.Point(22, 134);
            this.gbinfomodif.Name = "gbinfomodif";
            this.gbinfomodif.Size = new System.Drawing.Size(318, 162);
            this.gbinfomodif.TabIndex = 20;
            this.gbinfomodif.TabStop = false;
            this.gbinfomodif.Text = "Actualizar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Apellido materno";
            // 
            // btnmodifalm
            // 
            this.btnmodifalm.Enabled = false;
            this.btnmodifalm.Location = new System.Drawing.Point(115, 125);
            this.btnmodifalm.Name = "btnmodifalm";
            this.btnmodifalm.Size = new System.Drawing.Size(92, 31);
            this.btnmodifalm.TabIndex = 18;
            this.btnmodifalm.Text = "&Modificar";
            this.btnmodifalm.UseVisualStyleBackColor = true;
            this.btnmodifalm.Click += new System.EventHandler(this.btnmodifalm_Click);
            // 
            // txtmodapmat
            // 
            this.txtmodapmat.Enabled = false;
            this.txtmodapmat.Location = new System.Drawing.Point(137, 82);
            this.txtmodapmat.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.txtmodapmat.Name = "txtmodapmat";
            this.txtmodapmat.Size = new System.Drawing.Size(154, 23);
            this.txtmodapmat.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Apellido paterno";
            // 
            // txtmodnom
            // 
            this.txtmodnom.Enabled = false;
            this.txtmodnom.Location = new System.Drawing.Point(137, 26);
            this.txtmodnom.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.txtmodnom.Name = "txtmodnom";
            this.txtmodnom.Size = new System.Drawing.Size(154, 23);
            this.txtmodnom.TabIndex = 14;
            // 
            // txtmodappat
            // 
            this.txtmodappat.Enabled = false;
            this.txtmodappat.Location = new System.Drawing.Point(137, 53);
            this.txtmodappat.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.txtmodappat.Name = "txtmodappat";
            this.txtmodappat.Size = new System.Drawing.Size(154, 23);
            this.txtmodappat.TabIndex = 15;
            // 
            // gbbuscarmodif
            // 
            this.gbbuscarmodif.Controls.Add(this.btnmodifbuscar);
            this.gbbuscarmodif.Controls.Add(this.label1);
            this.gbbuscarmodif.Controls.Add(this.txtmodnl);
            this.gbbuscarmodif.Location = new System.Drawing.Point(22, 22);
            this.gbbuscarmodif.Name = "gbbuscarmodif";
            this.gbbuscarmodif.Size = new System.Drawing.Size(318, 106);
            this.gbbuscarmodif.TabIndex = 19;
            this.gbbuscarmodif.TabStop = false;
            this.gbbuscarmodif.Text = "Buscar";
            // 
            // btnmodifbuscar
            // 
            this.btnmodifbuscar.Location = new System.Drawing.Point(115, 53);
            this.btnmodifbuscar.Name = "btnmodifbuscar";
            this.btnmodifbuscar.Size = new System.Drawing.Size(92, 37);
            this.btnmodifbuscar.TabIndex = 19;
            this.btnmodifbuscar.Text = "&Buscar";
            this.btnmodifbuscar.UseVisualStyleBackColor = true;
            this.btnmodifbuscar.Click += new System.EventHandler(this.btnmodifbuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. Lista:";
            // 
            // txtmodnl
            // 
            this.txtmodnl.Location = new System.Drawing.Point(125, 24);
            this.txtmodnl.Mask = "00000000";
            this.txtmodnl.Name = "txtmodnl";
            this.txtmodnl.Size = new System.Drawing.Size(66, 23);
            this.txtmodnl.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.gbbaja);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(516, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar";
            // 
            // gbbaja
            // 
            this.gbbaja.Controls.Add(this.groupBox3);
            this.gbbaja.Controls.Add(this.groupBox2);
            this.gbbaja.Font = new System.Drawing.Font("Arial", 10F);
            this.gbbaja.Location = new System.Drawing.Point(120, 25);
            this.gbbaja.Name = "gbbaja";
            this.gbbaja.Size = new System.Drawing.Size(302, 282);
            this.gbbaja.TabIndex = 18;
            this.gbbaja.TabStop = false;
            this.gbbaja.Text = "Seleccione a quien desea dar de baja";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblnombrealm);
            this.groupBox3.Controls.Add(this.btninfeliminar);
            this.groupBox3.Location = new System.Drawing.Point(6, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 150);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F);
            this.label9.Location = new System.Drawing.Point(30, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Nombre:";
            // 
            // lblnombrealm
            // 
            this.lblnombrealm.AutoSize = true;
            this.lblnombrealm.Font = new System.Drawing.Font("Arial", 10F);
            this.lblnombrealm.Location = new System.Drawing.Point(30, 66);
            this.lblnombrealm.Name = "lblnombrealm";
            this.lblnombrealm.Size = new System.Drawing.Size(199, 16);
            this.lblnombrealm.TabIndex = 18;
            this.lblnombrealm.Text = "escriba el numero a  buscar :c";
            // 
            // btninfeliminar
            // 
            this.btninfeliminar.Enabled = false;
            this.btninfeliminar.Location = new System.Drawing.Point(73, 95);
            this.btninfeliminar.Name = "btninfeliminar";
            this.btninfeliminar.Size = new System.Drawing.Size(119, 46);
            this.btninfeliminar.TabIndex = 17;
            this.btninfeliminar.Text = "&Eliminar";
            this.btninfeliminar.UseVisualStyleBackColor = true;
            this.btninfeliminar.Click += new System.EventHandler(this.btninfeliminar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnbuscar);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtbajanc);
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 107);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(97, 70);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 32);
            this.btnbuscar.TabIndex = 20;
            this.btnbuscar.Text = "&Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "No. lista";
            // 
            // txtbajanc
            // 
            this.txtbajanc.Location = new System.Drawing.Point(79, 33);
            this.txtbajanc.Mask = "00000000";
            this.txtbajanc.Name = "txtbajanc";
            this.txtbajanc.Size = new System.Drawing.Size(75, 23);
            this.txtbajanc.TabIndex = 13;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightGray;
            this.tabPage4.Controls.Add(this.qrrecuperado);
            this.tabPage4.Controls.Add(this.dgvalumno);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(516, 359);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Consultar";
            // 
            // dgvalumno
            // 
            this.dgvalumno.AllowUserToAddRows = false;
            this.dgvalumno.AllowUserToDeleteRows = false;
            this.dgvalumno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvalumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvalumno.Location = new System.Drawing.Point(28, 6);
            this.dgvalumno.Name = "dgvalumno";
            this.dgvalumno.ReadOnly = true;
            this.dgvalumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvalumno.Size = new System.Drawing.Size(469, 211);
            this.dgvalumno.TabIndex = 22;
            this.dgvalumno.SelectionChanged += new System.EventHandler(this.dgvalumno_SelectionChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnrecuperarqr);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.btnbuscaralm);
            this.groupBox4.Controls.Add(this.btnconstodos);
            this.groupBox4.Controls.Add(this.cmblistado);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtconsalmn);
            this.groupBox4.Location = new System.Drawing.Point(28, 223);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 126);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar por";
            // 
            // btnrecuperarqr
            // 
            this.btnrecuperarqr.Enabled = false;
            this.btnrecuperarqr.Location = new System.Drawing.Point(238, 90);
            this.btnrecuperarqr.Name = "btnrecuperarqr";
            this.btnrecuperarqr.Size = new System.Drawing.Size(120, 26);
            this.btnrecuperarqr.TabIndex = 29;
            this.btnrecuperarqr.Text = "&Recuperar QR";
            this.btnrecuperarqr.UseVisualStyleBackColor = true;
            this.btnrecuperarqr.Click += new System.EventHandler(this.btnrecuperarqr_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Tipo de actvidad:";
            // 
            // btnbuscaralm
            // 
            this.btnbuscaralm.Location = new System.Drawing.Point(266, 23);
            this.btnbuscaralm.Name = "btnbuscaralm";
            this.btnbuscaralm.Size = new System.Drawing.Size(92, 29);
            this.btnbuscaralm.TabIndex = 25;
            this.btnbuscaralm.Text = "&Buscar";
            this.btnbuscaralm.UseVisualStyleBackColor = true;
            this.btnbuscaralm.Click += new System.EventHandler(this.btnbuscaralm_Click);
            // 
            // btnconstodos
            // 
            this.btnconstodos.Location = new System.Drawing.Point(266, 55);
            this.btnconstodos.Name = "btnconstodos";
            this.btnconstodos.Size = new System.Drawing.Size(92, 29);
            this.btnconstodos.TabIndex = 26;
            this.btnconstodos.Text = "&Mostrar";
            this.btnconstodos.UseVisualStyleBackColor = true;
            this.btnconstodos.Click += new System.EventHandler(this.btnconstodos_Click);
            // 
            // cmblistado
            // 
            this.cmblistado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmblistado.FormattingEnabled = true;
            this.cmblistado.Items.AddRange(new object[] {
            "Todas",
            "Aprendizaje",
            "Visual",
            "Auditiva"});
            this.cmblistado.Location = new System.Drawing.Point(141, 58);
            this.cmblistado.Name = "cmblistado";
            this.cmblistado.Size = new System.Drawing.Size(119, 24);
            this.cmblistado.TabIndex = 27;
            this.cmblistado.SelectedIndexChanged += new System.EventHandler(this.cmblistado_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Nombre del alumno:";
            // 
            // txtconsalmn
            // 
            this.txtconsalmn.Location = new System.Drawing.Point(141, 29);
            this.txtconsalmn.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.txtconsalmn.Name = "txtconsalmn";
            this.txtconsalmn.Size = new System.Drawing.Size(119, 23);
            this.txtconsalmn.TabIndex = 24;
            // 
            // qrrecuperado
            // 
            this.qrrecuperado.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
            this.qrrecuperado.Image = ((System.Drawing.Image)(resources.GetObject("qrrecuperado.Image")));
            this.qrrecuperado.Location = new System.Drawing.Point(410, 246);
            this.qrrecuperado.Name = "qrrecuperado";
            this.qrrecuperado.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two;
            this.qrrecuperado.Size = new System.Drawing.Size(100, 93);
            this.qrrecuperado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.qrrecuperado.TabIndex = 29;
            this.qrrecuperado.TabStop = false;
            this.qrrecuperado.Text = "qrCodeImgControl1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(157, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "CODIGO DE IDENTIFICACION:";
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 419);
            this.Controls.Add(this.panel1);
            this.Name = "Alumnos";
            this.Text = "Alumnos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Alumnos_FormClosing);
            this.Load += new System.EventHandler(this.Alumnos_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbdatos.ResumeLayout(false);
            this.gbdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictqrcode)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbinfomodif.ResumeLayout(false);
            this.gbinfomodif.PerformLayout();
            this.gbbuscarmodif.ResumeLayout(false);
            this.gbbuscarmodif.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbbaja.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvalumno)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrrecuperado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbdatos;
        private System.Windows.Forms.MaskedTextBox txtagapmat;
        private System.Windows.Forms.MaskedTextBox txtagappat;
        private System.Windows.Forms.MaskedTextBox txtagnom;
        private System.Windows.Forms.MaskedTextBox txtagnl;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label lblnuminstit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbinfomodif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnmodifalm;
        private System.Windows.Forms.MaskedTextBox txtmodapmat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtmodnom;
        private System.Windows.Forms.MaskedTextBox txtmodappat;
        private System.Windows.Forms.GroupBox gbbuscarmodif;
        private System.Windows.Forms.Button btnmodifbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtmodnl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbbaja;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblnombrealm;
        private System.Windows.Forms.Button btninfeliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtbajanc;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnconstodos;
        private System.Windows.Forms.Button btnbuscaralm;
        private System.Windows.Forms.MaskedTextBox txtconsalmn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvalumno;
        private System.Windows.Forms.ComboBox cmblistado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl pictqrcode;
        private System.Windows.Forms.Button btnrecuperarqr;
        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl qrrecuperado;
        private System.Windows.Forms.Label label12;
    }
}