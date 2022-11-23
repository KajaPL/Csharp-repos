using System;

namespace _02dLunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheSerial = Console.ReadLine();
            int timeForOneEpisode = int.Parse(Console.ReadLine());
            int timeForBreak = int.Parse(Console.ReadLine());

            double timeForLunnch = timeForBreak * 0.125;
            double timeForOtdih = timeForBreak * 0.25;
            double leftTime = timeForBreak - timeForLunnch - timeForOtdih;

            if (leftTime >= timeForOneEpisode)
            {
                Console.WriteLine("You have enough time to watch {0} and left with {1} minutes free time.", nameOfTheSerial, Math.Ceiling(leftTime - timeForOneEpisode));
            }
            else
            {
                Console.WriteLine("You don't have enough time to watch {0}, you need {1} more minutes.", nameOfTheSerial, Math.Ceiling(timeForOneEpisode - leftTime));
            }
        }
    }
}
