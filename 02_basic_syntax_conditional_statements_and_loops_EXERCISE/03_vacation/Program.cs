using System;

namespace _03_vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double discountPercentage = 0;

            if (groupType == "Students")
            {
                if (peopleCount >= 30)
                {
                    discountPercentage = 15;
                }
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if (groupType == "Business")
            {
                if (peopleCount >= 100)
                {
                    peopleCount -= 10;
                }
                if (day == "Friday")
                {
                    price = 10.9;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
            }
            else if (groupType == "Regular")
            {
                if (peopleCount >= 10 && peopleCount <= 20)
                {
                    discountPercentage = 5;
                }
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.5;
                }
            }

            double totalPrice = peopleCount * price;

            if (discountPercentage != 0)
            {
                totalPrice -= totalPrice * discountPercentage / 100;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
