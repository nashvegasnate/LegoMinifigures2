using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures2.Heads
{
    abstract class HeadBase
    {
        public LegoColor Color { get; set; }

        //for all heads to say same thing
        public virtual void SayHi()
        {
            Console.WriteLine("Hi.");
        }
        // says that we don't know what Spin is gonna do, but we know that you are supposed to have that behavior
        // i.e., the abstract is forcing the inherited classes to have this behavior (or that it will be using this method
        public abstract void Spin();
    }

}
