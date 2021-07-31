using LegoMinifigures2.Heads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures2.Torsos
{
    class BatSuitTorso : TorsoBase
    {
        public bool HasBatarang { get; set; }
        public LegoColor Color { get; set; }
        public override void Greeting()
        {
            base.Greeting();
            Console.Write("Gives fist pump.");
        }

        public override void Wiggle()
        {
            Console.WriteLine("Flex on 'em!");
        }
        public void Donates()
        {
            Console.WriteLine("Donates $15 million to Childrens' Charity.");
        }
    }
}
