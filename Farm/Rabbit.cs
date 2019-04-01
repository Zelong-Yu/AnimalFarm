using System;

namespace Farm
{
    internal class Rabbit : GrazingAnimal
    {
        public static int numRabbits = 0;  //public shared field to keep track of how many rabits are created
        public Rabbit(string Name) : base(Name)
        {
            _numLegs = 4;
            _species = "Rabbit";
            _value = 1;
            numRabbits++;
            Console.WriteLine($"{Species} {Name} added.");
        }

        public override void Speak()
        {
            Console.WriteLine($"Rabbit {_name} says \"Squeak~\"");
        }

        public override void Eat()
        {
            Graze();
        }

        public override void Run()
        {
            base.Run();
            Console.WriteLine($"Rabbit {Name} jumps with its two strong thighs. ");
        }
    }
}