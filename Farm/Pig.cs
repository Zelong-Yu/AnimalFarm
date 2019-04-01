using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Pig : Animal, IProduce
    {
        public static int numPigs = 0;  //public shared field to keep track of how many Pigs are created
        public Pig(string Name) : base(Name)
        {
            _numLegs = 4;
            _species = "Pig";
            //pig is "more equal" than any other animal

            //well, this one pig is special...
            if (Name.Equals("Napoleon")) { _value = int.MaxValue; }
            else { _value = 10; }
            numPigs++;
            Console.WriteLine($"{Species} {Name} added.");
        }

        public string Product => "pork" ;

        public string Provide()
        {
            return Product;
        }

        public override void Run()
        {
            Console.WriteLine("How dare you, a filthy two-leg being, command me to run? ");
        }

        public override void Speak()
        {
            Console.WriteLine($"Pig {_name} says \"Oink! All animals are equal!\"");
            if (_name.Equals("Napoleon")) Console.WriteLine("But some animals are more equal! Oink!");
        }

        public override void Eat()
        {
            Console.WriteLine($"Pig {_name} eats milk, apple...anything.");
        }
    }
}
