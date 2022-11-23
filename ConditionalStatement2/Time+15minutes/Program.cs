using System;

namespace Time_15minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeHours = int.Parse(Console.ReadLine());
            int timeMinutes = int.Parse(Console.ReadLine());

            int totalTime = (timeHours * 60) + timeMinutes;
            int totalTime15Mins = totalTime + 15;

            int nowTimeHours = totalTime15Mins / 60;
            int nowTimeMinutes = totalTime15Mins % 60;

            if (nowTimeHours == 24)
            {
                nowTimeHours -= 24;
            }
            if (nowTimeMinutes < 10)
            {
                Console.WriteLine($"{nowTimeHours}:0{nowTimeMinutes}");
            }
            else
            {
                Console.WriteLine($"{nowTimeHours}:{nowTimeMinutes}");
            }
        }
    }
}
