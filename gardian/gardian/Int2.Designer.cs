namespace gardian
{
    partial class Int2
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
            this.lblrecord = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.paneljuego = new System.Windows.Forms.Panel();
            this.tmrvi = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.Location = new System.Drawing.Point(21, 476);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(115, 31);
            this.btnregresar.TabIndex = 4;
            this.btnregresar.Text = "<< Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // lblrecord
            // 
            this.lblrecord.AutoSize = true;
            this.lblrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecord.Location = new System.Drawing.Point(685, 121);
            this.lblrecord.Name = "lblrecord";
            this.lblrecord.Size = new System.Drawing.Size(23, 25);
            this.lblrecord.TabIndex = 13;
            this.lblrecord.Text = "0";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(636, 85);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(128, 25);
            this.lbl.TabIndex = 12;
            this.lbl.Text = "Movimientos:";
            // 
            // paneljuego
            // 
            this.paneljuego.Location = new System.Drawing.Point(21, 20);
            this.paneljuego.Name = "paneljuego";
            this.paneljuego.Size = new System.Drawing.Size(609, 435);
            this.paneljuego.TabIndex = 10;
            // 
            // tmrvi
            // 
            this.tmrvi.Interval = 350;
            this.tmrvi.Tick += new System.EventHandler(this.tmrvi_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(636, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "Listo!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Int2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblrecord);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.paneljuego);
            this.Controls.Add(this.btnregresar);
            this.Name = "Int2";
            this.Text = "Intermedio (Memorama)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Int2_FormClosed);
            this.Load += new System.EventHandler(this.Int2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Label lblrecord;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel paneljuego;
        private System.Windows.Forms.Timer tmrvi;
        private System.Windows.Forms.Button button1;
    }
}