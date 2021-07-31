using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures2.Legs
{
    abstract class LegBase
    {
        public Bottoms Bottoms { get; set; }
        public Shoes Kicks { get; set; }

        public virtual void Dance()
        {
            Console.WriteLine("Start doing the Electric Slide.");
        }
        //every leg will do its own inherited version of walking by use of the abstract
        public abstract void Walk();
    }
}
