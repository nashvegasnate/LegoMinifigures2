using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures2.Heads
{
    class AstronautHead : HeadBase
    {
        public bool WearingHelmet { get; set; }
        public FacialHair FacialHair { get; set; }
    
        public override void SayHi()
        {   //base lets you interact with the base indicated above on line 9
            base.SayHi();
            Console.WriteLine("Major Tom to Ground Control...");
        }

        public override void Spin()
        {
            Console.WriteLine("The Astronaut head spins to take in the beauty of the cosmos...");
        }

        public void Shave()
        {
            Console.WriteLine($"The Astronaut head shaves its {FacialHair}.");
                //sets facial hair to none once Astronaut shaves
            FacialHair = FacialHair.None;
        }
    }

}
