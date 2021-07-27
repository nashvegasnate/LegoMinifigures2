using LegoMinifigures2.Heads;
using System;
using System.Collections.Generic;

namespace LegoMinifigures2
{
    class Program
    {
        static void Main(string[] args)
        {
            var workerHead = new ConstructionWorkerHead();
            workerHead.Color = LegoColor.Yellow;
            

            var batmanHead = new BatmanHead();
           

            var astronautHead = new AstronautHead();
            

            var heads = new List<HeadBase>() { astronautHead, batmanHead, workerHead };
            foreach (var head in heads)
                //anything they have in common, can use and treat similarly
            {
                head.SayHi();
                head.Spin();
            }
        }
    }
}
