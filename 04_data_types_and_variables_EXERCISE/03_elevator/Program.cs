using System;

namespace _03_elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            var courses = Math.Ceiling((double)peopleCount / capacity);
            Console.WriteLine(courses);
        }
    }
}
