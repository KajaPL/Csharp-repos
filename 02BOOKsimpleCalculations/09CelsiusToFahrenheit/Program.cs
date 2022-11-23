using System;

namespace _09CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());
            var sum = (celsius * 1.8) + 32;
            Console.WriteLine(Math.Round(sum, 2));
        }
    }
}
