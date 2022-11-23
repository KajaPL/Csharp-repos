using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks.Dataflow;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter balance: ");
            double deposit = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter months: ");
            int months = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter interest per year: ");
            double percent = double.Parse(Console.ReadLine());

            deposit += months * (deposit * percent / 1200.0);
         
            Console.WriteLine($"{deposit:f2}");
        }
    }
}
