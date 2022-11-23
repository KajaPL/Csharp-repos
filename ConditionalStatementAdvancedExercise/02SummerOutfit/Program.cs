using System;

namespace _02SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string outfit = " ";
            string shoes = " ";


            if (time == "Morning")
            {
                if (celsius >= 10 && celsius <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (celsius > 18 && celsius <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (celsius >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");
            }
            if (time == "Afternoon")
            {
                if (celsius >= 10 && celsius <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (celsius > 18 && celsius <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (celsius >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");
            }
            else if (time == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
                Console.WriteLine($"It's {celsius} degrees, get your {outfit} and {shoes}.");
            }
        }
    }
}
