﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Grupp_7_OOSU1
{
    public class Fordon
    {
        public int FordonsID;
        public string FordonsTyp;
        public string BatteriStatus;
        public bool FordonsStatus;

        public Användare Användare;
        public Stationer Stationer;
        
    }

    //public class Fordonsstatus
    //{
    //    public string Tillgänglig;
    //    public string Underhåll;
    //    public int Kostnad;
    //}
    //Kanske behövs inte, frågan säger att det inte behövs för det här tillfället, och de efterfrågar inte efter nästa tillfälle

    
}
