using System;

namespace VegetableMarketEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            double oneKgVege = double.Parse(Console.ReadLine());
            double oneKgFruits = double.Parse(Console.ReadLine());
            double allKgVege = double.Parse(Console.ReadLine());
            double allKgFruits = double.Parse(Console.ReadLine());

            double sumVege = oneKgVege * allKgVege;
            double sumFruits = oneKgFruits * allKgFruits;
            double sumAll = (sumVege + sumFruits) / 1.94;
                Console.WriteLine(sumAll);
        }
    }
}
