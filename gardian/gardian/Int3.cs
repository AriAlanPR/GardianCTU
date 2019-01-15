using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gardian
{
    public partial class Int3 : Form
    {
        //variable que guarda el formulario de origen
        FMenuP parent;
        //variables para contabilizar aciertos/errores y barajear imagenes y sonidos
        int aciertos = 0, errores = 0, imagenaelegir, aseleccionar;
        public Int3(FMenuP _parent)
        {
            parent = _parent;
            InitializeComponent();
        }
        //variable para agarrar indices aleatorios
        Random randomini = new Random();
        private void Int3_Load(object sender, EventArgs e)
        {
            //seleccion de imagenes
            dib = new DibujoRandom(Application.StartupPath);
            pb1.Image = dib.SeleccionarAlimento();
            pb2.Image = dib.SeleccionarAlimento();
            pb3.Image = dib.SeleccionarAlimento();
            pb4.Image = dib.SeleccionarAlimento();
            pb5.Image = dib.SeleccionarAlimento();
            pb6.Image = dib.SeleccionarAlimento();
        }
        //variable para añadir imagenes aleatorias
        DibujoRandom dib;
        //sonidos ac/err
        Sonidinis sndacerr = new Sonidinis();
        //metodo que regresa al formulario de origen
        public void regresar()
        {
            parent.Show();
            this.Hide();
        }
        //resetea las imagenes y agarra unas nuevas y reinicia el soundplayer
        public void Reiniciar()
        {
            if (aciertos < 15)
            {
                atinado = false;
                if (soundelegir != null)
                    soundelegir.Stop();
                dib.alimentousado.Clear();
                pb1.Image = dib.SeleccionarAlimento();
                pb2.Image = dib.SeleccionarAlimento();
                pb3.Image = dib.SeleccionarAlimento();
                pb4.Image = dib.SeleccionarAlimento();
                pb5.Image = dib.SeleccionarAlimento();
                pb6.Image = dib.SeleccionarAlimento();
                soundelegir.Stream.Position = 0;
                timerbarajear.Start();
            }
            else
            {
                MessageBox.Show("Juego terminado n.n");
                //despliegue de resultados
                //luego de detener todo se inicializa la puntualización para alumnos
                Resultados res = new Resultados(aciertos, errores, aciertos + errores, "Intermedio", "Auditivo");
                res.Show();
                this.Hide();
            }
        }
        private void Int3_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        }
        //agregar
        SoundPlayer introSound;
        //
        private void btnregresar_Click(object sender, EventArgs e)
        {

            //agregar
            tmrintro.Stop();
            introSound.Stop();
            //
            regresar();
        }
        //
        SoundPlayer soundelegir;
        //
        //**
        bool iniciado = false;
        //
        private void btnempezar_Click(object sender, EventArgs e)
        {
            panelintro.Visible = false;
            imgintro.Visible = false; 
            try
            {
                iniciado = true;
                //agregar
                if (soundelegir != null)
                    soundelegir.Stop();
                imagenaelegir = randomini.Next(0, 6);
                //modificar
                aseleccionar = dib.alimentousado[imagenaelegir];
                //
                //modificar
                soundelegir = new SoundPlayer(dib.alimentosonido[aseleccionar]);
                //
                //aah, izi, daisuki linea de codigo <3
                soundelegir.Stream.Position = 0;
                soundelegir.Play();
                btnempezar.Enabled = false;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                if (soundelegir != null)
                    soundelegir.Stop();
            }
            //
        }

        private void Int3_Shown(object sender, EventArgs e)
        {
            //agregar
            introSound = new SoundPlayer(Properties.Resources.Intro);
            //introSound.Play();
            tmrintro.Start();
            //
        }

        private void tmrintro_Tick(object sender, EventArgs e)
        {
            //agregar
            panelintro.Visible = false;
            imgintro.Visible = false;
            tmrintro.Stop();
            //
        }
        //agregar
        bool atinado = false;
        public void Jugar(int sender)
        {
            if (iniciado)
            {
                if (aciertos < 15)
                {
                    if (imagenaelegir == sender && atinado == false)
                    {
                        aciertos++;
                        atinado = true;
                        //MessageBox.Show(aciertos.ToString());
                        Reiniciar();
                    }
                    else
                    {
                        if (atinado == false)
                        {
                            errores++;
                            sndacerr.Error();
                            //MessageBox.Show(errores.ToString());
                        }
                    }
                }
                else
                {
                    //despliegue de resultados
                }
            }
        }
        //
        //agregar
        public void BarajearSonido()
        {
            try
            {
                //agregar
                if (soundelegir != null)
                    soundelegir.Stop();
                imagenaelegir = randomini.Next(0, 6);
                //modificar
                aseleccionar = dib.alimentousado[imagenaelegir];
                //
                //modificar                
                soundelegir = new SoundPlayer(dib.alimentosonido[aseleccionar]);
                //
                //aah, izi, daisuki linea de codigo <3
                soundelegir.Stream.Position = 0;
                soundelegir.Play();
                timerbarajear.Stop();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                if (soundelegir != null)
                    soundelegir.Stop();
            }
        }

        private void timerbarajear_Tick(object sender, EventArgs e)
        {
            //agregar
            BarajearSonido();

            //
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            Jugar(0);
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            Jugar(1);
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            Jugar(2);
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            Jugar(3);
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            Jugar(4);
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            Jugar(5);
        }
        //

    }
}
