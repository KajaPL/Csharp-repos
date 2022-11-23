using System;

namespace _02_pounds_to_dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            
                decimal pound = decimal.Parse(Console.ReadLine());

                decimal usd = pound * 1.31M;

                Console.WriteLine($"{usd:F3}");
            
        }
    }
}

