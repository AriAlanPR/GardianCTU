using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gardian
{
    class Whack_A_Mole
    {
        public int numeromarmotaactual = 1, tiemponivel = 20, puntuacion = 0, fallas = 0, limite = 10;
        public Random rnd = new Random();
        //se puede inicializar vacía sin parámetros con un límite de total de 10
        public Whack_A_Mole()
        { 
        
        }

        //se puede establecer total en el limite de clicks para aciertos y errores 
        public Whack_A_Mole(int _limite)
        {
            limite = _limite;
        }
    }
}
