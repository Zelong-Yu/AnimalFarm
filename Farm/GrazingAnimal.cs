namespace Farm
{
    public abstract class GrazingAnimal : Animal
    {
        public static int numGrazingAnimals = 0;  //public shared field to keep track of how many grazing animals are created
        public GrazingAnimal(string Name) : base(Name)
        {
            numGrazingAnimals++;
        }

        public void Graze()
        {
            System.Console.WriteLine($"{Species} {Name} is chewing grass.");
        }
    }
}