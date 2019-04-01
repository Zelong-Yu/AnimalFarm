using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Pig : Animal, IProduce
    {
        public Pig(string Name) : base(Name)
        {
            _numLegs = 4;
            _species = "pig";
            //pig is "more equal" than any other animal
            _value = int.MaxValue;
        }

        public string Product => "pork" ;

        public string Provide()
        {
            return Product;
        }

        public override void Speak()
        {
            Console.WriteLine($"Pig {_name} says \"Oink~\"");
        }

        public override void Eat()
        {
            Console.WriteLine($"Pig {_name} eats milk and apple.");
        }
    }
}
