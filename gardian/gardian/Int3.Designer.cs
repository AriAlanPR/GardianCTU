namespace gardian
{
    partial class Int3
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
            this.panelintro = new System.Windows.Forms.Panel();
            this.imgintro = new System.Windows.Forms.PictureBox();
            this.tablajuego = new System.Windows.Forms.TableLayoutPanel();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.btnempezar = new System.Windows.Forms.Button();
            this.tmrintro = new System.Windows.Forms.Timer(this.components);
            this.timerbarajear = new System.Windows.Forms.Timer(this.components);
            this.panelintro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgintro)).BeginInit();
            this.tablajuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.Location = new System.Drawing.Point(12, 12);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(54, 33);
            this.btnregresar.TabIndex = 4;
            this.btnregresar.Text = "<< ";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // panelintro
            // 
            this.panelintro.Controls.Add(this.imgintro);
            this.panelintro.Location = new System.Drawing.Point(72, 34);
            this.panelintro.Name = "panelintro";
            this.panelintro.Size = new System.Drawing.Size(840, 425);
            this.panelintro.TabIndex = 14;
            // 
            // imgintro
            // 
            this.imgintro.Image = global::gardian.Properties.Resources.hearlogo;
            this.imgintro.Location = new System.Drawing.Point(185, 0);
            this.imgintro.Name = "imgintro";
            this.imgintro.Size = new System.Drawing.Size(461, 426);
            this.imgintro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgintro.TabIndex = 16;
            this.imgintro.TabStop = false;
            // 
            // tablajuego
            // 
            this.tablajuego.ColumnCount = 3;
            this.tablajuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.58757F));
            this.tablajuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.41243F));
            this.tablajuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tablajuego.Controls.Add(this.pb4, 0, 1);
            this.tablajuego.Controls.Add(this.pb5, 1, 1);
            this.tablajuego.Controls.Add(this.pb1, 0, 0);
            this.tablajuego.Controls.Add(this.pb2, 1, 0);
            this.tablajuego.Controls.Add(this.pb3, 2, 0);
            this.tablajuego.Controls.Add(this.pb6, 2, 1);
            this.tablajuego.Location = new System.Drawing.Point(91, 34);
            this.tablajuego.Name = "tablajuego";
            this.tablajuego.RowCount = 2;
            this.tablajuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablajuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablajuego.Size = new System.Drawing.Size(780, 425);
            this.tablajuego.TabIndex = 13;
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(3, 215);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(244, 207);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 3;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.pb4_Click);
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(253, 215);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(259, 207);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 4;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this.pb5_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(3, 3);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(244, 206);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(253, 3);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(259, 206);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(518, 3);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(253, 206);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 5;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.pb3_Click);
            // 
            // pb6
            // 
            this.pb6.Location = new System.Drawing.Point(518, 215);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(253, 207);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 6;
            this.pb6.TabStop = false;
            this.pb6.Click += new System.EventHandler(this.pb6_Click);
            // 
            // btnempezar
            // 
            this.btnempezar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempezar.Location = new System.Drawing.Point(374, 465);
            this.btnempezar.Name = "btnempezar";
            this.btnempezar.Size = new System.Drawing.Size(184, 51);
            this.btnempezar.TabIndex = 15;
            this.btnempezar.Text = "Empezar :D";
            this.btnempezar.UseVisualStyleBackColor = true;
            this.btnempezar.Click += new System.EventHandler(this.btnempezar_Click);
            // 
            // tmrintro
            // 
            this.tmrintro.Enabled = true;
            this.tmrintro.Interval = 14050;
            this.tmrintro.Tick += new System.EventHandler(this.tmrintro_Tick);
            // 
            // timerbarajear
            // 
            this.timerbarajear.Tick += new System.EventHandler(this.timerbarajear_Tick);
            // 
            // Int3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 528);
            this.Controls.Add(this.panelintro);
            this.Controls.Add(this.tablajuego);
            this.Controls.Add(this.btnempezar);
            this.Controls.Add(this.btnregresar);
            this.Name = "Int3";
            this.Text = "Intermedio -Auditivo-";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Int3_FormClosed);
            this.Load += new System.EventHandler(this.Int3_Load);
            this.Shown += new System.EventHandler(this.Int3_Shown);
            this.panelintro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgintro)).EndInit();
            this.tablajuego.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.PictureBox imgintro;
        private System.Windows.Forms.Panel panelintro;
        private System.Windows.Forms.TableLayoutPanel tablajuego;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Button btnempezar;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.Timer tmrintro;
        private System.Windows.Forms.Timer timerbarajear;
    }
}