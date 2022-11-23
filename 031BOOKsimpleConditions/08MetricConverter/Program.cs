using System;

namespace _08MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            var source = Console.ReadLine().ToLower();
            var destination = Console.ReadLine().ToLower();
            switch (source)
            {
                case "mm":
                    number = number * 0.001;
                    break;
                case "cm":
                    number = number * 0.01;
                    break;
                case "mi":
                    number = number * 1609.344;
                    break;
                case "in":
                    number = number * 0.0254;
                    break;
                // 12 km to 12 000 metrów
                case "km":
                    number = number * 1000;
                    break;
                case "ft":
                    number = number * 0.3048;
                    break;
                case "yd":
                    number = number * 0.9144;
                    break;
            }
            switch (destination)
            {
                case "mm":
                    number = number * 1000;
                    break;
                case "cm":
                    number = number * 100;
                    break;
                case "mi":
                    number = number * 0.000621371192;
                    break;
                case "in":
                    number = number * 39.3700787;
                    break;
                case "km":
                    number = number * 0.001;
                    break;
                case "ft":
                    number = number * 3.2808399;
                    break;
                case "yd":
                    number = number * 1.0936133;
                    break;

            }
            Console.WriteLine(number);
        }
    }
}

