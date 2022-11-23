using System;

namespace _03cWorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string typeTicket = Console.ReadLine();
            int numOfTickets = int.Parse(Console.ReadLine());
            string picture = Console.ReadLine();
            int pricePicture = 40;
            double price = 0;

            switch (stage)
            {
                case "Quarter final":
                    if (typeTicket == "Standard")
                    {
                        price = 55.50;
                    }
                    if (typeTicket == "Premium")
                    {
                        price = 105.20;
                    }
                    if (typeTicket == "VIP")
                    {
                        price = 118.90;
                    }
                    break;
                case "Semi final":
                    if (typeTicket == "Standard")
                    {
                        price = 75.88;
                    }
                    if (typeTicket == "Premium")
                    {
                        price = 125.22;
                    }
                    if (typeTicket == "VIP")
                    {
                        price = 300.40;
                    }
                    break;
                case "Final":
                    if (typeTicket == "Standard")
                    {
                        price = 110.10;
                    }
                    if (typeTicket == "Premium")
                    {
                        price = 160.66;
                    }
                    if (typeTicket == "VIP")
                    {
                        price = 400;
                    }
                    break;
            }

            double sumForPay = numOfTickets * price;
            if (sumForPay > 4000 && picture == "Y")
            {
                double sumForPay1 = sumForPay - (sumForPay * 0.25);
                Console.WriteLine($"{sumForPay1:F2}");
            }
            else if (sumForPay > 4000 && picture == "N")
            {
                double sumForPay1 = sumForPay - (sumForPay * 0.25);
                Console.WriteLine($"{sumForPay1:F2}");
            }
            else if (sumForPay > 2500 && sumForPay <= 4000 && picture == "Y")
            {
                double sumForPay1 = sumForPay - (sumForPay * 0.10);
                double sumForPay2 = sumForPay1 + (pricePicture * numOfTickets);
                Console.WriteLine($"{sumForPay2:F2}");
            }
            else if (sumForPay > 2500 && sumForPay <= 4000 && picture == "N")
            {
                double sumForPay1 = sumForPay - (sumForPay * 0.10);
                Console.WriteLine($"{sumForPay1:F2}");
            }
            else if (sumForPay <= 2500 && picture == "Y")
            {
                double sumForPay3 = sumForPay + (pricePicture * numOfTickets);
                Console.WriteLine($"{sumForPay3:F2}");
            }
            else if (sumForPay <= 2500 && picture == "N")
            {
                Console.WriteLine($"{sumForPay:F2}");
            }
        }
    }
}
