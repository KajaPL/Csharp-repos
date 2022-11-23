using System;

namespace _03eComputerRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int hoursSpent = int.Parse(Console.ReadLine());
            int peopleInGroup = int.Parse(Console.ReadLine());
            string periodOfTheDay = Console.ReadLine();
            double price = 0;

            switch (month)
            {
                case "march":
                case "mpril":
                case "may":
                    if (periodOfTheDay == "day")
                    {
                        price = 10.50;
                    }
                    else if (periodOfTheDay == "night")
                    {
                        price = 8.4;
                    }
                    break;
                case "june":
                case "july":
                case "august":
                    if (periodOfTheDay == "day")
                    {
                        price = 12.60;
                    }
                    else if (periodOfTheDay == "night")
                    {
                        price = 10.20;
                    }
                    break;
            }

            if (peopleInGroup >= 4)
            {
                if (hoursSpent >= 5)
                {
                    double sum1 = price - (price * 0.10);
                    double sum2 = sum1 - (sum1 * 0.50);
                    double sum3 = sum2 * peopleInGroup * hoursSpent;
                    Console.WriteLine($"Price per person for one hour: {sum2:F2}");
                    Console.WriteLine($"Total cost of the visit: {sum3:F2}");
                }
                else
                {
                    double sum4 = price - (price * 0.10);
                    double sum5 = sum4 * peopleInGroup * hoursSpent;
                    Console.WriteLine($"Price per person for one hour: {sum4:F2}");
                    Console.WriteLine($"Total cost of the visit: {sum5:F2}");
                }

            }

            else
            {
                if (hoursSpent >= 5)
                {
                    double sum6 = price - (price * 0.50);
                    double sum7 = sum6 * peopleInGroup * hoursSpent;
                    Console.WriteLine($"Price per person for one hour: {sum6:F2}");
                    Console.WriteLine($"Total cost of the visit: {sum7:F2}");
                }
                else
                {
                    double sum = price * hoursSpent;
                    double sum1 = sum * peopleInGroup;
                    Console.WriteLine($"Price per person for one hour: {price:F2}");
                    Console.WriteLine($"Total cost of the visit: {sum1:F2}");
                }
            }
        }
    }
}
