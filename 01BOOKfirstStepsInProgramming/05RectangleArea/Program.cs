using System;

namespace _05RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());

            int sum = sideA * sideB;

            Console.WriteLine($"{sum}");

        }
    }
}
