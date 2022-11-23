using System;

namespace _02MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 10; x++)
            {
                for (int y = 1; y <= 10; y++)
                {
                    int p = x * y;
                    Console.WriteLine($"{x} * {y} = {p}");
                }
            }
        }
    }
}
