﻿using System;
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
            var keyRead = Console.ReadKey(true).Key;
            var landList = new List<Land>();

            Console.WriteLine("How many lands do you want to make?");

            for (int i = 0; i < length; i++)
            {

            }


            Console.WriteLine("Name the president!");
            President obama = new President(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("1: Present");
            Console.WriteLine("2: Hey man do u want to pass new law?!");

            string input = Console.ReadLine();

            if (keyRead == ConsoleKey.D1)
            {
                obama.Present();
            }
            if (keyRead == ConsoleKey.D2)
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
