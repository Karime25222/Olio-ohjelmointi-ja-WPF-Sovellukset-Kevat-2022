using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_3
{
    class kiuas
    {
        private string Nimi;
        private int Lämpötila;
        private int Kosteus;
        public bool Tila = false;

        public Kiuas(string _nimi, int _lämpötila, int _kosteus)
        {
            Nimi = _nimi;
            Lämpötila = _lämpötila;
            Kosteus = _kosteus;
        }

        public void NäytäTiedot()
        {
            if (Tila) // <-- if (Tila == true)
            {
                Console.WriteLine("Kiuas " + Nimi + " on päällä");
                Console.WriteLine("Lämpötila = " + Lämpötila);
                Console.WriteLine("Kosteus = " + Kosteus);
            }
            else
            {
                Console.WriteLine("Kiuas " + Nimi + " ei ole päällä");
            }
        }

        public void SäädäLämpötila(int uusiLämpötila)
        {
            Lämpötila = uusiLämpötila;
        }
    }
}

        



    }
      