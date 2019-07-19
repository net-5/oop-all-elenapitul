using OOP_All.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_All
{
    public class Reptile : Animal, IAmSpecial
    {
        public Reptile (string name) : base(name)
        {

        }

        public void SpecialFeature()
        {
            Console.WriteLine($"{Name} is a reptile because it has scaly skin and are cold blooded.");
        }
    }
}
