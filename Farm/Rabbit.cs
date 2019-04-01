using System;

namespace Farm
{
    internal class Rabbit : GrazingAnimal
    {
        public Rabbit(string Name) : base(Name)
        {
            _numLegs = 4;
            _species = "rabbit";
            _value = 1;
        }

        public override void Speak()
        {
            Console.WriteLine($"Rabbit {_name} says \"Squeak~\"");
        }

        public override void Eat()
        {
            Graze();
        }
    }
}