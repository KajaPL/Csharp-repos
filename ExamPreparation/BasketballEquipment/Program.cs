using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double tax = double.Parse(Console.ReadLine());
            double shoes = tax * 0.60;
            double clothes = shoes * 0.80;
            double ball = clothes / 4;
            double acces = ball / 5;
            double sum = tax + shoes + clothes + ball + acces;
            Console.WriteLine($"{sum:F2}");
        }
    }
}
