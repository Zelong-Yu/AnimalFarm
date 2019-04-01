using System;
using System.Text;

namespace Farm
{
    public class Horse : GrazingAnimal, IProduce
    {
        public static int numHorses = 0;  //public shared field to keep track of how many Horses are created
        public string Product { get => "transportation" ; }

        public Horse(string name) : base(name)
        {
            _numLegs = 4;
            _species = "Horse";
            _value = 1;
            numHorses++;
            Console.WriteLine($"{Species} {Name} added.");
        }

        public override void Speak()
        {
            Console.WriteLine($"Horse {_name} says \"Neigh~\"");
        }

        public override void Run()
        {
            base.Run();
            Console.WriteLine($"{Species} {Name} makes its move. " +
                $"Its hooves glittered in the sunlight as he marched through the weeds, head held high and proud. " +
                $"With a rumbling snort, he began to gallop, flying off his feet into the daring wind. He had legs " +
                $"corded with muscle and hooves that kissed the ground as he plummeted by. Running like wildfire, " +
                $"with his mane and tail streaming behind him like ribbons, he plummeted onward. Fire danced in his " +
                $"eyes as he briskly gathered his legs under him and rocketed into the air, swinging his massive brown " +
                $"head like a weapon, sharp and dangerously. He galloped through the ocean of green, soaring in hot " +
                $"pursuit of the ravenous wind. With his eyes locked on his target and his legs a blur, he charged " +
                $"forward, swallowing the sky in his burning passion. A passion to race the wind");
            //Quote from http://horses.yoexpert.com/readers-stories-and-tips-12927/describe-a-stallion-that-races-the-wind-40041.html
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
