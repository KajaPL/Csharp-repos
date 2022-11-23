using System;

namespace _07_contact_names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string deli = Console.ReadLine();

            Console.WriteLine($"{firstName}{deli}{lastName}");
        }
    }
}
