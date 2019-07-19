using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_All.Animals
{
    public class Ostrich : Bird
    {
        public Ostrich (string name) : base(name)
        {

        }

        public void Flightless()
        {
            Console.WriteLine($"{Name} is a bird, but cannot fly.");
        }
    }
}
