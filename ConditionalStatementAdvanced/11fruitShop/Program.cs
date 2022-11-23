using System;

namespace _11fruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    price = 2.50;
                    double sum = price * quantity;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "apple")
                {
                    price = 1.20;
                    double sum = price * quantity;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "orange")
                {
                    price = 0.85;
                    double sum = price * quantity;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45;
                    double sum = price * quantity;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "kiwi")
                {
                    price = 2.70;
                    double sum = price * quantity;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "pineapple")
                {
                    price = 5.50;
                    double sum = price * quantity;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "grapes")
                {
                    price = 3.85;
                    double sum = price * quantity;
                    Console.WriteLine($"{sum:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }


            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    price = 2.70;
                    double sum = price * quantity;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "apple")
                {
                    price = 1.25;
                    double sum = price * quantity;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "orange")
                {
                    price = 0.90;
                    double sum = price * quantity;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.60;
                    double sum = price * quantity;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "kiwi")
                {
                    price = 3.00;
                    double sum = price * quantity;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "pineapple")
                {
                    price = 5.60;
                    double sum = price * quantity;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "grapes")
                {
                    price = 4.20;
                    double sum = price * quantity;
                    Console.WriteLine($"{sum:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
