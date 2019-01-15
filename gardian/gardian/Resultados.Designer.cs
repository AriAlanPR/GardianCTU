namespace gardian
{
    partial class Resultados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultados));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnon = new System.Windows.Forms.Button();
            this.btnoff = new System.Windows.Forms.Button();
            this.cmbcamara = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.vspqr = new AForge.Controls.VideoSourcePlayer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblresnl = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblresapmat = new System.Windows.Forms.Label();
            this.lblresnom = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblporce2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblporca2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblpnta2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblpnte2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblprce1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblprca1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpnta1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblpnte1 = new System.Windows.Forms.Label();
            this.tmrscan = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnconnect = new System.Windows.Forms.ToolStripDropDownButton();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnon);
            this.groupBox1.Controls.Add(this.btnoff);
            this.groupBox1.Controls.Add(this.cmbcamara);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.vspqr);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 433);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnon
            // 
            this.btnon.Image = global::gardian.Properties.Resources.play_icon;
            this.btnon.Location = new System.Drawing.Point(439, 71);
            this.btnon.Name = "btnon";
            this.btnon.Size = new System.Drawing.Size(36, 35);
            this.btnon.TabIndex = 16;
            this.btnon.UseVisualStyleBackColor = true;
            this.btnon.Click += new System.EventHandler(this.btnon_Click);
            // 
            // btnoff
            // 
            this.btnoff.Image = global::gardian.Properties.Resources.stop_18;
            this.btnoff.Location = new System.Drawing.Point(439, 118);
            this.btnoff.Name = "btnoff";
            this.btnoff.Size = new System.Drawing.Size(36, 33);
            this.btnoff.TabIndex = 15;
            this.btnoff.UseVisualStyleBackColor = true;
            this.btnoff.Click += new System.EventHandler(this.btnoff_Click);
            // 
            // cmbcamara
            // 
            this.cmbcamara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcamara.FormattingEnabled = true;
            this.cmbcamara.Location = new System.Drawing.Point(481, 27);
            this.cmbcamara.Name = "cmbcamara";
            this.cmbcamara.Size = new System.Drawing.Size(350, 31);
            this.cmbcamara.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(435, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 21);
            this.label18.TabIndex = 13;
            this.label18.Text = "Fuente de video:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // vspqr
            // 
            this.vspqr.Location = new System.Drawing.Point(481, 61);
            this.vspqr.Name = "vspqr";
            this.vspqr.Size = new System.Drawing.Size(350, 183);
            this.vspqr.TabIndex = 12;
            this.vspqr.Text = "videoSourcePlayer1";
            this.vspqr.VideoSource = null;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblresnl);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.lblresapmat);
            this.groupBox4.Controls.Add(this.lblresnom);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.btnregistrar);
            this.groupBox4.Location = new System.Drawing.Point(439, 250);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(392, 172);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Guardar datos";
            // 
            // lblresnl
            // 
            this.lblresnl.AutoSize = true;
            this.lblresnl.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresnl.Location = new System.Drawing.Point(131, 37);
            this.lblresnl.Name = "lblresnl";
            this.lblresnl.Size = new System.Drawing.Size(40, 21);
            this.lblresnl.TabIndex = 18;
            this.lblresnl.Text = "???";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(38, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 21);
            this.label20.TabIndex = 17;
            this.label20.Text = "No_Lista:";
            // 
            // lblresapmat
            // 
            this.lblresapmat.AutoSize = true;
            this.lblresapmat.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresapmat.Location = new System.Drawing.Point(38, 246);
            this.lblresapmat.Name = "lblresapmat";
            this.lblresapmat.Size = new System.Drawing.Size(0, 21);
            this.lblresapmat.TabIndex = 16;
            this.lblresapmat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblresnom
            // 
            this.lblresnom.AutoSize = true;
            this.lblresnom.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresnom.Location = new System.Drawing.Point(38, 100);
            this.lblresnom.Name = "lblresnom";
            this.lblresnom.Size = new System.Drawing.Size(40, 21);
            this.lblresnom.TabIndex = 13;
            this.lblresnom.Text = "???";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(38, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 21);
            this.label17.TabIndex = 12;
            this.label17.Text = "Nombre:";
            // 
            // btnregistrar
            // 
            this.btnregistrar.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Location = new System.Drawing.Point(135, 129);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(112, 31);
            this.btnregistrar.TabIndex = 11;
            this.btnregistrar.Text = "&Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblporce2);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblporca2);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lblpnta2);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lblpnte2);
            this.groupBox3.Location = new System.Drawing.Point(6, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 172);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Promedio de resultados anteriores";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "Puntos";
            // 
            // lblporce2
            // 
            this.lblporce2.AutoSize = true;
            this.lblporce2.Location = new System.Drawing.Point(314, 112);
            this.lblporce2.Name = "lblporce2";
            this.lblporce2.Size = new System.Drawing.Size(21, 23);
            this.lblporce2.TabIndex = 7;
            this.lblporce2.Text = "?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Aciertos:";
            // 
            // lblporca2
            // 
            this.lblporca2.AutoSize = true;
            this.lblporca2.Location = new System.Drawing.Point(314, 67);
            this.lblporca2.Name = "lblporca2";
            this.lblporca2.Size = new System.Drawing.Size(21, 23);
            this.lblporca2.TabIndex = 6;
            this.lblporca2.Text = "?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 23);
            this.label13.TabIndex = 1;
            this.label13.Text = "Errores:";
            // 
            // lblpnta2
            // 
            this.lblpnta2.AutoSize = true;
            this.lblpnta2.Location = new System.Drawing.Point(161, 67);
            this.lblpnta2.Name = "lblpnta2";
            this.lblpnta2.Size = new System.Drawing.Size(21, 23);
            this.lblpnta2.TabIndex = 2;
            this.lblpnta2.Text = "?";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(274, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 23);
            this.label15.TabIndex = 4;
            this.label15.Text = "Porcentaje";
            // 
            // lblpnte2
            // 
            this.lblpnte2.AutoSize = true;
            this.lblpnte2.Location = new System.Drawing.Point(161, 112);
            this.lblpnte2.Name = "lblpnte2";
            this.lblpnte2.Size = new System.Drawing.Size(21, 23);
            this.lblpnte2.TabIndex = 3;
            this.lblpnte2.Text = "?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblprce1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblprca1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblpnta1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblpnte1);
            this.groupBox2.Location = new System.Drawing.Point(6, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 187);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "En esta ocasión";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Puntos";
            // 
            // lblprce1
            // 
            this.lblprce1.AutoSize = true;
            this.lblprce1.Location = new System.Drawing.Point(314, 112);
            this.lblprce1.Name = "lblprce1";
            this.lblprce1.Size = new System.Drawing.Size(21, 23);
            this.lblprce1.TabIndex = 7;
            this.lblprce1.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aciertos:";
            // 
            // lblprca1
            // 
            this.lblprca1.AutoSize = true;
            this.lblprca1.Location = new System.Drawing.Point(314, 67);
            this.lblprca1.Name = "lblprca1";
            this.lblprca1.Size = new System.Drawing.Size(21, 23);
            this.lblprca1.TabIndex = 6;
            this.lblprca1.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Errores:";
            // 
            // lblpnta1
            // 
            this.lblpnta1.AutoSize = true;
            this.lblpnta1.Location = new System.Drawing.Point(161, 67);
            this.lblpnta1.Name = "lblpnta1";
            this.lblpnta1.Size = new System.Drawing.Size(21, 23);
            this.lblpnta1.TabIndex = 2;
            this.lblpnta1.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Porcentaje";
            // 
            // lblpnte1
            // 
            this.lblpnte1.AutoSize = true;
            this.lblpnte1.Location = new System.Drawing.Point(161, 112);
            this.lblpnte1.Name = "lblpnte1";
            this.lblpnte1.Size = new System.Drawing.Size(21, 23);
            this.lblpnte1.TabIndex = 3;
            this.lblpnte1.Text = "?";
            // 
            // tmrscan
            // 
            this.tmrscan.Interval = 1000;
            this.tmrscan.Tick += new System.EventHandler(this.tmrscan_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 444);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(870, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnconnect
            // 
            this.btnconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnconnect.Image = ((System.Drawing.Image)(resources.GetObject("btnconnect.Image")));
            this.btnconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(152, 20);
            this.btnconnect.Text = "&Conectar a base de datos";
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 466);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Resultados_FormClosing);
            this.Load += new System.EventHandler(this.Resultados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpnte1;
        private System.Windows.Forms.Label lblpnta1;
        private System.Windows.Forms.Label lblprce1;
        private System.Windows.Forms.Label lblprca1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblporce2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblporca2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblpnta2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblpnte2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Label lblresnom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblresapmat;
        private System.Windows.Forms.Label lblresnl;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Timer tmrscan;
        private AForge.Controls.VideoSourcePlayer vspqr;
        private System.Windows.Forms.ComboBox cmbcamara;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnon;
        private System.Windows.Forms.Button btnoff;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnconnect;
    }
}