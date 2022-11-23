using System;

namespace _05aDarts
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int score = 301;
            int succesfulShots = 0;
            int unsuccesfulShots = 0;
            string area = Console.ReadLine();
            while (area != "Retire")
            {
                int initialPoints = int.Parse(Console.ReadLine());
                int currentPoints = 0;

                switch (area)
                {
                    case "Single":
                        currentPoints = initialPoints;
                        break;
                    case "Double":
                        currentPoints = initialPoints * 2;
                        break;
                    case "Triple":
                        currentPoints = initialPoints * 3;
                        break;
                }
                if (score - currentPoints >= 0)
                {
                    succesfulShots++;
                    score -= currentPoints;
                }
                else
                {
                    unsuccesfulShots++;
                }
                if (score == 0)
                {
                    break;
                }

                area = Console.ReadLine();
            }
            if (area == "Retire")
            {
                Console.WriteLine($"{name} retired after {unsuccesfulShots} unsuccessful shots.");
            }
            else
            {
                Console.WriteLine($"{name} won the leg with {succesfulShots} shots.");
            }
        }
    }
}
