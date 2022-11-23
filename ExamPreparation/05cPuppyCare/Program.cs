using System;

namespace DogFeeding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nFood quantity in kilos: ");
            int food = int.Parse(Console.ReadLine());

            int sum = 0;

            string str;

            // Convert to grams
            food *= 1000;

            do
            {
                str = Console.ReadLine().ToLower();

                if (int.TryParse(str, out int input))
                {
                    sum += input;
                }


            } while (str != "adopted"); // or even better (str.Equals("adopted"))

            if (sum <= 4000)
            {
                Console.WriteLine("Food is enough! Leftovers: {0} grams.", food - sum);
            }
            else
            {
                Console.WriteLine("Food is not enough. You need {0} grams more.", sum - food); // Could be Math.Abs(food - sum)
            }

        }
    }
}

