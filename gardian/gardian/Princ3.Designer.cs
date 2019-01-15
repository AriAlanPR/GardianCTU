namespace gardian
{
    partial class Princ3
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
            this.tablajuego = new System.Windows.Forms.TableLayoutPanel();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.tmrintro = new System.Windows.Forms.Timer(this.components);
            this.panelintro = new System.Windows.Forms.Panel();
            this.imgintro = new System.Windows.Forms.PictureBox();
            this.btnempezar = new System.Windows.Forms.Button();
            this.timerbarajear = new System.Windows.Forms.Timer(this.components);
            this.timeracerr = new System.Windows.Forms.Timer(this.components);
            this.tablajuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.panelintro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgintro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.Location = new System.Drawing.Point(12, 11);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(56, 27);
            this.btnregresar.TabIndex = 4;
            this.btnregresar.Text = "<< ";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // tablajuego
            // 
            this.tablajuego.ColumnCount = 2;
            this.tablajuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.58757F));
            this.tablajuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.41243F));
            this.tablajuego.Controls.Add(this.pb3, 0, 1);
            this.tablajuego.Controls.Add(this.pb4, 1, 1);
            this.tablajuego.Controls.Add(this.pb1, 0, 0);
            this.tablajuego.Controls.Add(this.pb2, 1, 0);
            this.tablajuego.Location = new System.Drawing.Point(91, 32);
            this.tablajuego.Name = "tablajuego";
            this.tablajuego.RowCount = 2;
            this.tablajuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablajuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablajuego.Size = new System.Drawing.Size(577, 349);
            this.tablajuego.TabIndex = 5;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(3, 177);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(274, 169);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 3;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.pb3_Click);
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(283, 177);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(291, 169);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 4;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.pb4_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(3, 3);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(274, 168);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(283, 3);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(291, 168);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // tmrintro
            // 
            this.tmrintro.Enabled = true;
            this.tmrintro.Interval = 14050;
            this.tmrintro.Tick += new System.EventHandler(this.tmrintro_Tick);
            // 
            // panelintro
            // 
            this.panelintro.Controls.Add(this.imgintro);
            this.panelintro.Location = new System.Drawing.Point(74, 19);
            this.panelintro.Name = "panelintro";
            this.panelintro.Size = new System.Drawing.Size(613, 383);
            this.panelintro.TabIndex = 7;
            // 
            // imgintro
            // 
            this.imgintro.Image = global::gardian.Properties.Resources.hearlogo;
            this.imgintro.Location = new System.Drawing.Point(80, 0);
            this.imgintro.Name = "imgintro";
            this.imgintro.Size = new System.Drawing.Size(449, 383);
            this.imgintro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgintro.TabIndex = 12;
            this.imgintro.TabStop = false;
            // 
            // btnempezar
            // 
            this.btnempezar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempezar.Location = new System.Drawing.Point(283, 409);
            this.btnempezar.Name = "btnempezar";
            this.btnempezar.Size = new System.Drawing.Size(184, 47);
            this.btnempezar.TabIndex = 9;
            this.btnempezar.Text = "Empezar :D";
            this.btnempezar.UseVisualStyleBackColor = true;
            this.btnempezar.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerbarajear
            // 
            this.timerbarajear.Interval = 1000;
            this.timerbarajear.Tick += new System.EventHandler(this.timerbarajear_Tick);
            // 
            // timeracerr
            // 
            this.timeracerr.Interval = 5000;
            this.timeracerr.Tick += new System.EventHandler(this.timeracerr_Tick_1);
            // 
            // Princ3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 466);
            this.Controls.Add(this.btnempezar);
            this.Controls.Add(this.panelintro);
            this.Controls.Add(this.tablajuego);
            this.Controls.Add(this.btnregresar);
            this.Name = "Princ3";
            this.Text = "Principiante -Auditivo-";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Princ3_FormClosed);
            this.Load += new System.EventHandler(this.Princ3_Load);
            this.Shown += new System.EventHandler(this.Princ3_Shown);
            this.tablajuego.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.panelintro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgintro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.TableLayoutPanel tablajuego;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Timer tmrintro;
        private System.Windows.Forms.Panel panelintro;
        private System.Windows.Forms.Button btnempezar;
        private System.Windows.Forms.PictureBox imgintro;
        private System.Windows.Forms.Timer timerbarajear;
        private System.Windows.Forms.Timer timeracerr;
    }
}