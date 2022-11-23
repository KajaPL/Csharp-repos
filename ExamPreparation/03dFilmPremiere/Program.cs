using System;

namespace _03dFilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheFilm = Console.ReadLine();
            string additionals = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            int price = 0;
            switch (nameOfTheFilm)
            {
                case "John Wick":
                    if (additionals == "Drink")
                    {
                        price = 12;
                    }
                    else if (additionals == "Popcorn")
                    {
                        price = 15;
                    }
                    else if (additionals == "Menu")
                    {
                        price = 19;
                    }
                    break;
                case "Star Wars":
                    if (additionals == "Drink")
                    {
                        price = 18;
                    }
                    else if (additionals == "Popcorn")
                    {
                        price = 25;
                    }
                    else if (additionals == "Menu")
                    {
                        price = 30;
                    }
                    break;
                case "Jumanji":
                    if (additionals == "Drink")
                    {
                        price = 9;
                    }
                    else if (additionals == "Popcorn")
                    {
                        price = 11;
                    }
                    else if (additionals == "Menu")
                    {
                        price = 14;
                    }
                    break;
            }

            if (nameOfTheFilm == "Star Wars" && tickets >= 4)
            {
                double price1 = tickets * price;
                double price2 = price1 - (price1 * 0.30);
                Console.WriteLine($"Your bill is {price2:F2} leva.");
            }
            else if (nameOfTheFilm == "Jumanji" && tickets == 2)
            {
                double price3 = tickets * price;
                double price4 = price3 - (price3 * 0.15);
                Console.WriteLine($"Your bill is {price4:F2} leva.");
            }
            else
            {
                double price5 = tickets * price;
                Console.WriteLine($"Your bill is {price5:F2} leva.");
            }
        }
    }
}
