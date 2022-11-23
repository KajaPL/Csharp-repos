using System;

namespace _09_chars_to_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sequence += symbol;
            }

            Console.WriteLine(sequence);
        }
    }
}
