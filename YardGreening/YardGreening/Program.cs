using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double green = double.Parse(Console.ReadLine());

            double total = green * 7.61;
            double discount = 0.18 * total;
            double sum = total - discount;
 
            Console.WriteLine($"The final price is: {sum:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");

        }
    }
}
