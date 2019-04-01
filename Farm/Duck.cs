using System;

namespace Farm
{
    internal class Duck : Animal, ISwimable
    {
        public Duck(string Name) : base(Name)
        {
            _numLegs = 2;
            _species = "duck";
            _value = 1;
        }

        public void Swim()
        {
            Console.WriteLine($"A {Species} can swim.");
        }

        public override void Speak()
        {
            Console.WriteLine($"Duck {_name} says \"Quack~\"");
        }

        public override void Eat()
        {
            Console.WriteLine($"Duck {_name} eats insects and seeds.");
        }
    }
}