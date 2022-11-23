using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var wineArea = double.Parse(Console.ReadLine());
            var grapeSquare = double.Parse(Console.ReadLine());
            var needLiters = double.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            double grapesForWine = (grapeSquare * wineArea) * 0.40;
            double wineLiters = grapesForWine / 2.5;
            if (wineLiters < needLiters)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(needLiters - wineLiters)} liters wine needed.");
            }
            else
            {
                double wineLeft = wineLiters - needLiters;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineLiters)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(wineLeft / workers)} liters per person.");
            }
        }
    }
}
