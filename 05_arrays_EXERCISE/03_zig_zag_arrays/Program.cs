using System;
using System.Linq;

namespace _03_zig_zag_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var number in numbers)
            {
                double result = Math.Round(number, 0, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number} => {result}");
            }
        }
    }
}
