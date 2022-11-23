using System;

namespace _11_multiplication_table_2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = int.Parse(Console.ReadLine());
            // int y = int.Parse(Console.ReadLine());


            //  for (int x = 1; x <= 10; x++)
            //  {
            //       for (int y = 1; y <= 10; y++)
            //      {
            //           int product = x * y;
            //           Console.WriteLine($"{x} * {y} = {product}");
            //       }
            //   }
            var number = byte.Parse(Console.ReadLine());
            var multiplier = byte.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
                multiplier++;
            } while (multiplier <= 10);
        }
    }
}
