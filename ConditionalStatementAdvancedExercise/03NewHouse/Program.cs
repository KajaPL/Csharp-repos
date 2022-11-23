using System;

namespace _03NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;

            switch (flower)
            {
                case "Roses":
                    price = 5;
                    break;
                case "Dahlias":
                    price = 3.80;
                    break;
                case "Tulips":
                    price = 2.80;
                    break;
                case "Narcissus":
                    price = 3;
                    break;
                case "Gladiolus":
                    price = 2.50;
                    break;
            }

            double totalPrice = quantity * price;

            if (quantity > 80 && flower == "Roses")
            {
                totalPrice = totalPrice - (totalPrice * 0.10);
            }
            else if(quantity > 90 && flower == "Dahlias")
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }
            else if (quantity > 80 && flower == "Tulips")
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }
            else if (quantity < 120 && flower == "Narcissus")
            {
                totalPrice = totalPrice + (totalPrice * 0.15);
            }
            else if (quantity < 80 && flower == "Gladiolus")
            {
                totalPrice = totalPrice + (totalPrice * 0.20);
            }
            if (budget >= totalPrice)
            {
                double sum = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {sum:f2} leva left.");
            }
            else
            {
                double sum = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {sum:f2} leva more.");

            }
        }
    }
}
