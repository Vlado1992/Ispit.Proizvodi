using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ispit.Proizvodi
{    
    public class Polaznik
    {        
        public delegate void PredajIspit(Polaznik polaznik);

        public string ImePrezime { get; set; }
           
        public event PredajIspit IspitZavrsen;

        public void OdgovoriNaPitanja(DateTime vrijeme_pocetka)
        {
            Console.WriteLine($"{ImePrezime} je počeo/la pisati ispit u {vrijeme_pocetka}");            
        }
        public void PredajOdgovoreNaPitanja()
        {
            Console.WriteLine($"{ImePrezime} je predao/la odgovore.");
            Thread.Sleep(3000);
            IspitZavrsen?.Invoke(this);
        }
    }
}
