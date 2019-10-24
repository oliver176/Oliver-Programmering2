using System;

namespace President
{
    class Land
    {
        Random generator = new Random();

        public int population;
        public int BNP;
        public float BNPperCap;
        public int skatt;
        public int area;

        public string name;

        public Land(string n)
        {
            name = n;

            population = generator.Next(1000000, 10000000);
            skatt = generator.Next(15, 40);
            area = generator.Next(50000, 500000);
            BNP = generator.Next(Convert.ToInt32(Math.Pow(10, 7)), Convert.ToInt32(Math.Pow(10, 8)));
            BNPperCap = BNP / population;
        }
        public void Present()
        {
            Console.Clear();
            Console.WriteLine("Country name: " + name);
            Console.WriteLine("\nPopulation: " + population);
            Console.WriteLine("Skatt: " + skatt + "%");
            Console.WriteLine("Area: " + area + "km²");
            Console.WriteLine("BNP: " + BNP + "USD");
            Console.WriteLine("BNP Per Capita: " + BNPperCap + "USD\n");
        }

    }
}
