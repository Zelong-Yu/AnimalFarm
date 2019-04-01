using System;

namespace Farm
{
    public class Duck : Animal, ISwimable
    {
        public static int numDucks = 0;  //public shared field to keep track of how many Duckss are created
        public Duck(string Name) : base(Name)
        {
            _numLegs = 2;
            _species = "Duck";
            _value = 1;
            numDucks++;
            Console.WriteLine($"{Species} {Name} added.");
        }

        public void Swim()
        {
            Console.WriteLine($"{Species} {Name} can swim.");
        }

        public override void Speak()
        {
            Console.WriteLine($"Duck {_name} says \"Quack~\"");
        }

        public override void Eat()
        {
            Console.WriteLine($"Duck {_name} eats insects and seeds.");
        }

        public override void Run()
        {
            base.Run();
            Console.WriteLine("\"Quack!Quack!Quack!\"");
        }
    }
}