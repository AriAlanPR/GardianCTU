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
    public partial class Princ1 : Form
    {
        //variable que guarda el formulario de origen
        FMenuP parent;
        public Princ1(FMenuP _parent)
        {
            parent = _parent;
            InitializeComponent();
        }
        //variable que captura los datos para el juego
        Whack_A_Mole wam = new Whack_A_Mole();
        private void Princ1_Load(object sender, EventArgs e)
        {
             for (var i = 0; i < 2; i++)//indica filas
            {
                for (var j = 0; j < 3; j++)//indica columnas
                {
                    var fichajuego = new PictureBox();
                    fichajuego.BackColor = Color.Transparent;
                    fichajuego.Name = string.Format("{0}", i + "_" + j);
                    fichajuego.Dock = DockStyle.Fill;
                    fichajuego.Cursor = Cursors.Hand;
                    fichajuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    fichajuego.Click += Jugar;
                    fichajuego.Tag = "No";
                    paneljuego.Controls.Add(fichajuego, j, i);
                    
                }
            }
            timer1.Start();
            timer2.Start();
            //Intento(51,30, 51, 156);
        }

        //metodo que verifica lo clickeado por el usuario
        private void Jugar(object sender, EventArgs e)
        {
            var Fichaseleccionadausuario = (PictureBox)sender;
            if (Fichaseleccionadausuario.Tag.ToString() != "No")
            {
                if (Fichaseleccionadausuario.Tag.ToString() == "cat_" + wam.numeromarmotaactual)
                {
                    //sonido("bien");
                    //aumenta puntaje
                    wam.puntuacion++;
                    lblpuntos.Text = wam.puntuacion.ToString();
                    //aumentar el tiempo del nivel de usuario
                    //timer1.Interval = timer1.Interval - wam.tiemponivel;

                }
                else
                {
                    //sonido("falla");
                    wam.fallas++;
                    //label3.Text = wam.fallas.ToString();
                    //se muestran las fallas en pantalla
                    //lblfallas.text= fallas.tostring();

                }
            }
            else
            {
                wam.fallas++;
                //label3.Text = wam.fallas.ToString();
            //    //sonido("error");
            }
        }
        //metodo que regresa al formulario de origen
        public void regresar()
        {
            parent.Show();
            this.Hide();
        }
        private void Princ1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            regresar();
        }

        private void GraficarLinea(int x1, int y1, int x2, int y2)
        {
            Graphics g =  this.CreateGraphics();
            Pen lapiz = new Pen(Color.Purple, 3);            
            g.DrawLine(lapiz, new Point(y1, x1), new Point(y2,x2));
            
        }
       
        private void panelbotones_MouseDown(object sender, MouseEventArgs e)
        {
            
            
        }
        
        public void NoEs()
        {
            MessageBox.Show("No es este :c");
        }
        private void Princ1_Shown(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //usado para limpiar los paneles del table layout
        PictureBox limpia = new PictureBox();
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //limpia.Tag = "No";
            //limpia.BackColor = Color.Transparent;
            for (var i = 0; i < 2; i++) //filas
            {
                for (var j = 0; j < 3; j++) //columnas
                {

                    PictureBox pbocultar = this.Controls.Find(i + "_" + j, true).FirstOrDefault() as PictureBox;
                    pbocultar.BackColor = Color.Transparent;
                    pbocultar.Tag = "No";
                    pbocultar.Image = limpia.Image;
                }
            }
            //si se cambia el rango a 1-3 se tomaran 2 imagenes
            int rndtipo = wam.rnd.Next(1, 2);
            int rndi = wam.rnd.Next(0, 2);
            int rndj = wam.rnd.Next(0, 3);
            PictureBox pbx = this.Controls.Find(rndi+"_"+ rndj, true).FirstOrDefault() as PictureBox;
            pbx.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("cat_" + rndtipo);
            //sonido("salidaanimal");
            pbx.Tag = "cat_" + rndtipo;
            //
            if (wam.fallas + wam.puntuacion == wam.limite) //antes fallas = limitefallas
            {
                timer1.Stop();                
                //se limpia todo
                for (var i = 0; i < 2; i++) //filas
                {
                    for (var j = 0; j < 3; j++) //columnas
                    {

                        PictureBox pbocultar = this.Controls.Find(i + "_" + j, true).FirstOrDefault() as PictureBox;
                        pbocultar.BackColor = Color.Transparent;
                        pbocultar.Tag = "No";
                        pbocultar.Image = limpia.Image;
                        pbocultar.Enabled = false;
                    }                   
                }
                timer2.Stop();
                MessageBox.Show("Juego terminado");
                //luego de detener todo se inicializa la puntualización para alumnos
                Resultados res = new Resultados(wam.puntuacion, wam.fallas, wam.limite, "Principiante", "Kinestesico");
                //se muestra el formulario con resultados
                res.Show();
                this.Hide();
            }
            //
             
        
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int Numeroanimal = wam.rnd.Next(1, 2);
            wam.numeromarmotaactual = Numeroanimal;
            pbxatrapame.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("cat_" + Numeroanimal);
        }


        
    }
}
