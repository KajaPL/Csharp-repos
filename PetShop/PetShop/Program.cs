using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double mineDog = double.Parse(Console.ReadLine());
            int neighboursDog = int.Parse(Console.ReadLine());

            float mineDogSum = (float)mineDog * 2.50f;
            float neighboursDogSum = (float)neighboursDog * 4.00f;
            double allSum = mineDogSum + neighboursDogSum;

            Console.WriteLine($"{allSum} lv.");
        }
    }
}