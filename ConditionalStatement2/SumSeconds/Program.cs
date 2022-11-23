using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstAthlete = int.Parse(Console.ReadLine());
            int SecondAthlete = int.Parse(Console.ReadLine());
            int ThirdAthlete = int.Parse(Console.ReadLine());

            int totalAthletesTime = FirstAthlete + SecondAthlete + ThirdAthlete;

            int totalAthletesTimeMins = totalAthletesTime / 60;
            int totalAthletesTimeSec = totalAthletesTime % 60;

            if (totalAthletesTimeSec < 10)
            {
                Console.WriteLine($"{totalAthletesTimeMins}:0{totalAthletesTimeSec}");
            }
            else
            {
                Console.WriteLine($"{totalAthletesTimeMins}:{totalAthletesTimeSec}");
            }
        }
    }
}
