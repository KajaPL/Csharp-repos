﻿using System;

namespace _10OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 1; i <= count; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += currNum;
                }
                else
                {
                    oddSum += currNum;    
                }

            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                int diff = 0;
                if (evenSum < oddSum)
                {
                    diff = oddSum - evenSum;
                }
                else
                {
                    diff = evenSum - oddSum;
                }
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
            
        }
    }
}
