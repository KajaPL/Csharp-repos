using System;

namespace _01NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write($"{num++} ");
                    if (num > n)
                    {
                        break;
                    }
                }
                if (num > n)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
