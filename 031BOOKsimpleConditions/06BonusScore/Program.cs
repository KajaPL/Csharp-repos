using System;

namespace _06BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonusScore = 0;

            if (num <= 100)
            {
                bonusScore += 5;
            }
            else if (num > 100 && num <= 1000)
            {
                bonusScore += num * 0.20;
            }
            else
            {
                bonusScore += num * 0.10;
            }
            if (num % 2 == 0)
            {
                bonusScore += 1;
            }
            if (num % 10 == 5)
            {
                bonusScore += 2;
            }

            double totalScore = num + bonusScore;

            Console.WriteLine(bonusScore);
            Console.WriteLine(totalScore);
        }
    }
}
