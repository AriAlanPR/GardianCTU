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
    public partial class Princ2 : Form
    {
        //variable que guarda el formulario de origen
        FMenuP parent;
        public Princ2(FMenuP _parent)
        {
            parent = _parent;
            InitializeComponent();
        }
        //variable que contiene la ruta donde se encuentra corriendo la app
        string startup = Application.StartupPath;

        //metodo para seleccionar las imagenes a usar en el memorama
        public PictureBox DefinirImg()
        {
            DibujoRandom dib = new DibujoRandom(startup);
            PictureBox pict = new PictureBox();
            //pict.ImageLocation = dib.SeleccionarAnimal();
            return pict;
        }
        //para memorama
        Memorama memo = new Memorama();
        private void Princ2_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            //inicializar contenido para el memorama
            for (int i = 0; i < 3; i++)
            {
                memo.CartasEnumeradas.Add(i.ToString());
                memo.CartasEnumeradas.Add(i.ToString());
            }
            var numeroaleatorio = new Random();
            var resultado = memo.CartasEnumeradas.OrderBy(item => numeroaleatorio.Next());
            foreach (string  valorcarta in resultado)
            {
                memo.CartasRevueltas.Add(valorcarta);
            }
            var tablapanel = new TableLayoutPanel();
            tablapanel.RowCount = memo.Filas;
            tablapanel.ColumnCount = memo.Columnas;
            for (int x = 0; x < memo.Columnas; x++)
            {
                var porcentaje = 150f / (float)memo.Columnas - 10;
                tablapanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, porcentaje));
            }
            for (int y = 0; y < memo.Filas; y++)
            {
                var porcentaje = 150f / (float)memo.Filas - 10;
                tablapanel.RowStyles.Add(new RowStyle(SizeType.Percent, porcentaje));
            }
            int contadorfichas = 1;
            for (int z = 0; z  < memo.Filas; z ++)
			{
                for (int a = 0; a < memo.Columnas; a++)
                {
                    var cartasjuego = new PictureBox();
                    cartasjuego.Name = string.Format("{0}", contadorfichas);
                    cartasjuego.Dock = DockStyle.Fill;
                    cartasjuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    cartasjuego.Image = Properties.Resources.Girada;
                    cartasjuego.Cursor = Cursors.Hand;
                    //
                    cartasjuego.Click += btnCarta_Click;
                    //
                    tablapanel.Controls.Add(cartasjuego, a, z);
                    contadorfichas++;
                    
                }
			}
            tablapanel.Dock = DockStyle.Fill;
            paneljuego.Controls.Add(tablapanel);
            //finaliza codigo para iniciar contenido del memorama

        }
        //metodo que regresa al formulario de origen
        public void regresar()
        {
            parent.Show();
            this.Hide();
            
        }
        private void Princ2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            regresar();
        }

        private void btnreinicio_Click(object sender, EventArgs e)
        {

        }
        //
        //
        bool iniciar = false;
        List<PictureBox> listapreinicio = new List<PictureBox>();
        //
        //        
        //evento generado
        private void btnCarta_Click(object sender, EventArgs e)
        {
            if (iniciar)
            {//
                if (memo.CartasSeleccionadas.Count < 2)
                {
                    memo.movimientos++;
                    lblrecord.Text = Convert.ToString(memo.movimientos);
                    var cartasseleccionadasuser = (PictureBox)sender;
                    memo.cartaactual = Convert.ToInt32(memo.CartasRevueltas[Convert.ToInt32(cartasseleccionadasuser.Name) - 1]);
                    cartasseleccionadasuser.Image = RecuperarImagen(memo.cartaactual);
                    memo.CartasSeleccionadas.Add(cartasseleccionadasuser);
                    //2 veces se contabilizo el evento
                    if (memo.CartasSeleccionadas.Count == 2)
                    {
                        memo.cartatemporal1 = (PictureBox)memo.CartasSeleccionadas[0];
                        memo.cartatemporal2 = (PictureBox)memo.CartasSeleccionadas[1];
                        int carta1 = Convert.ToInt32(memo.CartasRevueltas[Convert.ToInt32(memo.cartatemporal1.Name) - 1]);
                        int carta2 = Convert.ToInt32(memo.CartasRevueltas[Convert.ToInt32(memo.cartatemporal2.Name) - 1]);
                        if (carta1 != carta2)
                        {
                            //
                            memo.errores++;
                            //
                            timer1.Enabled = true;
                            timer1.Start();
                        }
                        else
                        {
                            memo.cartasvolteadas++;
                            if (memo.cartasvolteadas > 2)
                            {
                                MessageBox.Show("Juego terminado :3");
                                //
                                //luego de detener todo se inicializa la puntualización para alumnos
                                Resultados res = new Resultados(memo.cartasvolteadas, memo.errores, memo.cartasvolteadas + memo.errores, "Principiante", "Visual");
                                //se muestra el formulario con resultados
                                res.Show();
                                this.Hide();
                                //
                            }
                            memo.cartatemporal1.Enabled = false;
                            memo.cartatemporal2.Enabled = false;
                            memo.CartasSeleccionadas.Clear();
                        }
                    }
                }
                //
            }
            else //si aun no se ha dado click en iniciar
            {
                var cartasseleccionadasuser = (PictureBox)sender;                 
                cartasseleccionadasuser.Image = RecuperarImagen(Convert.ToInt32(memo.CartasRevueltas[Convert.ToInt32(cartasseleccionadasuser.Name) - 1]));
                listapreinicio.Add(cartasseleccionadasuser);
            }
        }
        //fin del evento
        //metodo para recuperar una imagen
        public Bitmap RecuperarImagen(int numeroimagen)
        {
        Bitmap tmpimg = new Bitmap(200, 100);
        switch (numeroimagen)
        {
            case 0 :                
                tmpimg = Properties.Resources.img0;
                break;
            default :
                tmpimg = (Bitmap)Properties.Resources.ResourceManager.GetObject("img" + numeroimagen);
                break;
        }
        return tmpimg;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int tiempovercarta = 1;
            if (tiempovercarta == 1)
            {
                memo.cartatemporal1.Image = Properties.Resources.Girada;
                memo.cartatemporal2.Image = Properties.Resources.Girada;
                memo.CartasSeleccionadas.Clear();
                tiempovercarta = 0;
                timer1.Stop();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            iniciar = true;
            if (listapreinicio.Count > 0)
            {
                foreach (PictureBox item in listapreinicio)
                {
                    item.Image = Properties.Resources.Girada;
                }
            }
        }
        //bool mostrar= false;
        //private void MostrarInicio()
        //{
        //    if (mostrar == false)
        //    {
        //        foreach (PictureBox item in paneljuego.Controls)
        //        {
        //            Convert.ToInt32(memo.CartasRevueltas[Convert.ToInt32(item.Name) - 1]);
        //        }
        //    }
        //    else
        //    {
        //        foreach (PictureBox item in paneljuego.Controls)
        //        {
        //            Convert.ToInt32(memo.CartasRevueltas[Convert.ToInt32(item.Name) - 1]);
        //        }
        //    }
        //}

        
    }
}
