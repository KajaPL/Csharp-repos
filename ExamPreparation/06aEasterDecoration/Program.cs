using System;

namespace _06aEasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());
            double average = 0;
            for (int i = 0; i < clients; i++)
            {
                double currentTotal = 0;
                int countOfItems = 0;
                string purchase = Console.ReadLine();
                while (purchase != "Finish")
                {
                    countOfItems++;
                    if (purchase == "basket")
                    {
                        currentTotal += 1.50;
                    }
                    else if (purchase == "wreath")
                    {
                        currentTotal += 3.80;
                    }
                    else if (purchase == "chocolate bunny")
                    {
                        currentTotal += 7;
                    }
                    purchase = Console.ReadLine();
                }
                if (countOfItems % 2 == 0)
                {
                    currentTotal -= currentTotal * 0.20;
                }
                average += currentTotal;
                Console.WriteLine($"You purchased {countOfItems} items for {currentTotal:F2} leva.");
            }
            Console.WriteLine($"Average bill per client is: {average / clients:F2} leva.");
        }
    }
}
