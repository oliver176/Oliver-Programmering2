using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Tamagotchi newGotchi = new Tamagotchi();

            newGotchi.name = NameGotchi();

            while (newGotchi.GetAlive())
            {
                Action(Input(), newGotchi);
                newGotchi.Tick();
            }

            Console.ReadLine();
        }

        private static int Input()
        {
            int input;

            string[] options = { "Teach word", "Say hello", "Feed it", "Do nothing" };

            while (true)
            {
                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine((i + 1) + ". " + options[i]);
                }

                if (int.TryParse(Console.ReadLine(), out input) && input <= options.Length && input > 0)
                {
                    break;
                }
                else Console.WriteLine("Enter a valid number.\n");
            }

            return input;
        }

        private static void Action(int input, Tamagotchi newGotchi)
        {
            if (input - 1 == 0) //Teach word
            {
                newGotchi.Teach(LearnWord());
            }
            if (input - 1 == 1) //Say hi
            {
                newGotchi.Hi();
            }
            if (input - 1 == 2) //Feed
            {
                newGotchi.Feed();
            }
            if (input - 1 == 3) //Do nothing
            {
            }
        }

        private static string NameGotchi()
        {
            Console.WriteLine("Name the Tamagotchi!\n");
            return Console.ReadLine();
        }

        private static string LearnWord()
        {
            Console.WriteLine("Enter a word to teach the Tamagotchi.");

            return Console.ReadLine();
        }
    }

    internal class Tamagotchi
    {
        private int hunger = 0;
        private int boredom = 0;
        private List<string> words = new List<string>();
        private bool isAlive = true;
        public string name;
        public int TickCounter;

        public void Feed() // sänker Hunger
        {
            Console.WriteLine("You feed " + name + ".");
            hunger -= 2;

            if (hunger < 0)
            {
                hunger = 0;
            }
        }

        public void Hi() // skriver ut ett slumpat ord från words, och anropar ReduceBoredom.
        {
            Console.WriteLine("You say hello to " + name + ".");
            boredom -= 2;

            if (boredom < 0)
            {
                boredom = 0;
            }
        }

        public void Teach(string word) // lägger till ett ord i words, och anropar ReduceBoredom.
        {
            words.Add(word);
        }

        public void Tick() //ökar hunger och boredom, och om någon av dem kommer över 10 så blir isAlive false.
        {
            TickCounter++;
            hunger++;
            boredom++;
            Console.WriteLine(TickCounter);
        }

        public void PrintStats() // skriver ut nuvarande hunger och bredom, och meddelar också huruvida tamagotchin lever.
        {
        }

        public bool GetAlive() // returnerar värdet som isAlive har.
        {
            if (hunger > 10 || boredom > 10)
            {
                isAlive = false;
            }

            return isAlive;
        }

        private void ReduceBoredom() // sänker boredom
        {
        }
    }
}