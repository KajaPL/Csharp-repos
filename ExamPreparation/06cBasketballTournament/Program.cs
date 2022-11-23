using System;

namespace _06cBasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string turnirName = Console.ReadLine();
            //int numberOfMatches = int.Parse(Console.ReadLine());
            int winCounter = 0;
            int loseCounter = 0;
            double totalMatches = 0;

            while (turnirName != "End of tournaments")
            {
                int numberOfMatches = int.Parse(Console.ReadLine());
                totalMatches += numberOfMatches;
                for (int i = 1; i <= numberOfMatches; i++)
                {
                    int ourPoints = int.Parse(Console.ReadLine());
                    int enemyPoints = int.Parse(Console.ReadLine());

                    if (ourPoints > enemyPoints)
                    {
                        winCounter++;
                        int diff = ourPoints - enemyPoints;
                        Console.WriteLine($"Game {i} of tournament {turnirName}: win with {diff} points.");
                    }
                    else if (ourPoints < enemyPoints)
                    {
                        loseCounter++;
                        int diff = enemyPoints - ourPoints;
                        Console.WriteLine($"Game {i} of tournament {turnirName}: lost with {diff} points.");
                    }
                }
                turnirName = Console.ReadLine();
            }
            double winPercent = (winCounter / totalMatches) * 100;
            double losePercent = (loseCounter / totalMatches) * 100;
            Console.WriteLine($"{winPercent:F2}% matches win");
            Console.WriteLine($"{losePercent:F2}% matches lost");
        }
    }
}
