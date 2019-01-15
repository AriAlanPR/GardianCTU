using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gardian
{
    public partial class Factividades : Form
    {
        //declaracion de variable que guardara formulario origen
        FrmInicio parent;
        //declaracion de variable que guarda el nivel del niño
        int actividad;
        public Factividades(FrmInicio _parent)
        {
            //se guarda el formulario origen en la variable
            parent = _parent;
            InitializeComponent();
        }
        //metodo que regresa al formulario de origen
        public void regresar()
        {
            parent.Show();
            this.Hide();
        }

        public void ActividadElegida(int numactividad)
        { 
        //se guarda la actividad en una variable entera basado en:
        //kinestesico = 1, visual = 2 , auditiva = 3
            actividad = numactividad;
            FMenuP niveldificultad = new FMenuP(this, actividad);
            niveldificultad.Show();
        }

        private void Factividades_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }




        private void btnregresar_Click(object sender, EventArgs e)
        {
            regresar();
        }
        FrmExamenVista exavista1;
        //al presionar el boton se iniciara la seleccion de dificultad y se mandara un 
        //valor entero que indicara la actividad elegida basado en:
        // 1= kinestesico, 2 = visual, 3 = auditivo
        private void btnseleccion_Click(object sender, EventArgs e)
        {
            if (rbtnkinestesico.Checked)
                ActividadElegida(1);
            if (rbtnvisual.Checked)
                ActividadElegida(2);
            if (rbtnauditivo.Checked)
                ActividadElegida(3);
            if (rbtnexvista.Checked)
            {
                if (exavista1 == null)
                    exavista1 = new FrmExamenVista(this);

                exavista1.Show();
                this.Hide();
            }
            this.Hide();
        }

        private void Factividades_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            rbtnauditivo.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            rbtnvisual.Checked = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rbtnkinestesico.Checked = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            rbtnexvista.Checked = true;
        }
    }
}
