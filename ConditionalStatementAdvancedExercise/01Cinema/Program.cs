using System;

namespace _01Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFilm = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double sum = 0.0;

            if (typeFilm == "Premiere")
            {
                sum = r * c * 12.00;
            }
            else if (typeFilm == "Normal")
            {
                 sum = r * c * 7.50;
            }
            else if (typeFilm == "Discount")
            {
                sum = r * c * 5.00;
            }
            Console.WriteLine($"{sum:f2} leva");
        }
    }
}
