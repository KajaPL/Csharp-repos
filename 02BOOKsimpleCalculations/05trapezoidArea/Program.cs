using System;

namespace _05trapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var trapezoid1 = double.Parse(Console.ReadLine());
            var trapezoid2 = double.Parse(Console.ReadLine());
            var trapezoid3 = double.Parse(Console.ReadLine());
            var area = (trapezoid1 + trapezoid2) * trapezoid3 / 2.0;
            Console.WriteLine("Trapezoid area = " + area);
        }
    }
}
