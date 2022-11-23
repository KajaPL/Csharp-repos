using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            double pages = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double allTime = numberOfPages / pages;

            double hours = allTime / days;

            Console.WriteLine($"{hours:f2}");
        }
    }
}
