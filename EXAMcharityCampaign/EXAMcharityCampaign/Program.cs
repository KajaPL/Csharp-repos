using System;

namespace EXAMcharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int chefs = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double sumCakes = cakes * 45.00;
            double sumWaffles = waffles * 5.80;
            double sumPancakes = pancakes * 3.20;

            double Sum1day = (sumCakes + sumWaffles + sumPancakes) * chefs;
            double SumAlldays = Sum1day * days;
            double sum = SumAlldays - (SumAlldays * 0.125);

            Console.WriteLine($"{sum:f2}");
        }
    }
}
