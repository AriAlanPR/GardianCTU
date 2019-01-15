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
    public partial class FrmExamenVista : Form
    {
        //variable para regresar al formulario de origen
        Factividades parent;
        //variable que guarda las teclas a presionar
        List<char> teclachar = new List<char>();
        List<char> teclacharm = new List<char>();
        //variable que guarda la lista de imagenes a desplegar
        List<System.Drawing.Bitmap> ListaLetras = new List<Bitmap>();
        int puntero = 0, aciertos =0, errores=0;//puntero para recorrer la lista
        public FrmExamenVista(Factividades _parent)
        {
            parent = _parent;
            InitializeComponent();
        }
        //metodo que regresa al formulario de origen
        public void regresar()
        {
            parent.Show();
            this.Hide();
        }
        private void FrmExamenVista_Load(object sender, EventArgs e)
        {
            MiMessagebox.MensInfo("Este juego consiste en presionar la tecla del teclado que tenga la imagen mostrada en pantalla.\nPara empezar:\n1.Posicione al niño a 1.5 m(60 pulgadas) de la pantalla.\n2.Debe usar un teclado inalámbrico o uno alámbrico que pueda llegar a la distancia a la que se debe posicionar al niño.\n-Una vez listos los puntos anteriores presione el botón enter para comenzar.");
            ListaLetras.Add(Properties.Resources.tv1_1);
            ListaLetras.Add(Properties.Resources.tv1_2);
            ListaLetras.Add(Properties.Resources.tv2_1);
            ListaLetras.Add(Properties.Resources.tv2_2);
            ListaLetras.Add(Properties.Resources.tv2_3);
            ListaLetras.Add(Properties.Resources.tv3_1);
            ListaLetras.Add(Properties.Resources.tv3_2);
            ListaLetras.Add(Properties.Resources.tv3_3);
            ListaLetras.Add(Properties.Resources.tv3_4);
            ListaLetras.Add(Properties.Resources.tv3_5);
            ListaLetras.Add(Properties.Resources.tv4_1);
            ListaLetras.Add(Properties.Resources.tv4_2);
            ListaLetras.Add(Properties.Resources.tv4_3);
            ListaLetras.Add(Properties.Resources.tv4_4);
            ListaLetras.Add(Properties.Resources.tv4_5);
            //
            teclachar.Add('w');
            teclachar.Add('e');
            teclachar.Add('r');
            teclachar.Add('q');
            teclachar.Add('w');
            teclachar.Add('q');
            teclachar.Add('e');
            teclachar.Add('r');
            teclachar.Add('w');
            teclachar.Add('e');
            teclachar.Add('w');
            teclachar.Add('r');
            teclachar.Add('e');
            teclachar.Add('q');
            teclachar.Add('r');
            //
            teclacharm.Add('W');
            teclacharm.Add('E');
            teclacharm.Add('R');
            teclacharm.Add('Q');
            teclacharm.Add('W');
            teclacharm.Add('Q');
            teclacharm.Add('E');
            teclacharm.Add('R');
            teclacharm.Add('W');
            teclacharm.Add('E');
            teclacharm.Add('W');
            teclacharm.Add('R');
            teclacharm.Add('E');
            teclacharm.Add('Q');
            teclachar.Add('R');
            //
            pbfigura.Image = ListaLetras[puntero];
            puntero++;
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            regresar();
        }

        private void pbfigura_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmExamenVista_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecleado = e.KeyChar;
            if (puntero < 10)
            {
                if (tecleado == teclachar[puntero])
                    aciertos++;
                else
                    errores++;
                puntero++;
                pbfigura.Image = ListaLetras[puntero];
            }
            else
            {
                if (puntero >= 14)
                {
                    MiMessagebox.MensInfo("Evaluación terminada");
                    string res;
                    if (aciertos >= 11)
                        res = "El niño tiene excelente vista";
                    else
                        if (aciertos >= 8)
                            res = "El niño tiene buena vista";
                        else
                            if (aciertos >= 6)
                                res = "El niño tiene una vista aceptable";
                            else
                                if (aciertos >= 4)
                                    res = "El niño puede tener un problema de vista";
                                else
                                    res = "Cuidado, es probable que el niño tenga mala vista";

                    MsgPersonalizado mp = new MsgPersonalizado("Resultados", res);
                    mp.Show();
                }
                else
                {
                    if (tecleado == teclachar[puntero])
                        aciertos++;
                    else
                        errores++;
                    puntero++;
                    
                    pbfigura.Image = ListaLetras[puntero];
                    
                }
            }
        }

        private void FrmExamenVista_Shown(object sender, EventArgs e)
        {
            aciertos = 0;
            errores = 0;
        }
    }
}
