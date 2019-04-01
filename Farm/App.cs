using System;
using System.Collections.Generic;

namespace Farm
{
    public class App
    {
        List<Animal> animals = new List<Animal>();
        public App()
        {
        }

        public void Run()
        {
            Console.WriteLine("Welcome to Animal Farm.");
            Console.WriteLine(@"
 All animals are equal       +&-
 but some animals          _.-^-._    .--.
 are more equal         .-'   _   '-. |__|
 than others           /     |_|     \|  |
                      /               \  |
                     /|     _____     |\ |
                      |    |==|==|    |  |
  |---|---|---|---|---|    |--|--|    |  |
  |---|---|---|---|---|    |==|==|    |  |
 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^                
                ");
            PromptForInput(">>>Press any key to add a horse.");
            Horse Ed = new Horse("Mr. Ed");
            animals.Add(Ed);
            PromptForInput("Press any key to let it eat.           ");
            Ed.Eat();
            PromptForInput("Press any key to let it run.           ");
            Ed.Run();

            PromptForInput("Press any key to add another horse.");
            Horse MrsEd = new Horse("Mrs. Ed");
            animals.Add(MrsEd);
            PromptForInput("What does it provide?                      ");
            Console.WriteLine($"{MrsEd.Provide()}."); 

            PromptForInput("Press any key to add a rabbit.             ");
            Rabbit Bunny = new Rabbit("Ms. Bunny");
            animals.Add(Bunny);
            PromptForInput("Press any key to let it run.              ");
            Bunny.Run();


            PromptForInput("Press any key to add a duck.            ");
            Duck donald = new Duck("Donald");
            animals.Add(donald);
            PromptForInput("Press any key to let it swim.           ");
            donald.Swim();

            PromptForInput("Press any key to add a human.             ");
            Human Tom = new Human("Tom");
            animals.Add(Tom);
            PromptForInput("Press any key to let it speak.           ");
            Tom.Speak();

            

            PromptForInput("Press any key to add a pig.              ");
            Console.Clear();
            Pig Snowball = new Pig("Snowball");
            animals.Add(Snowball);
            PromptForInput("Press any key to let it speak.           ");
            Snowball.Speak();

            PromptForInput("Press any key to add another pig.          ");
            Pig Napoleon = new Pig("Napoleon");
            animals.Add(Napoleon);
            PromptForInput("Press any key to let it speak.           ");
            Napoleon.Speak();

            PromptForInput("Now press any key to let everyone speak                       ");
            foreach (var animal in animals)
            {
                animal.Speak();

            }

            PromptForInput("How many legs everyone has?                       ");
            foreach (var animal in animals)
            {
                Console.Write($"{animal.Name} has {animal.NumLegs()} legs.\n");

            }

            PromptForInput("Now press any key to let everyone run                       ");
            foreach (var animal in animals)
            {
                animal.Run();

            }

            

        }

        public static ConsoleKey PromptForInput(string prompt = ">")
        {
            var cursorLeftPos = Console.CursorLeft;
            var cursorTopPos = Console.CursorTop;

            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.Write(prompt);

            Console.SetCursorPosition(cursorLeftPos, cursorTopPos);

            return Console.ReadKey(true).Key;
        }
    }
}