using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sikidom> sikidioms = new List<Sikidom>(); //Az ősosztályuk megegyezik, mivel a Kor-nek és a Negyzetnek a Sikidom az ősosztálya

            sikidioms.Add(new Kor(2.4));
            sikidioms.Add(new Kor(4.2));
            sikidioms.Add(new Negyzet(2.4));
            sikidioms.Add(new Negyzet(5.3));
            sikidioms.Add(new Kor(3.9));

            foreach (Sikidom item in sikidioms)
            {
                string tipus = String.Empty;

                if (item.GetType() == typeof(Kor)) //a GetType visszaadja a típusát
                {
                    tipus = "Kör";
                }
                else if (item.GetType() == typeof(Negyzet))
                {
                    tipus = "Négyzet";
                }
                Console.WriteLine($"{tipus}:\n\tkerület: {item.Kerulet():N2}\n\tterület: {item.Terulet():N2}\n");
            }

            Console.WriteLine("A program vége");
            Console.ReadKey();
        }
    }
}
