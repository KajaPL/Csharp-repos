using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string geometricShapes = Console.ReadLine();
            if (geometricShapes == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine(side * side);

            }
            else if (geometricShapes == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine(sideA * sideB);
            }
            else if (geometricShapes == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double result = Math.PI * radius * radius;
                Console.WriteLine($"{result:F3}");
            }
            else if (geometricShapes == "triangle")
                //а*б/2
            {
                double sideA = double.Parse(Console.ReadLine());
                double hight = double.Parse(Console.ReadLine());
                double result = (sideA * hight) / 2;
                Console.WriteLine($"{result:F3}");
            }
        }
    }
}
