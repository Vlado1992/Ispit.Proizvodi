using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ispit.Proizvodi
{
    public delegate void PocniPisatiIspit(DateTime vrijemePocetka);
    internal class Program
    {
        static void Main(string[] args)
        {
            Predavac predavac = new Predavac();
            List<Polaznik> polaznici = new List<Polaznik>()
            {
                new Polaznik { ImePrezime = "Mirela Ljiljanić" },
                new Polaznik { ImePrezime = "Stjepan Vladimirović" },
                new Polaznik { ImePrezime = "Ljiljana Ivanić" },
                new Polaznik { ImePrezime = "Davor Mirtić" }
            };

            predavac.Ispit += (DateTime vrijemePocetka) =>
            {
                foreach (var polaznik in polaznici)
                {
                    polaznik.OdgovoriNaPitanja(vrijemePocetka);
                }
                Thread.Sleep(5000);
            };

            foreach (var polaznik in polaznici)
            {
                polaznik.IspitZavrsen += predavac.IspitZaprimljen;
            }

            predavac.ZvoniZvono();

            polaznici[1].PredajOdgovoreNaPitanja();

            Console.ReadKey();
        }
    }
}
