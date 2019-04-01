using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Human : Animal
    {
        public static int numHumans = 0;  //public shared field to keep track of how many humans are created
        public Human(string Name) : base(Name)
        {
            _numLegs = 2;
            _species = "Human";
            //human has lower value than animal in Animal Farm
            _value = 0;
            numHumans++;
            Console.WriteLine($"{Species} {Name} added.");
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void Run()
        {
            base.Run();
        }

        public override void Speak()
        {
            base.Speak();
        }
    }
}
