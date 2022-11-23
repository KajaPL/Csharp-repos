using System;

namespace _03aEasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string days = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            int price = 0;

            switch (destination)
            {
                case "France":
                    if (days == "21-23")
                    {
                        price = 30;
                    }
                    else if (days == "24-27")
                    {
                        price = 35;
                    }
                    else if (days == "28-31")
                    {
                        price = 40;
                    }
                    break;
                case "Italy":
                    if (days == "21-23")
                    {
                        price = 28;
                    }
                    else if (days == "24-27")
                    {
                        price = 32;
                    }
                    else if (days == "28-31")
                    {
                        price = 39;
                    }
                    break;
                case "Germany":
                    if (days == "21-23")
                    {
                        price = 32;
                    }
                    else if (days == "24-27")
                    {
                        price = 37;
                    }
                    else if (days == "28-31")
                    {
                        price = 43;
                    }
                    break;
            }
            double sum = price * nights;
            Console.WriteLine($"Easter trip to {destination} : {sum:F2} leva.");
        }
    }
}
