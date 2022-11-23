using System;

namespace _01bTennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForOneRacket = double.Parse(Console.ReadLine());
            int countRacket = int.Parse(Console.ReadLine());
            int countShoes = int.Parse(Console.ReadLine());

            double priceRacket = countRacket * priceForOneRacket;
            double priceShoes = priceForOneRacket/ 6;
            double totalShoes = countShoes * priceShoes;
            double priceClothes = (priceRacket + totalShoes) * 0.20;

            double sum = priceRacket + totalShoes + priceClothes;
            double sum2 = sum - (sum * 0.875);
            double sum3 = sum - (sum * 0.125);

            Console.WriteLine("Price to be paid by Djokovic {0}", Math.Floor(sum2));
            Console.WriteLine("Price to be paid by sponsors {0}", Math.Ceiling(sum3));
        }
    }
}
