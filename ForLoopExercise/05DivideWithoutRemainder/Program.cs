using System;

namespace _05DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double count = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            for (double i = 0; i < count; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    p1 += 1;
                }
                if (num % 3 == 0)
                {
                    p2 = p2 + 1;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }
            }
            Console.WriteLine($"{p1 / count * 100:F2}%");
            Console.WriteLine($"{p2 / count * 100:F2}%");
            Console.WriteLine($"{p3 / count * 100:F2}%");
        }
    }
}
