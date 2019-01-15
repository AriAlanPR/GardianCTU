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
    public partial class Princ3 : Form
    {
        //variable que guarda el formulario de origen
        FMenuP parent;
        //agregar
        //variables para contabilizar aciertos/errores y barajear imagenes y sonidos
        int aciertos=0, errores=0, imagenaelegir, aseleccionar;
        //
        public Princ3(FMenuP _parent)
        {
            
            parent = _parent;
            InitializeComponent();
        }
        //agregar
        //variable para agarrar indices aleatorios
        Random randomini = new Random();
        //variable para reproducir sonido de aciertos y errores
        Sonidinis acerr = new Sonidinis();
        //
        private void Princ3_Load(object sender, EventArgs e)
        {
            dib = new DibujoRandom(Application.StartupPath);
            pb1.Image = dib.SeleccionarFruta();
            pb2.Image = dib.SeleccionarFruta();
            pb3.Image = dib.SeleccionarFruta();
            pb4.Image = dib.SeleccionarFruta();
        }
        DibujoRandom dib;
        //metodo que regresa al formulario de origen
        public void regresar()
        {
            parent.Show();
            this.Hide();
        }
        //agregar
        public void Reiniciar()
        {
            
            if (aciertos < 10)
            {
                atinado = false;
                if (soundelegir != null)
                    soundelegir.Stop();
                dib.frutausada.Clear();
                pb1.Image = dib.SeleccionarFruta();
                pb2.Image = dib.SeleccionarFruta();
                pb3.Image = dib.SeleccionarFruta();
                pb4.Image = dib.SeleccionarFruta();
                soundelegir.Stream.Position = 0;
                timerbarajear.Start();
            }
            else
            {
                MessageBox.Show("Juego terminado n.n");
                //despliegue de resultados
                //luego de detener todo se inicializa la puntualización para alumnos
                Resultados res = new Resultados(aciertos, errores, aciertos + errores, "Principiante", "Auditivo");
                res.Show();
                this.Hide();
            }
        }
        //
        private void Princ3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {   
            //agregar
            tmrintro.Stop();
            introSound.Stop();
            //
            regresar();
            
        }
        //agregar
        SoundPlayer introSound;
        //
        private void Princ3_Shown(object sender, EventArgs e)
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
        SoundPlayer soundelegir;
        //
        private void button1_Click(object sender, EventArgs e)
        {
            panelintro.Visible = false;
            imgintro.Visible = false;
            try
            {
                //agregar
                if (soundelegir != null)
                    soundelegir.Stop();
                imagenaelegir = randomini.Next(0, 4);
                aseleccionar = dib.frutausada[imagenaelegir];
                if (aseleccionar == 3)
                    soundelegir = new SoundPlayer(Properties.Resources.piña1);
                else
                    soundelegir = new SoundPlayer(dib.frutasonido[aseleccionar]);
                //aah, izi, daisuki linea de codigo <3
                soundelegir.Stream.Position = 0;
                soundelegir.Play();
                btnempezar.Enabled = false;
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
                if(soundelegir!= null)
                    soundelegir.Stop();
            }
            //
        }

        //agregar
        bool atinado = false;
        public void Jugar(int sender)
        {
            if (aciertos < 10)
            {
                if (imagenaelegir == sender && atinado== false)
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
                        acerr.Error();
                        
                        //MessageBox.Show(errores.ToString());
                    }
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
                imagenaelegir = randomini.Next(0, 4);
                aseleccionar = dib.frutausada[imagenaelegir];
                if (aseleccionar == 3)
                    soundelegir = new SoundPlayer(Properties.Resources.piña1);
                else
                    soundelegir = new SoundPlayer(dib.frutasonido[aseleccionar]);
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
        //

        private void pb1_Click(object sender, EventArgs e)
        {
            //agregar
            Jugar(0);
            //
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            //agregar
            Jugar(1);
            //
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            //agregar
            Jugar(2);
            //
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            //agregar
            Jugar(3);
            //
        }

        private void timerbarajear_Tick(object sender, EventArgs e)
        {
            //agregar
            BarajearSonido();
            
            //
        }        

        private void timeracerr_Tick_1(object sender, EventArgs e)
        {
            acerr.Acierto();
        }
    }
}
