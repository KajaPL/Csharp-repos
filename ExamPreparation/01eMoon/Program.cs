using System;

namespace _01eMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double gorivoNeeded = double.Parse(Console.ReadLine());
            int toTheMoon = 384400;

            double totalDistance = toTheMoon * 2;
            double sum1 = totalDistance / speed;
            double wholeTime = sum1 + 3;
            double gorivo = (gorivoNeeded * (toTheMoon * 2)) / 100;



            Console.WriteLine("{0}", Math.Ceiling(wholeTime));
            Console.WriteLine("{0}", gorivo);
        }
    }
}
