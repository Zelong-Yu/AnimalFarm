using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse ponny = new Horse("bonny");
            ponny.Graze();
            Rabbit bunny = new Rabbit("bunny");
            bunny.Graze();

            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("Tommy"));
            animals.Add(new Horse("Edward"));
            animals.Add(new Duck("Donald"));
            animals.Add(bunny);

            Console.WriteLine(animals[1].GetType());
            ((Horse)animals[1]).Run();
            ((Duck)animals[2]).Swim();
            foreach (var animal in animals)
            {
                animal.Speak();
                Console.Write($"I have {animal.NumLegs()} legs.\n");
            }

        }





    }   
    }

