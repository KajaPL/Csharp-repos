using System;

namespace EXAMtoyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double travel = double.Parse(Console.ReadLine());
            int puzzel = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int CountAll = puzzel + doll + bear + minions + trucks;

            double PriceAll = puzzel * 2.60 + doll * 3 + bear * 4.10 + minions * 8.20 + trucks * 2;

            if (CountAll >= 50)
            {
                PriceAll = PriceAll * 0.75;
            }

            double rent = PriceAll * 0.1;
            PriceAll = PriceAll - rent;

            if (PriceAll >= travel)
            {
                double difference = PriceAll - travel;
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
            else
            {
                double difference = travel - PriceAll;
                Console.WriteLine($"Not enough money! {difference:f2} lv needed.");
            }
         
            
        }

    }
}
