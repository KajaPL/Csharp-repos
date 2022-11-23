using System;
using System.Diagnostics.CodeAnalysis;

namespace EXAMbirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double cake = (rent / 100) * 20;
            double drinks = (cake / 100) * 55;
            double animations = rent / 3;

            double budget = rent + cake + drinks + animations;

            Console.WriteLine($"{budget:f2}");
        }
    }
}
