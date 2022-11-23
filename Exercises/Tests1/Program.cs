using System;
using System.Threading;

namespace Tests1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myPassword = "kasa";
            string inputPassword = Console.ReadLine();
            int count = 0;
            while (inputPassword != myPassword)
            {
                count++;
                Console.WriteLine("Wrong password!");
                Console.WriteLine("Try again!");

                if (count > 1)
                {
                    Console.WriteLine("Wait 10 second");
                    for (int i = 10; i > 0; i--)
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine(i + "sec");
                    }
                    
                }
                inputPassword = Console.ReadLine();
            }
            Console.WriteLine("Welcome!");
        }
    }
}
