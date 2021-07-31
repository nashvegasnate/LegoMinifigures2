﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures2.Torsos
{
    class CowboyTorso : TorsoBase
    {
        public bool HasPullString { get; set; }
        public bool HasHolster { get; set; }

        public override void Greeting()
        {
            base.Greeting();
            Console.WriteLine("There's a snake in my boot.");
        }
        public override void Wiggle()
        {
            Console.WriteLine("Cowboy friendly reaches for their holster and pulls out a banana, for good health.");
        }

        public void LassoDance()
        {
            Console.WriteLine("To move like a cowboy, it's all in the wrist.");
        }
    }
}
