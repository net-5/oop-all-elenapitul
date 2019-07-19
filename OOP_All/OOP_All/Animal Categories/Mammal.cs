using OOP_All.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_All
{
    public class Mammal : Animal, IAmSpecial
    {
        public Mammal (string name) : base(name)
        {

        }

        public void SpecialFeature()
        {
            Console.WriteLine($"{Name} is a mammal because it drinks milk and has hair on its body.");
        }
       
    }
}
