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
    public partial class FMenuP : Form
    {
        //se declara el formulario origen en un nuevo objeto.
        Factividades parent;
        public FMenuP(Factividades _parent, int noactividad)
        {
            //se guarda el formulario pable en la variable declarada;
            parent = _parent;
            actividad = noactividad;
            InitializeComponent();
        }
       //variable entera que indica el nivel de dificultad de la aplicación
        //el nivel se define en: principiante = 1 , intermedio = 2, avanzado = 3
        int actividad;
        //declaracion de formulario de actividades
        Factividades FormAct;
        //metodo que regresa al formulario de origen
        public void regresar()
        {
            parent.Show();
            this.Hide();
        }

        private void FMenuP_Load(object sender, EventArgs e)
        {
            
        }
        //formularios de las actividades a realizar
        Princ1 princapr;
        Princ2 princvis; 
        Princ3 princaud; 
        Int1 intapr; 
        Int2 intvis; 
        Int3 intaud; 
        Avan1 avanapr; 
        Avan2 avanvis;
        Avan3 avanaud;
        //
        private void btnprinc_Click(object sender, EventArgs e)
        {
            //Método que inicializa el formulario de actividades y avisa el nivel del niño a evaluar
            switch (actividad)
            {
                case 1:
                    princapr = new Princ1(this);
                    princapr.Show();
                    
                    break;
                case 2:
                    princvis = new Princ2(this);
                    princvis.Show();
                    
                    break;
                case 3:
                    princaud = new Princ3(this);
                    princaud.Show();
                 
                    break;
            }
            this.Hide();
        }

        

        private void btnint_Click(object sender, EventArgs e)
        {
            //Método que inicializa el formulario de actividades y avisa el nivel del niño a evaluar
            switch (actividad)
            {
                case 1:
                    intapr = new Int1(this);
                    intapr.Show();
                    break;
                case 2:
                    intvis = new Int2(this);
                    intvis.Show();
                    break;
                case 3:
                    intaud = new Int3(this);
                    intaud.Show();
                    break;
            }
            this.Hide();
        }

        private void btnavan_Click(object sender, EventArgs e)
        {
            //Método que inicializa el formulario de actividades y avisa el nivel del niño a evaluar
            switch (actividad)
            {
                case 1:
                    avanapr = new Avan1(this);
                    avanapr.Show();
                    break;
                case 2:
                    avanvis = new Avan2(this);
                    avanvis.Show();
                    break;
                case 3:
                    avanaud = new Avan3(this);
                    avanaud.Show();
                    break;
            }
            this.Hide();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            regresar();
        }

        private void FMenuP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
