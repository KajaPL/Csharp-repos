using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int vacation = int.Parse(Console.ReadLine());
            int eat = int.Parse(Console.ReadLine());
            double elen1 = double.Parse(Console.ReadLine());
            double elen2 = double.Parse(Console.ReadLine());
            double elen3 = double.Parse(Console.ReadLine());
            double sumElen1 = elen1 * vacation;
            double sumElen2 = elen2 * vacation;
            double sumElen3 = elen3 * vacation;
            double sumAll = sumElen1 + sumElen2 + sumElen3;
            if (sumAll < eat)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(eat - sumAll));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(sumAll - eat));
            }
        }
    }
}
