using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus4
{
    class Albumi
    {
        private List<Kappale> kappaleet = new List<Kappale>();

        public string nimi;
        public string generi;
        public int hinta;

        public Albumi(string nimi, string generi, int hinta)
        {
            this.nimi = nimi;
            this.generi = generi;
            this.hinta = hinta;
        }

        public void LisääKappale(Kappale uusiKappale)

        {
            kappaleet.Add(uusiKappale);
        }
        public void TulostaKappaleet()
        {
            foreach (Kappale kappale in kappaleet)
            {
                Console.WriteLine(kappale.Nimi + ", " + kappale.Pituus);
            }


        }
        public void tulostaalbumi()
        {
            Console.WriteLine(nimi);
            Console.WriteLine(generi); 
            Console.WriteLine(hinta); 
        }
    }
}
