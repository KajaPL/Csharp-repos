using System;

namespace _03bGymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string sport = Console.ReadLine();
            double sum = 0;

            switch (country)
            {
                case "Russia":
                    if (sport == "ribbon")
                    {
                        sum = 9.100 + 9.400;
                    }
                    else if (sport == "hoop")
                    {
                        sum = 9.300 + 9.800;
                    }
                    else if (sport == "rope")
                    {
                        sum = 9.600 + 9.000;
                    }
                    break;
                case "Bulgaria":
                    if (sport == "ribbon")
                    {
                        sum = 9.600 + 9.400;
                    }
                    else if (sport == "hoop")
                    {
                        sum = 9.550 + 9.750;
                    }
                    else if (sport == "rope")
                    {
                        sum = 9.500 + 9.400;
                    }
                    break;
                case "Italy":
                    if (sport == "ribbon")
                    {
                        sum = 9.200 + 9.500;
                    }
                    else if (sport == "hoop")
                    {
                        sum = 9.450 + 9.350;
                    }
                    else if (sport == "rope")
                    {
                        sum = 9.700 + 9.150;
                    }
                    break;
            }
            Console.WriteLine($"The team of {country} get {sum:f3} on {sport}.");
            double sum1 = 20 - sum;
            double sum2 = (sum1 / 20) * 100;
           Console.WriteLine($"{sum2:f2}%");
        }
    }
}
