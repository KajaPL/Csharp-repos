using System;

namespace _13skiTripEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rate = Console.ReadLine();

            if (room == "room for one person")
            {
                if (rate == "positive")
                {
                    double sum = (days - 1) * 18.00;
                    double sum1 = sum + (sum * 0.25);
                    Console.WriteLine($"{sum1:f2}");
                }
                else if (rate == "negative")
                {
                    double sum = (days - 1) * 18.00;
                    double sum1 = sum - (sum * 0.10);
                    Console.WriteLine($"{sum1:f2}");
                }
            }
            else if (room == "apartment")
            {
                if (rate == "positive")
                {
                    if (days < 10)
                    {
                        double sum = (days - 1) * 25.00;
                        double sum1 = sum - (sum * 0.30);
                        double sum2 = sum1 + (sum1 * 0.25);
                        Console.WriteLine($"{sum2:f2}");
                    }
                    else if (days >=10 && days < 15)
                    {
                        double sum = (days - 1) * 25.00;
                        double sum1 = sum - (sum * 0.35);
                        double sum2 = sum1 + (sum1 * 0.25);
                        Console.WriteLine($"{sum2:f2}");
                    }
                    else if (days >= 15)
                    {
                        double sum = (days - 1) * 25.00;
                        double sum1 = sum - (sum * 0.50);
                        double sum2 = sum1 + (sum1 * 0.25);
                        Console.WriteLine($"{sum2:f2}");
                    }
                }
                else if (rate == "negative")
                {
                    if (days < 10)
                    {
                        double sum = (days - 1) * 25.00;
                        double sum1 = sum - (sum * 0.30);
                        double sum2 = sum1 - (sum1 * .10);
                        Console.WriteLine($"{sum2:f2}");
                    }
                    else if (days >= 10 && days < 15)
                    {
                        double sum = (days - 1) * 25.00;
                        double sum1 = sum - (sum * 0.35);
                        double sum2 = sum1 - (sum1 * .10);
                        Console.WriteLine($"{sum2:f2}");
                    }
                    else if (days >= 15)
                    {
                        double sum = (days - 1) * 25.00;
                        double sum1 = sum - (sum * 0.50);
                        double sum2 = sum1 - (sum1 * .10);
                        Console.WriteLine($"{sum2:f2}");
                    }
                }
            }
            else if (room == "president apartment")
            {
                if (rate == "positive")
                {
                    if (days < 10)
                    {
                        double sum = (days - 1) * 35.00;
                        double sum1 = sum - (sum * 0.10);
                        double sum2 = sum1 + (sum1 * 0.25);
                        Console.WriteLine($"{sum2:f2}");
                    }
                    else if (days >= 10 && days < 15)
                    {
                        double sum = (days - 1) * 35.00;
                        double sum1 = sum - (sum * 0.15);
                        double sum2 = sum1 + (sum1 * 0.25);
                        Console.WriteLine($"{sum2:f2}");
                    }
                    else if (days >= 15)
                    {
                        double sum = (days - 1) * 35.00;
                        double sum1 = sum - (sum * 0.20);
                        double sum2 = sum1 + (sum1 * 0.25);
                        Console.WriteLine($"{sum2:f2}");
                    }
                }
                else if (rate == "negative")
                {
                    if (days < 10)
                    {
                        double sum = (days - 1) * 35.00;
                        double sum1 = sum - (sum * 0.10);
                        double sum2 = sum1 - (sum1 * .10);
                        Console.WriteLine($"{sum2:f2}");
                    }
                    else if (days >= 10 && days < 15)
                    {
                        double sum = (days - 1) * 35.00;
                        double sum1 = sum - (sum * 0.15);
                        double sum2 = sum1 - (sum1 * .10);
                        Console.WriteLine($"{sum2:f2}");
                    }
                    else if (days >= 15)
                    {
                        double sum = (days - 1) * 35.00;
                        double sum1 = sum - (sum * 0.20);
                        double sum2 = sum1 - (sum1 * .10);
                        Console.WriteLine($"{sum2:f2}");
                    }
                }
            }
        }
    }
}
