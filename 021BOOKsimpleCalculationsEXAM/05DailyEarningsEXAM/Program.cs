using System;

namespace _05DailyEarningsEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDays = int.Parse(Console.ReadLine());
            double salaryPerOneDay = double.Parse(Console.ReadLine());
            double change = double.Parse(Console.ReadLine());

            double salaryPerOneMonth = workingDays * salaryPerOneDay;
            double salaryPerOneYear = (salaryPerOneMonth * 12) + (salaryPerOneMonth * 2.5);
            double tax = salaryPerOneYear * 0.25;
             double clearYear = salaryPerOneYear - tax;
            double averagePerOneDay = clearYear / 365;
            double sum1inlevs = averagePerOneDay * change;
                Console.WriteLine($"{sum1inlevs:F2}");
        }
    }
}
