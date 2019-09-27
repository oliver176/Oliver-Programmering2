using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_ska_va_president_
{
    class Program
    {
        static void Main(string[] args)
        {
            President obama = new President("Obama");

            Console.WriteLine("1: Present");
            Console.WriteLine("2: Hey man do u want to pass new law?!");

            string input = Console.ReadLine();

            if (input == "1")
            {
                obama.Present();
            }
            if (input == "2")
            {
                Console.WriteLine("How much u care about environment? 0-100");
                int.TryParse(Console.ReadLine(), out int eCare);
                Console.WriteLine("How much u care about healthcare? 0-100");
                int.TryParse(Console.ReadLine(), out int hCare);
                Console.WriteLine("How much u care about defense? 0-100");
                int.TryParse(Console.ReadLine(), out int dCare);
                Console.WriteLine("Do u want to bribe el presidente? 0-100");
                int.TryParse(Console.ReadLine(), out int bribe);

                obama.PassLegislation(eCare, dCare, hCare, bribe);

                if (obama.PassLegislation(eCare, dCare, hCare, bribe))
                {
                    Console.WriteLine("The legislation passed!");
                }
                else Console.WriteLine("The legislation didn't pass!");
                
            }

            Console.ReadLine();

        }
    }
}
