using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            Albumi albumi = new Albumi("2pack","rap", 31);

            albumi.LisääKappale(new Kappale("Kappale 1", "06:25"));
            albumi.LisääKappale(new Kappale("Kappale 2", "02:55"));
            albumi.LisääKappale(new Kappale("Kappale 3", "05:12"));
            albumi.tulostaalbumi();

            albumi.TulostaKappaleet();
            Console.ReadLine();

        }
    }
}
