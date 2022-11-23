using System;

namespace _01cSeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheSerial = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            double timeOfOneEpisode = double.Parse(Console.ReadLine());

            double timeAdsForOneEpisode = timeOfOneEpisode * 0.20;
            double wholeTimeOfOneEpisode = timeOfOneEpisode + timeAdsForOneEpisode;
            double additionalTimeForSpecialEpisodes = seasons * 10;
            double time = wholeTimeOfOneEpisode * episodes * seasons + additionalTimeForSpecialEpisodes;


            Console.WriteLine("Total time needed to watch the {0} series is {1} minutes.", nameOfTheSerial, Math.Floor(time));
        }
    }
}
