using System;

namespace _10RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var deg = 180 * rad / Math.PI;
            Console.WriteLine(Math.Round(deg));
        }
    }
}
