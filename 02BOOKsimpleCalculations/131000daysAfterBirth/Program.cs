using System;

namespace _131000daysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {

            var startingDate = Console.ReadLine();
            var finalDate = DateTime.ParseExact(startingDate, "dd-MM-yyyy", null);
            finalDate = finalDate.AddDays(1000);
            Console.WriteLine(finalDate.ToString("dd-MM-yyyy"));


        }
    }
}