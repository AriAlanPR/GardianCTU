namespace gardian
{
    partial class Int1
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
            this.lblpuntos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paneljuego = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctmarco = new System.Windows.Forms.PictureBox();
            this.pbxatrapame = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctmarco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxatrapame)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.Location = new System.Drawing.Point(12, 443);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(115, 31);
            this.btnregresar.TabIndex = 4;
            this.btnregresar.Text = "<< ";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // lblpuntos
            // 
            this.lblpuntos.AutoSize = true;
            this.lblpuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntos.Location = new System.Drawing.Point(924, 392);
            this.lblpuntos.Name = "lblpuntos";
            this.lblpuntos.Size = new System.Drawing.Size(23, 25);
            this.lblpuntos.TabIndex = 16;
            this.lblpuntos.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(803, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "PUNTOS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(801, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "ATRAPAME SI PUEDES";
            // 
            // paneljuego
            // 
            this.paneljuego.BackColor = System.Drawing.Color.Transparent;
            this.paneljuego.ColumnCount = 3;
            this.paneljuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.paneljuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.paneljuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.paneljuego.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paneljuego.Location = new System.Drawing.Point(25, 36);
            this.paneljuego.Name = "paneljuego";
            this.paneljuego.RowCount = 2;
            this.paneljuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.paneljuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.paneljuego.Size = new System.Drawing.Size(753, 381);
            this.paneljuego.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pbxatrapame);
            this.panel1.Controls.Add(this.pctmarco);
            this.panel1.Location = new System.Drawing.Point(807, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 161);
            this.panel1.TabIndex = 17;
            // 
            // pctmarco
            // 
            this.pctmarco.BackColor = System.Drawing.Color.Transparent;
            this.pctmarco.Image = global::gardian.Properties.Resources.marco_wam;
            this.pctmarco.Location = new System.Drawing.Point(0, -1);
            this.pctmarco.Name = "pctmarco";
            this.pctmarco.Size = new System.Drawing.Size(165, 161);
            this.pctmarco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctmarco.TabIndex = 18;
            this.pctmarco.TabStop = false;
            this.pctmarco.Click += new System.EventHandler(this.pctmarco_Click);
            // 
            // pbxatrapame
            // 
            this.pbxatrapame.BackColor = System.Drawing.Color.Transparent;
            this.pbxatrapame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxatrapame.Image = global::gardian.Properties.Resources.cow_1;
            this.pbxatrapame.Location = new System.Drawing.Point(13, 12);
            this.pbxatrapame.Name = "pbxatrapame";
            this.pbxatrapame.Size = new System.Drawing.Size(144, 137);
            this.pbxatrapame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxatrapame.TabIndex = 18;
            this.pbxatrapame.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1650;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 50000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Int1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gardian.Properties.Resources.fondowac;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 486);
            this.Controls.Add(this.lblpuntos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paneljuego);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.panel1);
            this.Name = "Int1";
            this.Text = "Intermedio (Atrapadas)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Int1_FormClosed);
            this.Load += new System.EventHandler(this.Int1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctmarco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxatrapame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Label lblpuntos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel paneljuego;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxatrapame;
        private System.Windows.Forms.PictureBox pctmarco;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}