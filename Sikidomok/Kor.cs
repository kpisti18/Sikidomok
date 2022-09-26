using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok //A körnek és a négyzetnek is a Sikidom az ősosztálya
{
    class Kor : Sikidom //jelölni kell, hogy származtatom a Sikidom-ból, implementálni kell a Sikidom-ban lévő 2 metódust
    {
        double sugar;

        public double Sugar { get => sugar; set => sugar = value; }

        public Kor(double sugar)
        {
            Sugar = sugar;
        }

        public override double Kerulet() //az override utal az absztrakt osztály implementálására
        {
            return 2 * sugar * Math.PI;
        }

        public override double Terulet()
        {
            return sugar * sugar *Math.PI;
        }
    }
}
