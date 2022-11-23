using System;

namespace TrainingLabEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthMeters = double.Parse(Console.ReadLine());
            double widthMeters = double.Parse(Console.ReadLine());
            // Ограничения: 3 ≤ w ≤ l ≤ 100
            double row = Math.Truncate(lengthMeters / 1.2);
            double column = Math.Truncate((widthMeters - 1) / 0.7);
            double place = (row * column) - 3;

            Console.WriteLine(place);
        }
    }
}
