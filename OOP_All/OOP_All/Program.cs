using OOP_All;
using OOP_All.Animals;
using OOP_All.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_All
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Any kind you model is an animal
            //2. Any animal has a name
            //3. There are multiple animal categories like: mammals, fish, birds, reptile, insects
            //4. No matter the category, animals are flying, walking, swimming or crawling
            //5. Depending on the way they move, they have a maximum speed.
            //6.1. There are animals that can swim and walk. Platypus
            //6.2. There are animals that can swim, fly and walk. Wild Duck
            //7. Not any animal that can fly is a bird, the Bat is a mammal that flies
            // and not every bird flys - the Ostrich is a bird but doesn't fly

            
            Platypus platypus = new Platypus("Ornitorinc");
            platypus.SpecialFeature();
            platypus.Walk();
            platypus.Swim();

            Console.WriteLine();

            WildDuck wildDuck = new WildDuck("Rata salbatica");
            wildDuck.SpecialFeature();
            wildDuck.Fly();
            wildDuck.Swim();
            wildDuck.Walk();

            Console.WriteLine();

            Bat bat = new Bat("Liliac");
            bat.SpecialFeature();
            bat.Fly();

            Console.WriteLine();

            Ostrich ostrich = new Ostrich("Strut");
            ostrich.SpecialFeature();
            ostrich.Flightless();

            Console.WriteLine();


                                 
        }
    }
}
