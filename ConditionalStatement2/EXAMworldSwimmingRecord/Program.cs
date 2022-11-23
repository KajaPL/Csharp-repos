using System;

namespace EXAMworldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double SecondsForOneMeter = double.Parse(Console.ReadLine());

            double swim1 = meters * SecondsForOneMeter;
            double swim2 = Math.Floor(meters / 15) * 12.5;
            double swim3 = swim1 + swim2;
            


            if (swim3 < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {swim3:F2} seconds.");

                
            }
            else
            {
                double swimAll = swim3 - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {swimAll:F2} seconds slower.");
            }    
        }
    }
}