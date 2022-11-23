using System;

namespace _06CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter circle radius. r = ");
            var r = double.Parse(Console.ReadLine());
            var sum = Math.PI * r * r;
            Console.WriteLine("Area = {0}", sum);
            var perimeter = 2 * Math.PI * r;
            Console.WriteLine("Perimeter = {0}", perimeter);
        }
    }
    }
}
