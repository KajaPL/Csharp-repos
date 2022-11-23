using System;

namespace exam6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int left = number;
            int reverse = 0;
            int reverse1 = 0;
            int reverse2 = 0;

            int r = left % 10;
            reverse = reverse + r;
            left = left / 10;

            r = left % 10;
            reverse1 = reverse1 + r;
            left = left / 10;
            r = left % 10;
            reverse2 = reverse2 + r;

            for (int i = 1; i <= reverse; i++)
            {
                for (int y = 1; y <= reverse1; y++)
                {
                    for (int w = 1; w <= reverse2; w++)
                    {
                        Console.WriteLine(i + " " + "*" + " " + y + " " + "*" + " " + w + " " + "=" + " " + i * y * w + ";");
                    }
                }
            }

        }
    }
}
