using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gardian
{
    class Memorama
    {
        int tamcolumnas = 3, tamfilas = 2;
        public int movimientos = 0, cartasvolteadas = 0, cartaactual=0, errores=0;
        public List<string> CartasEnumeradas = new List<string>();
        public List<string> CartasRevueltas = new List<string>();
        public ArrayList CartasSeleccionadas = new ArrayList();
        public PictureBox cartatemporal1= new PictureBox();
        public PictureBox cartatemporal2= new PictureBox();
        //se inicializa tambien por defecto con tamaño de columnas y filas de 3 x 2 (columnas, filas)
        public Memorama()
        { 
        
        }

        public Memorama(int columnas, int filas)
        {
            //se puede indicar el tamaño de columnas y filas
            tamcolumnas = columnas;
            tamfilas = filas;
        }

        public int Columnas
        {
            get { return tamcolumnas; }
        }
        public int Filas
        {
            get { return tamfilas; }
        }     
    }
}
