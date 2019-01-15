namespace gardian
{
    partial class FMenuP
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
            this.btnprinc = new System.Windows.Forms.Button();
            this.btnavan = new System.Windows.Forms.Button();
            this.btnint = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panellevel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnprinc
            // 
            this.btnprinc.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprinc.Location = new System.Drawing.Point(99, 121);
            this.btnprinc.Name = "btnprinc";
            this.btnprinc.Size = new System.Drawing.Size(229, 69);
            this.btnprinc.TabIndex = 0;
            this.btnprinc.Text = "Principiante";
            this.btnprinc.UseVisualStyleBackColor = true;
            this.btnprinc.Click += new System.EventHandler(this.btnprinc_Click);
            // 
            // btnavan
            // 
            this.btnavan.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnavan.Location = new System.Drawing.Point(99, 328);
            this.btnavan.Name = "btnavan";
            this.btnavan.Size = new System.Drawing.Size(229, 71);
            this.btnavan.TabIndex = 1;
            this.btnavan.Text = "Avanzado";
            this.btnavan.UseVisualStyleBackColor = true;
            this.btnavan.Click += new System.EventHandler(this.btnavan_Click);
            // 
            // btnint
            // 
            this.btnint.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnint.Location = new System.Drawing.Point(99, 222);
            this.btnint.Name = "btnint";
            this.btnint.Size = new System.Drawing.Size(229, 75);
            this.btnint.TabIndex = 2;
            this.btnint.Text = "Intermedio";
            this.btnint.UseVisualStyleBackColor = true;
            this.btnint.Click += new System.EventHandler(this.btnint_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.Location = new System.Drawing.Point(12, 462);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(115, 33);
            this.btnregresar.TabIndex = 3;
            this.btnregresar.Text = "<< Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "NIVEL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(343, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 98);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(343, 210);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 98);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(343, 314);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(143, 98);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // panellevel
            // 
            this.panellevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panellevel.Location = new System.Drawing.Point(12, 83);
            this.panellevel.Name = "panellevel";
            this.panellevel.Size = new System.Drawing.Size(500, 351);
            this.panellevel.TabIndex = 8;
            // 
            // FMenuP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 518);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btnint);
            this.Controls.Add(this.btnavan);
            this.Controls.Add(this.btnprinc);
            this.Controls.Add(this.panellevel);
            this.Name = "FMenuP";
            this.Text = "INICIO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FMenuP_FormClosed);
            this.Load += new System.EventHandler(this.FMenuP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprinc;
        private System.Windows.Forms.Button btnavan;
        private System.Windows.Forms.Button btnint;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panellevel;
    }
}