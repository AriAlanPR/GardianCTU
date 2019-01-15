using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gardian
{
    class DibujoRandom
    {
        int dibujos = 10, selec;
        Random randomizer = new Random();

        List<System.Drawing.Bitmap> animales = new List<System.Drawing.Bitmap>();//0-7
        public List<System.IO.UnmanagedMemoryStream> animalessonido = new List<System.IO.UnmanagedMemoryStream>();

        List<System.Drawing.Bitmap> fruta = new List<System.Drawing.Bitmap>();//0-5
        public List<System.IO.UnmanagedMemoryStream> frutasonido = new List<System.IO.UnmanagedMemoryStream>();

        List<System.Drawing.Bitmap> alimento = new List<System.Drawing.Bitmap>();//0-7
        public List<System.IO.UnmanagedMemoryStream> alimentosonido = new List<System.IO.UnmanagedMemoryStream>();

        string ubicaaplicacion;
        //constructor
        public DibujoRandom(string ubicacion)
        {
          
            ubicaaplicacion = ubicacion;
            //animales.Add("\\imggardian\\cerdo.JPG");
            //animales.Add("\\imggardian\\perro.JPG");
            //animales.Add("\\imggardian\\gato.JPG");
            //animales.Add("\\imggardian\\elefante.JPG");
            //animales.Add("\\imggardian\\pez.JPG");
            //animales.Add("\\imggardian\\pinguino.JPG");
            //animales.Add("\\imggardian\\pollito.JPG");
            //animales.Add("\\imggardian\\vaca.JPG");
            //
            animales.Add(Properties.Resources.bear_1);
            animales.Add(Properties.Resources.cat_2);
            animales.Add(Properties.Resources.chicken_1);
            animales.Add(Properties.Resources.cow_1);
            animales.Add(Properties.Resources.dog_1);
            animales.Add(Properties.Resources.duck_1);
            animales.Add(Properties.Resources.eagle_1);
            animales.Add(Properties.Resources.horse_1);
            animales.Add(Properties.Resources.lion_1);
            animales.Add(Properties.Resources.parrot_1);
            animales.Add(Properties.Resources.pig_1);
            //--
            animalessonido.Add(Properties.Resources.bear);
            animalessonido.Add(Properties.Resources.cat);
            animalessonido.Add(Properties.Resources.chicken);
            animalessonido.Add(Properties.Resources.cow);
            animalessonido.Add(Properties.Resources.dog);
            animalessonido.Add(Properties.Resources.duck);
            animalessonido.Add(Properties.Resources.eagle);
            animalessonido.Add(Properties.Resources.horse);
            animalessonido.Add(Properties.Resources.lion);
            animalessonido.Add(Properties.Resources.parrot);
            animalessonido.Add(Properties.Resources.pig);
            //
            fruta.Add(Properties.Resources.manzana);
            fruta.Add(Properties.Resources.naranja);
            fruta.Add(Properties.Resources.pera);
            fruta.Add(Properties.Resources.piña);
            fruta.Add(Properties.Resources.sandía);
            fruta.Add(Properties.Resources.uva);     
            //--
            frutasonido.Add(Properties.Resources.manzana1);
            frutasonido.Add(Properties.Resources.naranja1); 
            frutasonido.Add(Properties.Resources.pera1);
            frutasonido.Add(Properties.Resources.piña1);
            frutasonido.Add(Properties.Resources.sandia1);
            frutasonido.Add(Properties.Resources.uva1);
            //
            alimento.Add(Properties.Resources.dona);
            alimento.Add(Properties.Resources.hamburguesa);
            alimento.Add(Properties.Resources.helado);
            alimento.Add(Properties.Resources.hot_dog);
            alimento.Add(Properties.Resources.huevo);
            alimento.Add(Properties.Resources.pizza);
            alimento.Add(Properties.Resources.pollo);
            alimento.Add(Properties.Resources.quequito);
           //--
            alimentosonido.Add(Properties.Resources.dona1);
            alimentosonido.Add(Properties.Resources.hamburguesa1);
            alimentosonido.Add(Properties.Resources.helado1);
            alimentosonido.Add(Properties.Resources.hot_dog1);
            alimentosonido.Add(Properties.Resources.huevo1);
            alimentosonido.Add(Properties.Resources.pizza1);
            alimentosonido.Add(Properties.Resources.pollo1);
            alimentosonido.Add(Properties.Resources.quequito1);
           //
            
        }
        public List<int> animalusado = new List<int>();
        //Devuelve la ruta de un animal random
        public System.Drawing.Bitmap SeleccionarAnimal()
        {
            do
            {
                //11 imagenes de animales
                selec = randomizer.Next(0, dibujos);
            } while (animalusado.Contains(selec));
            animalusado.Add(selec);
            return animales[selec];       
        }
        public List<int> frutausada = new List<int>();
        //Devuelve una imagen con fruta
        public System.Drawing.Bitmap SeleccionarFruta()
        {
            do
            {
                selec = randomizer.Next(0, 5);
            } while (frutausada.Contains(selec) == true);
            frutausada.Add(selec);
            return fruta[selec];
        }
        public List<int> alimentousado = new List<int>();
        //Devuelve una imagen con un alimento random
        public System.Drawing.Bitmap SeleccionarAlimento()
        {
            do
            {
                selec = randomizer.Next(0, 7);
            } while (alimentousado.Contains(selec));
            alimentousado.Add(selec);
            return alimento[selec];
        }

        public bool Lleno(int cual)
        {
            switch (cual)
            {
                case 1: //nivel 1 frutas
                    if (frutausada.Count == 4)
                        return true;
                    else
                        return false;
                    break;

                case 2: //nivel 2 alimentos
                    if (alimentousado.Count == 6)
                        return true;
                    else
                        return false;
                    break;

                default: //nivel 3 animales
                    if (animalusado.Count == 9)
                        return true;
                    else
                        return
                            false;
                    break;
            }
        }
    }
}
