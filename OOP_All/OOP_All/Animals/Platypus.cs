using OOP_All.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_All.Animals
{
    public class Platypus : Mammal, ISwim, IWalk
    {
        public Platypus (string name) : base(name)
        {

        }

        public int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Swim()
        {
            Console.WriteLine($"{Name} can swim.");
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} can walk.");
        }

    }
}
