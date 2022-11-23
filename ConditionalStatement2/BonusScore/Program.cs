using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialPoints = int.Parse(Console.ReadLine());
            double bonus = 0.0;

            if (initialPoints <= 100)
            {
                bonus = 5;
            }
            else if (initialPoints > 1000)
            {
                bonus= initialPoints * 0.10;
            }
            else
            {
                bonus = initialPoints * 0.20;
            }

            if (initialPoints % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (initialPoints % 10 == 5)
            {
                bonus = bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(initialPoints + bonus);
        }

    }
}
