using System;

namespace _02eSpaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double spaceWidth = double.Parse(Console.ReadLine());
            double spaceLenght = double.Parse(Console.ReadLine());
            double spaceHeight = double.Parse(Console.ReadLine());
            double averageHeightOfAstronauts = double.Parse(Console.ReadLine());
            //int astronauts = 0;

            double spaceVolume = spaceWidth * spaceLenght * spaceHeight;
            double roomVolume = (averageHeightOfAstronauts + 0.40) * 2 * 2;
            double freeSpace = spaceVolume / roomVolume;
            if (freeSpace < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (freeSpace >= 3 && freeSpace <= 10)
            {
                Console.WriteLine("The spacecraft holds {0} astronauts.", Math.Floor(freeSpace));
            }
            else if (freeSpace > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }

        }
    }
}
