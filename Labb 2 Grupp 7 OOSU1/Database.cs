using System;

namespace Labb_2_Grupp_7_OOSU1
{
    internal class InMemoryDatabase
    {
        internal List<Användare> användares = new List<Användare> ();
        internal List<Fordon> fordons = new List<Fordon> ();
        internal List<Stationer> station = new List <Stationer> ();

        internal void Seed()
        {
            #region 
            Användare användare1 = new Användare();
            användare1.AnvändarID = 1;
            användare1.Namn = "Oscar Norén";
            användare1.Email = "oscar.noren02@gmail.com";
            användare1.Betalningsmetod = "Swish";
            användare1.Hyreshistorik = "";


            #endregion  
        }
    }
}