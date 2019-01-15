namespace gardian
{
    partial class Princ1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Princ1));
            this.btnregresar = new System.Windows.Forms.Button();
            this.paneljuego = new System.Windows.Forms.TableLayoutPanel();
            this.pbxatrapame = new System.Windows.Forms.PictureBox();
            this.pctmarco = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpuntos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxatrapame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctmarco)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.Location = new System.Drawing.Point(12, 452);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(81, 31);
            this.btnregresar.TabIndex = 4;
            this.btnregresar.Text = "<< ";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // paneljuego
            // 
            this.paneljuego.BackColor = System.Drawing.Color.Transparent;
            this.paneljuego.ColumnCount = 3;
            this.paneljuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.paneljuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.paneljuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.paneljuego.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paneljuego.Location = new System.Drawing.Point(36, 12);
            this.paneljuego.Name = "paneljuego";
            this.paneljuego.RowCount = 2;
            this.paneljuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.paneljuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.paneljuego.Size = new System.Drawing.Size(766, 340);
            this.paneljuego.TabIndex = 5;
            // 
            // pbxatrapame
            // 
            this.pbxatrapame.BackColor = System.Drawing.Color.Transparent;
            this.pbxatrapame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxatrapame.Image = global::gardian.Properties.Resources.cat_1;
            this.pbxatrapame.Location = new System.Drawing.Point(848, 139);
            this.pbxatrapame.Name = "pbxatrapame";
            this.pbxatrapame.Size = new System.Drawing.Size(144, 137);
            this.pbxatrapame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxatrapame.TabIndex = 6;
            this.pbxatrapame.TabStop = false;
            // 
            // pctmarco
            // 
            this.pctmarco.BackColor = System.Drawing.Color.Transparent;
            this.pctmarco.Image = ((System.Drawing.Image)(resources.GetObject("pctmarco.Image")));
            this.pctmarco.Location = new System.Drawing.Point(835, 128);
            this.pctmarco.Name = "pctmarco";
            this.pctmarco.Size = new System.Drawing.Size(165, 161);
            this.pctmarco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctmarco.TabIndex = 7;
            this.pctmarco.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(829, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "ATRAPAME SI PUEDES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(831, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "PUNTOS:";
            // 
            // lblpuntos
            // 
            this.lblpuntos.AutoSize = true;
            this.lblpuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntos.Location = new System.Drawing.Point(952, 370);
            this.lblpuntos.Name = "lblpuntos";
            this.lblpuntos.Size = new System.Drawing.Size(23, 25);
            this.lblpuntos.TabIndex = 10;
            this.lblpuntos.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 50000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Princ1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 486);
            this.Controls.Add(this.lblpuntos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxatrapame);
            this.Controls.Add(this.paneljuego);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.pctmarco);
            this.DoubleBuffered = true;
            this.Name = "Princ1";
            this.Text = "Principiante (Atrapadas)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Princ1_FormClosed);
            this.Load += new System.EventHandler(this.Princ1_Load);
            this.Shown += new System.EventHandler(this.Princ1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxatrapame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctmarco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.TableLayoutPanel paneljuego;
        private System.Windows.Forms.PictureBox pbxatrapame;
        private System.Windows.Forms.PictureBox pctmarco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblpuntos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}