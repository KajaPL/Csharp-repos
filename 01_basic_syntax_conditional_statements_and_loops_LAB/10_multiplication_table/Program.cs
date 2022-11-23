using System;

namespace _10_multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum1 = number * 1;
            int sum2 = number * 2;
            int sum3 = number * 3;
            int sum4 = number * 4;
            int sum5 = number * 5;
            int sum6 = number * 6;
            int sum7 = number * 7;
            int sum8 = number * 8;
            int sum9 = number * 9;
            int sum10 = number * 10;

            Console.WriteLine($"{number} X 1 = {sum1}");
            Console.WriteLine($"{number} X 2 = {sum2}");
            Console.WriteLine($"{number} X 3 = {sum3}");
            Console.WriteLine($"{number} X 4 = {sum4}");
            Console.WriteLine($"{number} X 5 = {sum5}");
            Console.WriteLine($"{number} X 6 = {sum6}");
            Console.WriteLine($"{number} X 7 = {sum7}");
            Console.WriteLine($"{number} X 8 = {sum8}");
            Console.WriteLine($"{number} X 9 = {sum9}");
            Console.WriteLine($"{number} X 10 = {sum10}");
        }
    }
}
