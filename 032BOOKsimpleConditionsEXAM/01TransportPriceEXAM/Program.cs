using System;

namespace _01TransportPriceEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometers = double.Parse(Console.ReadLine());
            string time = Console.ReadLine();


            if (kilometers >= 1 && kilometers < 20)
            {
                if (time == "day")
                {
                    double sum1 = 0.70 + (kilometers * 0.79);
                    Console.WriteLine(sum1);
                }
                else
                {
                    double sum1 = 0.70 + (kilometers * 0.90);
                    Console.WriteLine(sum1);
                }
            }
            else if (kilometers >= 20 && kilometers < 100)
            {
                double sum1 = kilometers * 0.09;
                Console.WriteLine(sum1);
            }
            else if (kilometers >= 100)
            {
                double sum1 = kilometers * 0.06;
                Console.WriteLine($"{sum1:F2}");
            }
        }
    }
}
