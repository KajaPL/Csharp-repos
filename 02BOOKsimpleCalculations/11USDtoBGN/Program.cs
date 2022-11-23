using System;

namespace _11USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var dol = double.Parse(Console.ReadLine());
            var lev = dol * 1.79549;
            Console.WriteLine(Math.Round(lev, 2));
        }
    }
}
