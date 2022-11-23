using System;

namespace _05Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destinations = " ";
            string place = " ";
            double sum = 0;

            if (budget <= 100)
            {
                destinations = "Bulgaria";
            }
            if (destinations == "Bulgaria")
            {
                if (season == "summer")
                {
                    sum = budget * 0.30;
                }
                if (season == "summer")
                {
                    place = "Camp";
                }
                if (season == "winter")
                {
                    sum = budget * 0.70;
                }
                if (season == "winter")
                {
                    place = "Hotel";
                }
            }

            if (budget > 100 && budget <= 1000)
            {
                destinations = "Balkans";
            }
            if (destinations == "Balkans")
            {
                if (season == "summer")
                {
                    sum = budget * 0.40;
                }
                if (season == "summer")
                {
                    place = "Camp";
                }
                if (season == "winter")
                {
                    sum = budget * 0.80;
                }
                if (season == "winter")
                {
                    place = "Hotel";
                }
            }

            if (budget > 1000)
                {
                    destinations = "Europe";
                }
            if (destinations == "Europe")
            {
                    if (season == "summer" || season == "winter")
                    {
                        sum = budget * 0.90;
                    }
                    if (destinations == "Europe")
                    {
                        place = "Hotel";
                    }
            }
            
            Console.WriteLine($"Somewhere in {destinations}");
            Console.WriteLine($"{place} - {sum:F2}");
        }
    }
}
