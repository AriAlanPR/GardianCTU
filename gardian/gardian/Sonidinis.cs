using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace gardian
{
    public class Sonidinis
    {
        SoundPlayer sonido = new SoundPlayer();
        
        public void Acierto()
        {
            sonido.Stop();
            sonido.Stream = Properties.Resources.bien;
            sonido.Stream.Position = 0;
            sonido.Play();
        }

        public void Error()
        {
            sonido.Stop();
            sonido.Stream = Properties.Resources.error;
            sonido.Stream.Position = 0;
            sonido.Play();
            
        }
        
    }
}
