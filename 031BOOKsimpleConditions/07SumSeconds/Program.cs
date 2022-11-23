using System;

namespace _07SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstRunner = int.Parse(Console.ReadLine());
            int secondRunner = int.Parse(Console.ReadLine());
            int thirdRunner = int.Parse(Console.ReadLine());

            int seconds = firstRunner + secondRunner + thirdRunner;
            int minutes = 0;

            if (seconds <= 59)
            {
                minutes = 0;
                seconds = seconds;

            }
            else if (seconds > 59 && seconds <= 119)
            {
                minutes = 1;
                seconds = seconds - 60;
            }
            else if (seconds >= 120 && seconds <= 179)
            {
                minutes = 2;
                seconds = seconds - 120;
            }

            if (seconds < 10)
            {
                Console.WriteLine(minutes + ":" + "0" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
        }
    }
}
