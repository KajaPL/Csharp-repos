using System;

namespace GodzillaKong
{
    class Program
    {
        static void Main(string[] args)
        {

            double filmBudget = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double priceClothesPerOneActor = double.Parse(Console.ReadLine());

            double priceClothes = priceClothesPerOneActor * actors;
            double decor = filmBudget * 0.10;

            if (actors > 150)
            {
                priceClothes *= 0.9;
            }
          
            double filmCost1 = decor + priceClothes;


            if (filmCost1 <= filmBudget && filmCost1 > 0)
            {

                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {filmBudget - filmCost1:F2} leva left.");
            }

            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(filmBudget - filmCost1):F2} leva more.");
            }
        }
    }
}