using System;

namespace EXAMfruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceStrawberries = double.Parse(Console.ReadLine());
            double kgBananas = double.Parse(Console.ReadLine());
            double kgOranges = double.Parse(Console.ReadLine());
            double kgRaspberries = double.Parse(Console.ReadLine());
            double kgStrawberries = double.Parse(Console.ReadLine());

            double priceRaspberries = priceStrawberries / 2;
            double priceOranges = priceRaspberries - (0.4 * priceRaspberries);
            double priceBananas = priceRaspberries - (0.8 * priceRaspberries);

            double sumRaspberries = kgRaspberries * priceRaspberries;
            double sumOranges = kgOranges * priceOranges;
            double sumBananas = kgBananas * priceBananas;
            double SumStrawberries = kgStrawberries * priceStrawberries;

            double sum = sumRaspberries + sumOranges + sumBananas + SumStrawberries;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
