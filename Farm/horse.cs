using System;


namespace Farm
{
    public class Horse : GrazingAnimal, IProduce
    {
        public string Product { get => "transportation" ; }

        public Horse(string name) : base(name)
        {
            _numLegs = 4;
            _species = "horse";
            _value = 1;
        }

        public override void Speak()
        {
            Console.WriteLine($"Horse {_name} says \"Neigh~\"");
        }

        public void Run()
        {
            Console.WriteLine($"A {Species} is running.");
        }

        public string Provide()
        {
            return Product;
        }

        public override void Eat() 
        {
            Graze();
        }
    }
}
