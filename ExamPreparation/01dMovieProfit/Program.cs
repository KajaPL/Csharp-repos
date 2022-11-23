using System;

namespace _01dMovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheFilm = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int numberOfTickets = int.Parse(Console.ReadLine());
            double priceOfOneTicket = double.Parse(Console.ReadLine());
            int percentForCinema = int.Parse(Console.ReadLine());

            double priceTicketPerDay = numberOfTickets * priceOfOneTicket;
            double wholeIncome = days * priceTicketPerDay;
            double percent = wholeIncome * percentForCinema / 100;
            double IncomePerFilm = wholeIncome - percent;



            Console.WriteLine($"The profit from the movie {nameOfTheFilm} is {IncomePerFilm:F2} lv.");
        }
    }
}
