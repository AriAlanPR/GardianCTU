namespace gardian
{
    partial class FrmExamenVista
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
            this.btnregresar = new System.Windows.Forms.Button();
            this.pbfigura = new System.Windows.Forms.PictureBox();
            this.pbmarco = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbfigura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmarco)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.Location = new System.Drawing.Point(12, 486);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(60, 33);
            this.btnregresar.TabIndex = 1;
            this.btnregresar.Text = "<< ";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // pbfigura
            // 
            this.pbfigura.BackColor = System.Drawing.Color.White;
            this.pbfigura.Location = new System.Drawing.Point(254, 64);
            this.pbfigura.Name = "pbfigura";
            this.pbfigura.Size = new System.Drawing.Size(531, 374);
            this.pbfigura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbfigura.TabIndex = 4;
            this.pbfigura.TabStop = false;
            this.pbfigura.Click += new System.EventHandler(this.pbfigura_Click);
            // 
            // pbmarco
            // 
            this.pbmarco.BackColor = System.Drawing.Color.White;
            this.pbmarco.Image = global::gardian.Properties.Resources.marco_wam;
            this.pbmarco.Location = new System.Drawing.Point(129, 23);
            this.pbmarco.Name = "pbmarco";
            this.pbmarco.Size = new System.Drawing.Size(810, 463);
            this.pbmarco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmarco.TabIndex = 3;
            this.pbmarco.TabStop = false;
            // 
            // FrmExamenVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1036, 531);
            this.Controls.Add(this.pbfigura);
            this.Controls.Add(this.pbmarco);
            this.Controls.Add(this.btnregresar);
            this.KeyPreview = true;
            this.Name = "FrmExamenVista";
            this.Text = "Examen  de la vista";
            this.Load += new System.EventHandler(this.FrmExamenVista_Load);
            this.Shown += new System.EventHandler(this.FrmExamenVista_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmExamenVista_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbfigura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmarco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.PictureBox pbfigura;
        private System.Windows.Forms.PictureBox pbmarco;
    }
}