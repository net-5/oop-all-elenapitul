using OOP_All.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_All.Animals
{
    public class WildDuck : Bird, ISwim, IFly, IWalk
    {
        

        public WildDuck (string name) : base(name)
        {

        }

        public int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Swim()
        {
            Console.WriteLine($"{Name} can swim.");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} can fly.");
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} can walk.");
        }
    }
}
