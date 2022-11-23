using System;

namespace _04Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double count = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (double i = 0; i < count; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1++;
                }
                else if (num >= 200 && num <= 399)
                {
                    p2++;
                }
                else if (num >= 400 && num <= 599)
                {
                    p3++;
                }
                else if (num >= 600 && num <= 799)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            Console.WriteLine($"{p1 / count * 100:F2}%");
            Console.WriteLine($"{p2 / count * 100:F2}%");
            Console.WriteLine($"{p3 / count * 100:F2}%");
            Console.WriteLine($"{p4 / count * 100:F2}%");
            Console.WriteLine($"{p5 / count * 100:F2}%");
        }
    }
}
