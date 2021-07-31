using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures2.Legs
{
    class SeaLeg : LegBase
    {
        public bool AreWobbly { get; set; }
        public int NumberOfLegs { get; set; }

        public void Swim()
        {
            Console.WriteLine("I'm a certified swimmer.");
        }

        public override void Walk()
        {
            Console.WriteLine("Currently walking the plank.");
        }

    }
}
