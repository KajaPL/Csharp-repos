using System;

namespace _07MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minNumber = int.MaxValue;
            while (input != "Stop")
            {
                int CurrentNumber = int.Parse(input);
                if (CurrentNumber < minNumber)
                {
                    minNumber = CurrentNumber;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
