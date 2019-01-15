namespace gardian
{
    partial class Avan1
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
            this.btnregresar = new System.Windows.Forms.Button();
            this.paneljuego = new System.Windows.Forms.TableLayoutPanel();
            this.pbxatrapame = new System.Windows.Forms.PictureBox();
            this.pctmarco = new System.Windows.Forms.PictureBox();
            this.lblpuntos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxatrapame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctmarco)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.Location = new System.Drawing.Point(12, 630);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(71, 31);
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
            this.paneljuego.Location = new System.Drawing.Point(46, 51);
            this.paneljuego.Name = "paneljuego";
            this.paneljuego.RowCount = 3;
            this.paneljuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.62637F));
            this.paneljuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.37363F));
            this.paneljuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.paneljuego.Size = new System.Drawing.Size(753, 531);
            this.paneljuego.TabIndex = 19;
            // 
            // pbxatrapame
            // 
            this.pbxatrapame.BackColor = System.Drawing.Color.Transparent;
            this.pbxatrapame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxatrapame.Image = global::gardian.Properties.Resources.duck_1;
            this.pbxatrapame.Location = new System.Drawing.Point(838, 172);
            this.pbxatrapame.Name = "pbxatrapame";
            this.pbxatrapame.Size = new System.Drawing.Size(144, 137);
            this.pbxatrapame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxatrapame.TabIndex = 23;
            this.pbxatrapame.TabStop = false;
            // 
            // pctmarco
            // 
            this.pctmarco.BackColor = System.Drawing.Color.Transparent;
            this.pctmarco.Image = global::gardian.Properties.Resources.marco_wam;
            this.pctmarco.Location = new System.Drawing.Point(825, 159);
            this.pctmarco.Name = "pctmarco";
            this.pctmarco.Size = new System.Drawing.Size(165, 161);
            this.pctmarco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctmarco.TabIndex = 24;
            this.pctmarco.TabStop = false;
            // 
            // lblpuntos
            // 
            this.lblpuntos.AutoSize = true;
            this.lblpuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntos.Location = new System.Drawing.Point(943, 405);
            this.lblpuntos.Name = "lblpuntos";
            this.lblpuntos.Size = new System.Drawing.Size(23, 25);
            this.lblpuntos.TabIndex = 22;
            this.lblpuntos.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(822, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "PUNTOS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(822, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "ATRAPAME SI PUEDES";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 50000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Avan1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gardian.Properties.Resources.fondowad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 673);
            this.Controls.Add(this.paneljuego);
            this.Controls.Add(this.pbxatrapame);
            this.Controls.Add(this.pctmarco);
            this.Controls.Add(this.lblpuntos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnregresar);
            this.Name = "Avan1";
            this.Text = "Avanzado (Atrapadas)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Avan1_FormClosed);
            this.Load += new System.EventHandler(this.Avan1_Load);
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
        private System.Windows.Forms.Label lblpuntos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}