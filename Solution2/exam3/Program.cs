using System;

namespace exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            double shipmentWeightKG = double.Parse(Console.ReadLine());
            string typeService = Console.ReadLine();
            int distanceKilometers = int.Parse(Console.ReadLine());
            double price = 0;
            if (shipmentWeightKG < 1)
            {
                price = distanceKilometers * 0.03;
            }
            else if (shipmentWeightKG >= 1 && shipmentWeightKG <= 10)
            {
                price = distanceKilometers * 0.05;
            }
            else if (shipmentWeightKG >= 11 && shipmentWeightKG <= 40)
            {
                price = distanceKilometers * 0.10;
            }
            else if (shipmentWeightKG >= 41 && shipmentWeightKG <= 90)
            {
                price = distanceKilometers * 0.15;
            }
            else if (shipmentWeightKG >= 91 && shipmentWeightKG <= 150)
            {
                price = distanceKilometers * 0.20;
            }
            if (typeService == "express")
            {
                if (shipmentWeightKG < 1)
                {
                    price = price + 0.8 * 0.03 * distanceKilometers * shipmentWeightKG;
                }
                else if (shipmentWeightKG >= 1 && shipmentWeightKG <= 10)
                {
                    price = price + 0.4 * 0.05 * distanceKilometers * shipmentWeightKG;
                }

                else if (shipmentWeightKG >= 11 && shipmentWeightKG <= 40)
                {
                    price = price + 0.05 * 0.10 * distanceKilometers * shipmentWeightKG;
                }

                else if (shipmentWeightKG >= 41 && shipmentWeightKG <= 90)
                {
                    price = price + 0.02 * 0.15 * distanceKilometers * shipmentWeightKG;
                }

                else if (shipmentWeightKG >= 91 && shipmentWeightKG <= 150)
                {
                    price = price + 0.01 * 0.20 * distanceKilometers * shipmentWeightKG;
                }
            }
            Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", shipmentWeightKG, price);
        }
    }
}

