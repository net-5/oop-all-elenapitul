using OOP_All.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_All
{
    public class Fish : Animal, ISwim, IAmSpecial
    {
        public Fish (string name) : base(name)
        {

        }

        public int Speed { get; set; }

        public void Swim()
        {
            Console.WriteLine($"{Name} is a fish and can swim.");
        }

        public void SpecialFeature()
        {
            Console.WriteLine($"{Name} is a fish because it lives in water, has gills, scales and fins.");
        }

    }
}
