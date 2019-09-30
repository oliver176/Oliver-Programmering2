using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace President
{
    class President
    {
        public string name;
        int environmentPriority;
        int defensePriority;
        int healthcarePriority;
        int corruption;
        int money;
        Random generator = new Random();

        public President(string n)
        {
            name = n;
            environmentPriority = generator.Next(0, 100);
            defensePriority = generator.Next(0, 100);
            healthcarePriority = generator.Next(0, 100);

        }
        public void Present()
        {
            Console.WriteLine(name);
            Console.WriteLine("\nEnvironment priority: " + environmentPriority);
            Console.WriteLine("Defense priority: " + defensePriority);
            Console.WriteLine("Healthcare priority: " + healthcarePriority);
            Console.WriteLine("Corruption: " + corruption + "\n");
        }
        public bool PassLegislation(int e, int d, int h, int bribe)
        {
            money += bribe;
            environmentPriority += bribe;
            defensePriority += bribe;
            healthcarePriority += bribe;
            corruption += bribe / 10;

            if (e < environmentPriority && d < defensePriority && h < healthcarePriority)
            {
                return true;
            }

            return false;
        }
    }
}
