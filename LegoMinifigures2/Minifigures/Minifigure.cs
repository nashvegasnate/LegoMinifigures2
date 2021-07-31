using LegoMinifigures2.Heads;
using LegoMinifigures2.Legs;
using LegoMinifigures2.Torsos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures2.MiniFigures
{
    class Minifigure
    {
        HeadBase Head { get; } 
        TorsoBase Torso { get; }
        LegBase Leg { get; }

        public Minifigure(HeadBase head, TorsoBase torso, LegBase leg)
        {
            Head = head;
            Torso = torso;
            Leg = leg;
        }

        public void BuildIt()
        {
            Console.WriteLine("I love to build things with my bare hands.");
            Head.SayHi();
            Head.Spin();
        }
         
    }
}
