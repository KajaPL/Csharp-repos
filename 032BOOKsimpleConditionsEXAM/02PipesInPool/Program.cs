using System;

namespace _02PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double water = (pipe1 * hours) + (pipe2 * hours);
            if (water <= volume)
            {
                double waterNow = Math.Floor(water / volume * 100);
                double p1Now = Math.Floor(pipe1 * hours / water * 100);
                double p2Now = Math.Floor(pipe2 * hours / water * 100);

                Console.WriteLine($"The pool is {waterNow:F0}% full. Pipe 1: {p1Now:F0}%. Pipe 2: {p2Now:F0}%.");



            }
            else
            {
                double waterMuch = water - volume;
                Console.WriteLine($"For {hours} hours the pool overflows with {waterMuch} liters.");
            }
        }
    }
}



