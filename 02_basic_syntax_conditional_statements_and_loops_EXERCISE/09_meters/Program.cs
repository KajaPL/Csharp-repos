using System;

namespace _09_meters
{
    class Program
    {
        static void Main(string[] args)
        {
            int pound = int.Parse(Console.ReadLine());

            decimal usd = pound * 1.31M;

            Console.WriteLine($"{usd:F3}");
        }
    }
}
