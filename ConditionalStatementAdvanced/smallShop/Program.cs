using System;

namespace smallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                if (item == "coffee")
                {
                    double sum = quantity * 0.50;
                    Console.WriteLine(sum);
                }
                else if (item == "water")
                {
                    double sum = quantity * 0.80;
                    Console.WriteLine(sum);
                }
                else if (item == "beer")
                {
                    double sum = quantity * 1.20;
                    Console.WriteLine(sum);
                }
                else if (item == "sweets")
                {
                    double sum = quantity * 1.45;
                    Console.WriteLine(sum);
                }
                else if (item == "peanuts")
                {
                    double sum = quantity * 1.60;
                    Console.WriteLine(sum);
                }
            }
            if (town == "Plovdiv")
            {
                if (item == "coffee")
                {
                    double sum = quantity * 0.40;
                    Console.WriteLine(sum);
                }
                else if (item == "water")
                {
                    double sum = quantity * 0.70;
                    Console.WriteLine(sum);
                }
                else if (item == "beer")
                {
                    double sum = quantity * 1.15;
                    Console.WriteLine(sum);
                }
                else if (item == "sweets")
                {
                    double sum = quantity * 1.30;
                    Console.WriteLine(sum);
                }
                else if (item == "peanuts")
                {
                    double sum = quantity * 1.50;
                    Console.WriteLine(sum);
                }
            }
            if (town == "Varna")
            {
                if (item == "coffee")
                {
                    double sum = quantity * 0.45;
                    Console.WriteLine(sum);
                }
                else if (item == "water")
                {
                    double sum = quantity * 0.70;
                    Console.WriteLine(sum);
                }
                else if (item == "beer")
                {
                    double sum = quantity * 1.10;
                    Console.WriteLine(sum);
                }
                else if (item == "sweets")
                {
                    double sum = quantity * 1.35;
                    Console.WriteLine(sum);
                }
                else if (item == "peanuts")
                {
                    double sum = quantity * 1.55;
                    Console.WriteLine(sum);
                }
            }
        }
    }
}