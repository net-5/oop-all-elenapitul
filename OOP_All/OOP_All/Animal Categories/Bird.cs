using OOP_All.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_All
{
    public class Bird : Animal, IAmSpecial
    {
        public Bird (string name) : base(name)
        {

        }

        public void SpecialFeature()
        {
            Console.WriteLine($"{Name} is a bird, because it has feathers.");
        }
    }
}
