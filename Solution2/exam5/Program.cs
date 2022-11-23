using System;

namespace SalesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\nAvailable Models number [1..10]: ");
            int models = int.Parse(Console.ReadLine());

            int i = 0;

            double avr_rating = 0.0;
            double sales = 0.0;

            do
            {
                //Console.WriteLine("\nEnter a number represents model and rating [32..306]: ");
                int cnt = int.Parse(Console.ReadLine());

                // Check value
                //if (cnt < 32 && cnt > 306)
                //{
                //    //Console.WriteLine("\nOut of range.\nShould be in 32 to 306.");
                //    continue;
               // }

                int _rating = cnt % 10;

                cnt = (cnt - _rating) / 10; // number of computers

                double chance = 0.0;

                switch (_rating)
                {
                    case 2:
                        chance = 0.0;
                        break;
                    case 3:
                        chance = 0.5;
                        break;
                    case 4:
                        chance = 0.70;
                        break;
                    case 5:
                        chance = 0.85;
                        break;
                    case 6:
                        chance = 1.0;
                        break;
                    default:
                        break;
                }

                avr_rating += _rating;
                sales += chance * cnt;

                i++;

            } while (i < models);

            Console.WriteLine("{0:F2}", sales);
            Console.WriteLine("{0:F2}", avr_rating / models);

        }
    }
}
