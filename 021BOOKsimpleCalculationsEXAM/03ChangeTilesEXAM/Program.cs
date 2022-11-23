using System;

namespace _03ChangeTilesEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            int platform = int.Parse(Console.ReadLine());
            double widthTile = double.Parse(Console.ReadLine());
            double lengthTile = double.Parse(Console.ReadLine());
            double widthBench = double.Parse(Console.ReadLine());
            double lengthBench = double.Parse(Console.ReadLine());

            double platformSize = platform * platform;
            double tileSize = widthTile * lengthTile;
            double benchSize = widthBench * lengthBench;

            double sum1 = platformSize - benchSize;
            double sum2 = sum1 / tileSize;

            double time = sum2 * 0.2;

            Console.WriteLine(sum2);
            Console.WriteLine(time);
        }
    }
}
