using System;
using System.Linq;

namespace _05_login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Concat(username.Reverse());

            bool isLoggedIn = false;
            bool isBlocked = false;
            int attemptCounter = 0;

            while (!isLoggedIn && !isBlocked)
            {
                string inputPassword = Console.ReadLine();
                if (inputPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    isLoggedIn = true;
                }
                else
                {
                    attemptCounter += 1;
                    if (attemptCounter == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        isBlocked = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                    
                }
            }
        }
    }
}
