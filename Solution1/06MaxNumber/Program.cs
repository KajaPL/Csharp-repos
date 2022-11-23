using System;

namespace _06MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxNumber = int.MinValue;
            while (input != "Stop")
            {
                int CurrentNumber = int.Parse(input);
                if (CurrentNumber > maxNumber)
                {
                    maxNumber = CurrentNumber;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
