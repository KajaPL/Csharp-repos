using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double units = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            // превръщаме инпут в метри
            if (input == "cm")
            {
                units /= 100;
            }
            else if (input == "mm")
            {
                units /= 1000;
            }

            //превръщаме метри в оутпут
            if (output == "cm")
            {
                units *= 100;
            }
            else if (output == "mm")
            {
                units *= 1000;
            }

            Console.WriteLine($"{units:F3}");

        }
    }
}