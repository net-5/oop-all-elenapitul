using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_All
{
    public class Animal
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Animal (string name)
        {
            this.Name = name;
        }
    }
}
