using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures2.Heads
{
    class ConstructionWorkerHead : HeadBase
    {
        //attributes - properties
        public bool HasMullet { get; set; }
        public int NumberOfTeeth { get; set; }
        public bool WearingHardHat { get; set; }
        public LegoColor Color { get; internal set; }

        //behavior - methods - can use "void" if no return
        public bool ToggleWorking()
        {
            WearingHardHat = !WearingHardHat;
            Console.WriteLine($"The Construction Worker Head {(WearingHardHat ? "is" : "is not ")} wearing its hard hat");
            return WearingHardHat;
        }

        public override void Spin()
        {
            if (NumberOfTeeth > 0)
            NumberOfTeeth -= 1;
            
            Console.WriteLine($"The {Color} Construction Worker Head spins after being hit by a girder.");
        }

        //THIS SECTION, EVEN COMMENTED OUT, STILL PRINTS because it is included in the headBase 
        //public void SayHi()
        //{
           // Console.WriteLine("The Construction Worker Head says hello.");
        //}
    }

   
}
