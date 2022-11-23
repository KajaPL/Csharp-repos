using System;

namespace _5bFitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            double fitPeople = int.Parse(Console.ReadLine());
            int backFit = 0;
            int chestFit = 0;
            int legsFit = 0;
            int absFit = 0;
            int maxNumOfFitPeople = int.MinValue;
            int shake = 0;
            int bar = 0;

            for (int i = 0; i < fitPeople; i++)
            {
                string fit = Console.ReadLine();
                switch (fit)
                {
                    case "Back":
                        backFit++;
                        if (backFit > maxNumOfFitPeople)
                        {
                            maxNumOfFitPeople = backFit;
                        }
                        break;
                    case "Chest":
                        chestFit++;
                        if (chestFit > maxNumOfFitPeople)
                        {
                            maxNumOfFitPeople = chestFit;
                        }
                        break;
                    case "Legs":
                        legsFit++;
                        if (legsFit > maxNumOfFitPeople)
                        {
                            maxNumOfFitPeople = legsFit;
                        }
                        break;
                    case "Abs":
                        absFit++;
                        if (absFit > maxNumOfFitPeople)
                        {
                            maxNumOfFitPeople = absFit;
                        }
                        break;
                    case "Protein shake":
                        shake++;
                        break;
                    case "Protein bar":
                        bar++;
                        break;
                }
            }

            Console.WriteLine($"{backFit} - back");
            Console.WriteLine($"{chestFit} - chest");
            Console.WriteLine($"{legsFit} - legs");
            Console.WriteLine($"{absFit} - abs");
            Console.WriteLine($"{shake} - protein shake");
            Console.WriteLine($"{bar} - protein bar");
            double peopleWorkut = backFit + chestFit + legsFit + absFit;
            Console.WriteLine($"{peopleWorkut / fitPeople * 100:F2}% - work out");
            double peopleProtein = shake + bar;
            Console.WriteLine($"{peopleProtein / fitPeople * 100:F2}% - protein");

            // Console.WriteLine(maxNumFit);
        }
    }
}
