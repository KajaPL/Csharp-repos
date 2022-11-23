using System;

namespace _04aEasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsNumber = int.Parse(Console.ReadLine());
            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
            int maxNumEggs = int.MinValue;
            string maxNumEggsColor = "";

            for (int i = 0; i < eggsNumber; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        redEggs++;
                        if (redEggs > maxNumEggs)
                        {
                            maxNumEggs = redEggs;
                            maxNumEggsColor = "red";
                        }
                        break;
                    case "orange":
                        orangeEggs++;
                        if (orangeEggs > maxNumEggs)
                        {
                            maxNumEggs = orangeEggs;
                            maxNumEggsColor = "orange";
                        }
                        break;
                    case "blue":
                        blueEggs++;
                        if (blueEggs > maxNumEggs)
                        {
                            maxNumEggs = blueEggs;
                            maxNumEggsColor = "blue";
                        }
                        break;
                    case "green":
                        greenEggs++;
                        if (greenEggs > maxNumEggs)
                        {
                            maxNumEggs = greenEggs;
                            maxNumEggsColor = "green";
                        }
                        break;
                }
            }
            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            Console.WriteLine($"Max eggs: {maxNumEggs} -> {maxNumEggsColor}");
        }
    }
}
