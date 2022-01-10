using System;
using System.Collections.Generic
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas harvia = new Kiuas("Harvia", 90, 50);

            harvia.NäytäTiedot();
            harvia.Tila = true;
            harvia.NäytäTiedot();
            harvia.SäädäLämpötila(100);
            harvia.NäytäTiedot();
        }
    }
}
