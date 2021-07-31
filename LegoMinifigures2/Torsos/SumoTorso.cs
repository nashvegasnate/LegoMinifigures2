using LegoMinifigures2.Heads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures2.Torsos
{
    class SumoTorso : TorsoBase
    {
        public bool AreTheyThicc { get; set; }
        public LegoColor Fundoshi {get; set;}
      
        public override void Wiggle()
        {
           Console.WriteLine("Sumo, does their Shiko before the match.");
        }

        public void FightPrep()
        {
            Console.WriteLine("Before the match, sprinkle some salt.");
        }
    }
}
