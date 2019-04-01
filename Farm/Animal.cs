using System;

namespace Farm
{
    public class Animal : IComparable<Animal>, IEquatable<Animal>
    {
        protected string _name;
        protected int _numLegs;
        protected string _species;
        protected int _value;
        public static int numAnimals = 0;  //public shared field to keep track of how many animals are created

        public string Name { get => this._name; set => this._name = value; }
        public string Species { get => this._species; }

        public Animal(string Name)
        {
            this._name = Name;
            numAnimals++;
        }

        public virtual void Speak()
        {
            Console.WriteLine($"I am {_name}. I am a {Species}. ");
        }

        public virtual void Eat()
        {
            Console.WriteLine("I eat food.");
        }

        public virtual void Run()
        {
            Console.WriteLine($"{Species} {Name} tries to run with his {_numLegs} legs.");
        }

        public int NumLegs()
        {
            return _numLegs;
        }

        public int CompareTo(Animal other)
        {
            if (other == null) return 1;
            return _value.CompareTo(other._value);
        }

        // Define the is greater than operator.
        public static bool operator >(Animal operand1, Animal operand2)
        {
            return operand1.CompareTo(operand2) == 1;
        }

        // Define the is less than operator.
        public static bool operator <(Animal operand1, Animal operand2)
        {
            return operand1.CompareTo(operand2) == -1;
        }

        // Define the is greater than or equal to operator.
        public static bool operator >=(Animal operand1, Animal operand2)
        {
            return operand1.CompareTo(operand2) >= 0;
        }

        // Define the is less than or equal to operator.
        public static bool operator <=(Animal operand1, Animal operand2)
        {
            return operand1.CompareTo(operand2) <= 0;
        }


        public bool Equals(Animal other)
        {
            if (other == null)
                return false;

            if (this._value == other._value)
                return true;
            else
                return false;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            Animal AnimalObj = obj as Animal;
            if (AnimalObj == null)
                return false;
            else
                return Equals(AnimalObj);
        }

        public static bool operator == (Animal animal1, Animal animal2)
        {
            if (((object)animal1) == null || ((object)animal2) == null)
                return Object.Equals(animal1, animal2);

            return animal1.Equals(animal2);
        }

        public static bool operator != (Animal animal1, Animal animal2)
        {
            if (((object)animal1) == null || ((object)animal2) == null)
                return !Object.Equals(animal1, animal2);

            return !(animal1.Equals(animal2));
        }


    }
}