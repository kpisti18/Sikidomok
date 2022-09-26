using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    abstract class Sikidom //az absztrakció a lényeg kiemelése
    {
        abstract public double Kerulet(); //absztrakt osztálynál nincs törzsünk, csak üres metódusok vannak, mivel ezt majd máshonnan eredeztetjük
        abstract public double Terulet();
    }
}
