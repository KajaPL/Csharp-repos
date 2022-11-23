using System;

namespace _12currencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();


            if (input == "USD")
            {
                amount *= 1.79549;
            }
            else if (input == "EUR")
            {
                amount *= 1.95583;
            }
            else if (input == "GBP")
            {
                amount *= 2.53405;
            }
            else if (input == "BGN")
            {
                amount = amount;
            }

            if (output == "USD")
            {
                amount /= 1.79549;
                Console.WriteLine(Math.Round(amount, 2) + " USD");
            }
            else if (output == "EUR")
            {
                amount /= 1.95583;
                Console.WriteLine(Math.Round(amount, 2) + " EUR");
            }

            else if (output == "GBP")
            {
                amount /= 2.53405;
                Console.WriteLine(Math.Round(amount, 2) + " GBP");
            }

            else if (output == "BGN")
            {
                amount /= 1;
                Console.WriteLine(Math.Round(amount, 2) + " BGN");
            }
            //Console.WriteLine(Math.Round(amount, 2));
        }
    }
}
