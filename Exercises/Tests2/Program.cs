using System;

namespace Tests2
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "NoMoreMoney")
                {
                    break;
                }
                double deposit = double.Parse(input);
                if (deposit <= 0)
                {
                    Console.WriteLine("Invalid operations!");
                    break;
                }
                else
                {
                    balance += deposit;
                    Console.WriteLine($"Increase: {deposit:f2}");
                }
            }
            Console.WriteLine($"Total: {balance:F2}");
        }
    }
}
