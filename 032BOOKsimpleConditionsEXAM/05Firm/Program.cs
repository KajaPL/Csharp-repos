using System;

namespace _05Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int projectHours = int.Parse(Console.ReadLine());
            int availableDays = int.Parse(Console.ReadLine());
            int overtimeWorkers = int.Parse(Console.ReadLine());


            //double workdays = availableDays * 0.90;
            //double overtime = overtimeWorkers * 2 * availableDays;
            //double workHours = workdays * 8 * overtime;
            //double totalHours = Math.Floor(overtime + workHours);

           double workdays = availableDays * 0.9;
            double workfirm = workdays * 8 * overtimeWorkers;
            double overtime = overtimeWorkers * 2 * workdays;
            double total = Math.Floor(workfirm + overtime);


            if (projectHours <= total)
            {
                Console.WriteLine($"Yes!{total - projectHours} hours left.");
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Ceiling(projectHours - total));
            }
        }
    }
}