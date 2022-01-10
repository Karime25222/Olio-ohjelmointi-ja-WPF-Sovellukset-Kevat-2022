using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus1
{
    class ajoneuvo
    {
        public string Nimi;
        public string Nopeus;
        public string Renkaat;

        public void TulostaData()
        {
            Console.WriteLine("Ajoneuvon nimi: " + Nimi);
            Console.WriteLine("Ajoneuvon nopeus: " + Nopeus);
            Console.WriteLine("Ajoneuvon renkaiden määrä: " + Renkaat);
        }

        public string ToString()
        {
            return "Ajoneuvo: " + Nimi + ". Nopeus: " + Nopeus + ". Renkaiden määrä: " + Renkaat;
        }
    }
}