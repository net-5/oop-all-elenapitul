using OOP_All.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_All
{
    public class Insect : Animal, IAmSpecial
    {
        public Insect(string name) : base(name)
        {

        }

        public void SpecialFeature()
        {
            Console.WriteLine($"{Name} is an insect because together with spiders, are invertebrates, without backbones.");
        }
    }
}
