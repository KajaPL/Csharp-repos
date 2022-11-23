using System;

namespace _03fFootballSouvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string souvenir = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double price = 0;
            switch (team)
            {
                case "Argentina":
                    if (souvenir == "flags")
                    {
                        price = 3.25;
                    }
                    else if (souvenir == "caps")
                    {
                        price = 7.20;
                    }
                    else if (souvenir == "posters")
                    {
                        price = 5.10;
                    }
                    else if (souvenir == "stickers")
                    {
                        price = 1.25;
                    }
                    break;
                case "Brazil":
                    if (souvenir == "flags")
                    {
                        price = 4.20;
                    }
                    else if (souvenir == "caps")
                    {
                        price = 8.50;
                    }
                    else if (souvenir == "posters")
                    {
                        price = 5.35;
                    }
                    else if (souvenir == "stickers")
                    {
                        price = 1.20;
                    }
                    break;
                case "Croatia":
                    if (souvenir == "flags")
                    {
                        price = 2.75;
                    }
                    else if (souvenir == "caps")
                    {
                        price = 6.90;
                    }
                    else if (souvenir == "posters")
                    {
                        price = 4.95;
                    }
                    else if (souvenir == "stickers")
                    {
                        price = 1.10;
                    }
                    break;
                case "Denmark":
                    if (souvenir == "flags")
                    {
                        price = 3.10;
                    }
                    else if (souvenir == "caps")
                    {
                        price = 6.50;
                    }
                    else if (souvenir == "posters")
                    {
                        price = 4.80;
                    }
                    else if (souvenir == "stickers")
                    {
                        price = 0.90;
                    }
                    break;
            }
            if (team == "Brazil")
            {
                if (souvenir == "flags" || souvenir == "stickers" || souvenir == "posters" || souvenir == "caps")
                {
                    double sum = price * count;
                    Console.WriteLine($"Pepi bought {count} {souvenir} of {team} for {sum:F2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }

            }
            else if (team == "Argentina")
            {
                if (souvenir == "flags" || souvenir == "stickers" || souvenir == "posters" || souvenir == "caps")
                {
                    double sum = price * count;
                    Console.WriteLine($"Pepi bought {count} {souvenir} of {team} for {sum:F2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }

            }
            else if (team == "Croatia")
            {
                if (souvenir == "flags" || souvenir == "stickers" || souvenir == "posters" || souvenir == "caps")
                {
                    double sum = price * count;
                    Console.WriteLine($"Pepi bought {count} {souvenir} of {team} for {sum:F2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }

            }
            else if (team == "Denmark")
            {
                if (souvenir == "flags" || souvenir == "stickers" || souvenir == "posters" || souvenir == "caps")
                {
                    double sum = price * count;
                    Console.WriteLine($"Pepi bought {count} {souvenir} of {team} for {sum:F2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }

            }
            else
            {
                Console.WriteLine("Invalid country!");
            }
        }
    }
}
//            else if (souvenir != "flags" || souvenir != "caps" || souvenir != "posters" || souvenir != "stickers")
//            if (team != "Argentina" || team != "Brazil" || team != "Croatia" || team != "Denmark")