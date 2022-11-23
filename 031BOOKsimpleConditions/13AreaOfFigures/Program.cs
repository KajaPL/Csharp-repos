using System;

namespace _13AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double sum = a * a;
                Console.WriteLine($"{sum:F3}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double sum = a * b;
                Console.WriteLine($"{sum:F3}");
            }
            else if (figure == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                double sum = a * Math.PI * a;
                Console.WriteLine($"{sum:F3}");
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double sum = 0.5 * a * b;
                Console.WriteLine($"{sum:F3}");
            }
        }
    }
}
