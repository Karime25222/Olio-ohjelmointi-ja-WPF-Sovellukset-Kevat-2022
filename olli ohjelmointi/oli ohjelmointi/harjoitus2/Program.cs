using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija1 = new Opiskelija("Pekka", "12345", 0);
            opiskelija1.TulostaData();
            opiskelija1.MuokkaaOpintopisteitä(10);
            opiskelija1.MuokkaaOpintopisteitä(15);
            opiskelija1.TulostaData();
        }
    }
}
