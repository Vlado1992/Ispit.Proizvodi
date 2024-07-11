using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ispit.Proizvodi
{
    public class Predavac
    {
        public event PocniPisatiIspit Ispit;

        public void ZvoniZvono()
        {
            Console.WriteLine("Zvono je zazvonilo i ispit započinje!");
            EmitirajZvukZvona();
            Thread.Sleep(1000);
            Ispit?.Invoke(DateTime.Now);
        }

        public void EmitirajZvukZvona()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Beep(1000, 500);
                Thread.Sleep(200);
            }
        }

        public void IspitZaprimljen(Polaznik polaznik)
        {
            Console.WriteLine($"Predavač je zaprimio odgovore od {polaznik.ImePrezime}");
        }
    }
}
