namespace Farm
{
    public abstract class GrazingAnimal : Animal
    {
        public GrazingAnimal(string Name) : base(Name)
        {
        }

        public void Graze()
        {
            System.Console.WriteLine($"{Species} {Name} is chewing grass.");
        }
    }
}