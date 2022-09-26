using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Negyzet : Sikidom
    {
        double oldal;

        public double Oldal { get => oldal; set => oldal = value; }

        public Negyzet(double oldal)
        {
            Oldal = oldal;
        }

        public override double Kerulet()
        {
            return 4 * oldal;
        }

        public override double Terulet()
        {
            return oldal * oldal;
        }
    }
}
