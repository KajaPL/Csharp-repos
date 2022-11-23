using System;

namespace _04SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            bool yes = false;
            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int j = firstNum; j <= secondNum; j++)
                {
                    counter++;
                    if (i + j == magicNum)
                    {
                        yes = true;
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNum})");
                        return;
                    }
                }
            }
            if (!yes)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }

        }
    }
}
