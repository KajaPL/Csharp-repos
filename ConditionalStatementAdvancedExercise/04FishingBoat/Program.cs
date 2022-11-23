using System;

namespace _04FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());
            double rent = 0;

            switch (season)
            {
                case "Spring":
                    rent = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    rent = 4200;
                    break;
                case "Winter":
                    rent = 2600;
                    break;
            }

            if (fishers <= 6)
            {
                rent = rent - (rent * 0.10);
            }
            else if (fishers >= 7 && fishers <= 11)
            {
                rent = rent - (rent * 0.15);
            }
            else if (fishers >= 12)
            {
                rent = rent - (rent * 0.25);
            }

            if (fishers % 2 == 0 && season != "Autumn")
            {
                rent = rent - (rent * 0.05);
            }


            if (budget >= rent)
            {
                double sum = budget - rent;
                Console.WriteLine($"Yes! You have {sum:f2} leva left.");
            }
            else
            {
                double sum = rent - budget;
                Console.WriteLine($"Not enough money! You need {sum:f2} leva.");
            }
        }
    }
}
