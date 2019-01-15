namespace gardian
{
    partial class Factividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factividades));
            this.btnregresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnkinestesico = new System.Windows.Forms.RadioButton();
            this.rbtnvisual = new System.Windows.Forms.RadioButton();
            this.rbtnauditivo = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnseleccion = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtnexvista = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.Location = new System.Drawing.Point(12, 417);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(60, 33);
            this.btnregresar.TabIndex = 0;
            this.btnregresar.Text = "<< ";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECCIONE ACTIVIDAD";
            // 
            // rbtnkinestesico
            // 
            this.rbtnkinestesico.AutoSize = true;
            this.rbtnkinestesico.Checked = true;
            this.rbtnkinestesico.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnkinestesico.Location = new System.Drawing.Point(38, 84);
            this.rbtnkinestesico.Name = "rbtnkinestesico";
            this.rbtnkinestesico.Size = new System.Drawing.Size(184, 27);
            this.rbtnkinestesico.TabIndex = 2;
            this.rbtnkinestesico.TabStop = true;
            this.rbtnkinestesico.Text = "Juego kinestésico";
            this.rbtnkinestesico.UseVisualStyleBackColor = true;
            // 
            // rbtnvisual
            // 
            this.rbtnvisual.AutoSize = true;
            this.rbtnvisual.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnvisual.Location = new System.Drawing.Point(300, 84);
            this.rbtnvisual.Name = "rbtnvisual";
            this.rbtnvisual.Size = new System.Drawing.Size(135, 27);
            this.rbtnvisual.TabIndex = 3;
            this.rbtnvisual.Text = "Juego visual";
            this.rbtnvisual.UseVisualStyleBackColor = true;
            // 
            // rbtnauditivo
            // 
            this.rbtnauditivo.AutoSize = true;
            this.rbtnauditivo.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnauditivo.Location = new System.Drawing.Point(531, 84);
            this.rbtnauditivo.Name = "rbtnauditivo";
            this.rbtnauditivo.Size = new System.Drawing.Size(153, 27);
            this.rbtnauditivo.TabIndex = 4;
            this.rbtnauditivo.Text = "Juego auditivo";
            this.rbtnauditivo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbtnexvista);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.rbtnauditivo);
            this.panel1.Controls.Add(this.rbtnvisual);
            this.panel1.Controls.Add(this.rbtnkinestesico);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 347);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnseleccion
            // 
            this.btnseleccion.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseleccion.Location = new System.Drawing.Point(407, 365);
            this.btnseleccion.Name = "btnseleccion";
            this.btnseleccion.Size = new System.Drawing.Size(238, 61);
            this.btnseleccion.TabIndex = 9;
            this.btnseleccion.Text = "&Elegir";
            this.btnseleccion.UseVisualStyleBackColor = true;
            this.btnseleccion.Click += new System.EventHandler(this.btnseleccion_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::gardian.Properties.Resources.HNI_0100;
            this.pictureBox4.Location = new System.Drawing.Point(731, 123);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(249, 220);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(491, 123);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(237, 220);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(251, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 220);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gardian.Properties.Resources.HNI_0002;
            this.pictureBox1.Location = new System.Drawing.Point(11, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rbtnexvista
            // 
            this.rbtnexvista.AutoSize = true;
            this.rbtnexvista.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnexvista.Location = new System.Drawing.Point(765, 84);
            this.rbtnexvista.Name = "rbtnexvista";
            this.rbtnexvista.Size = new System.Drawing.Size(193, 27);
            this.rbtnexvista.TabIndex = 12;
            this.rbtnexvista.Text = "Examen de la vista";
            this.rbtnexvista.UseVisualStyleBackColor = true;
            // 
            // Factividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 462);
            this.Controls.Add(this.btnseleccion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnregresar);
            this.Name = "Factividades";
            this.Text = "ACTIVIDAD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Factividades_FormClosed);
            this.Load += new System.EventHandler(this.Factividades_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnkinestesico;
        private System.Windows.Forms.RadioButton rbtnvisual;
        private System.Windows.Forms.RadioButton rbtnauditivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnseleccion;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RadioButton rbtnexvista;
    }
}