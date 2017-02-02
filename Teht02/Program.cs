using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            Amp amp = new Amp();
            int luku;
            int lopetus;
            luku = 1;
            
            do
            {
                Console.Write("Säädä volumea välillä 0-100, lopeta kirjottamalla 'ok' > ");
                string line = Console.ReadLine();
                luku = int.Parse(line);                
                lopetus = int.Parse(line);
                amp.Volume = luku;

                Console.WriteLine("Volume on nyt " + amp.Volume);

            } while (lopetus != -1);
        }
    }
}
