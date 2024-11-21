using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Grupp_7_OOSU1
{
    public class Stationer
    {
        public string Plats;
        public string Storlek;
     
        public int AntalFordon;
        public string Fordonsläge;
        public int AnvändbaraFordon;

        public List<Fordon> Fordon;
        public Användare Användare;
        //En funktion som ser skillnaden mellan AntalFordon och AnvändbaraFordon för att se vilka fordon
        //som är otillgängliga
    }
}
