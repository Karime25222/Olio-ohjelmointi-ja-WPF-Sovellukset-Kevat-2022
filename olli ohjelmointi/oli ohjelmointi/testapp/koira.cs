using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testapp
{
    class koira
    {
        public string nimi;
        public int ikä;
        public string rotu;

        public koira(string _nimi, int _ikä, string _rotu)
        {
            nimi = _nimi;
            ikä = _ikä;
            rotu = _rotu;

            Hauku();
        }



        public void tulostadata()
        {
            Console.WriteLine("Koiran nimi:" + nimi + ". ikä: " + ikä + ". Rotu: " + rotu);
            

                
        }
        public void Hauku()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
