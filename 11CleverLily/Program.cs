using System;

namespace _11CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceMachine = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double savings = 0;
            double toysCount = 0;
            double money = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savings += money;
                    savings -= 1;
                    money += 10;
                }
                else
                {
                    toysCount++;
                }
            }
            savings += toysCount * toyPrice;
            if (savings >= priceMachine)
            {
                double leftMoney = savings - priceMachine;
                Console.WriteLine($"Yes! {leftMoney:F2}");
            }
            else
            {
                double diff = priceMachine - savings;
                Console.WriteLine($"No! {diff:F2}");
            }
        }
    }
}
