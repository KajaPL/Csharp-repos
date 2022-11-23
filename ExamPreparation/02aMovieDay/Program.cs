using System;

namespace _02aMovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            double timeForMovie = double.Parse(Console.ReadLine());
            double scenes = double.Parse(Console.ReadLine());
            double timeForOneScene = double.Parse(Console.ReadLine());

            double preparation = timeForMovie * 0.15;
            double filmingScenes = scenes * timeForOneScene;
            double sum = preparation + filmingScenes;

            if (sum <= timeForMovie)
            {
                Console.WriteLine("You managed to finish the movie on time! You have {0} minutes left!", Math.Round(timeForMovie - sum));
            }
            else
            {
                Console.WriteLine("Time is up! To complete the movie you need {0} minutes.", Math.Round(sum - timeForMovie));
            }
        }
    }
}
