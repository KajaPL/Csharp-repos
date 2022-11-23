using System;
using System.Diagnostics.CodeAnalysis;

namespace EXAMfishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int widht = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent1 = double.Parse(Console.ReadLine());

            double volumeAquarium = length * widht * height;
            double AllLitres = volumeAquarium * 0.001;
            double percent2 = percent1 * 0.01;

            double sumLitres = AllLitres * (1 - percent2);

            Console.WriteLine($"{sumLitres:f5}");

        }
    }
}
