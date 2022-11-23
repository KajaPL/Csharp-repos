using System;

namespace _05aTennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfTurnirs = int.Parse(Console.ReadLine());
            int initialPoints = int.Parse(Console.ReadLine());
            double numberOfWons = 0;
            string stage = "";
            int wonPoints = 0;

            //double percent = 0;
            for (int i = 0; i < numberOfTurnirs; i++)
            {
                stage = Console.ReadLine();
                if (stage == "W")
                {
                    wonPoints += 2000;
                    numberOfWons++;
                }
                else if (stage == "F")
                {
                    wonPoints += 1200;
                }
                else if (stage == "SF")
                {
                    wonPoints += 720;
                }

            }
            double average = wonPoints / numberOfTurnirs;
            double percent = (numberOfWons / numberOfTurnirs) * 100;
            Console.WriteLine($"Final points: {wonPoints + initialPoints}");
            Console.WriteLine("Average points: {0}", Math.Floor(average));
            Console.WriteLine($"{percent:F2}%");
        }
    }
}
