using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Amp
    {
        private readonly int maxVolume = 100;
        private readonly int minVolume = 0;

        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= maxVolume)
                {
                    Console.WriteLine("Volume liian kovalla - säädetään maksimiin");
                    volume = maxVolume;
                }
                else if(value <= minVolume)
                {
                    Console.WriteLine("Volume on liian pienellä - säädetään pienimmälle");
                    volume = minVolume;
                }
                else
                {
                    volume = value;                   
                }
            }
        }
    }
}
