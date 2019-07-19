using OOP_All.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_All.Animals
{
    public class Bat : Mammal, IFly
    {
        public Bat (string name) : base(name)
        {

        }

        public int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Fly()
        {
            Console.WriteLine($"This is {Name}. It is a mammal that can fly.");
        }
    }
}
