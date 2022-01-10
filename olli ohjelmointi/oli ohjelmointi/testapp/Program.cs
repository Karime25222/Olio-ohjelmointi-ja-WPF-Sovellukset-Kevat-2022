using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testapp
{
    class Program 
    {
        static void Main(string[] args)
        {
            koira koira1 = new koira(); // Ensimäinen koira olio
            koira1.nimi = "Rekku";
            koira1.ikä = 4;
            koira1.rotu = "saksnapimenkoira";

            koira1.Hauku();
            koira1.tulostadata();

            koira koira2 = new koira();
            koira2.nimi = "asd";
            koira2.ikä = 2;
            koira2.rotu = "mopsi";

            koira2.tulostadata();

            koira koira3 = new koira("urho", 5, "Mopsi");
            
        }
    }
}
