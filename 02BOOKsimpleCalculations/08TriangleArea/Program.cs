using System;

namespace _08TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var sum = side * height / 2;
            Console.WriteLine(Math.Round(sum, 2));
        }
    }
}
