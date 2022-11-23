using System;

namespace _07HotelRoomEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double studioTotalPrice = 0;
            double apartmentTotalPrice = 0;

            if (month == "May" || month == "October")
            {
                studioTotalPrice = days * 50;
                apartmentTotalPrice = days * 65;
                if (days > 7 && days <= 14)
                {
                    studioTotalPrice = studioTotalPrice - (studioTotalPrice * 0.05);
                }
                else if (days > 14)
                {
                    studioTotalPrice = studioTotalPrice - (studioTotalPrice * 0.30);
                }
            }
            else if (month == "June" || month == "September")
            {
                studioTotalPrice = days * 75.20;
                apartmentTotalPrice = days * 68.70;
                if (days > 14 )
                {
                    studioTotalPrice = studioTotalPrice - (studioTotalPrice * 0.20);
                }
            }
            else if (month == "July" || month == "August")
            {
                studioTotalPrice = days * 76;
                apartmentTotalPrice = days * 77;
            }
            if (days > 14)
            {
                apartmentTotalPrice = apartmentTotalPrice - (apartmentTotalPrice * 0.10);
            }
            Console.WriteLine($"Apartment: {apartmentTotalPrice:F2} lv.");
            Console.Write($"Studio: {studioTotalPrice:F2} lv.");
        }
    }
}
