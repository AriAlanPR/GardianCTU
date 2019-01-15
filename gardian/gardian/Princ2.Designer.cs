namespace gardian
{
    partial class Princ2
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
            this.paneljuego = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl = new System.Windows.Forms.Label();
            this.lblrecord = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.Location = new System.Drawing.Point(12, 335);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(51, 31);
            this.btnregresar.TabIndex = 4;
            this.btnregresar.Text = "<< ";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // paneljuego
            // 
            this.paneljuego.Location = new System.Drawing.Point(12, 12);
            this.paneljuego.Name = "paneljuego";
            this.paneljuego.Size = new System.Drawing.Size(559, 317);
            this.paneljuego.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(577, 105);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(128, 25);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "Movimientos:";
            // 
            // lblrecord
            // 
            this.lblrecord.AutoSize = true;
            this.lblrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecord.Location = new System.Drawing.Point(626, 141);
            this.lblrecord.Name = "lblrecord";
            this.lblrecord.Size = new System.Drawing.Size(23, 25);
            this.lblrecord.TabIndex = 9;
            this.lblrecord.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(574, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Listo!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Princ2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblrecord);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.paneljuego);
            this.Controls.Add(this.btnregresar);
            this.Name = "Princ2";
            this.Text = "Principiante (Memorama)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Princ2_FormClosed);
            this.Load += new System.EventHandler(this.Princ2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Panel paneljuego;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblrecord;
        private System.Windows.Forms.Button button1;
    }
}