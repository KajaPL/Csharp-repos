using System;

namespace _04MoneyEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bitcoins = int.Parse(Console.ReadLine());
            decimal yuan = decimal.Parse(Console.ReadLine());
            decimal commision = decimal.Parse(Console.ReadLine());

            decimal bitcoinsToLeva = bitcoins * 1168;
            decimal yuanToDollars = yuan * 0.15m;
            decimal dollarsToLeva = yuanToDollars * 1.76m;

            decimal allSum1 = bitcoinsToLeva + dollarsToLeva;
            decimal allSum2 = allSum1 / 1.95m;
            decimal commisionSum = allSum2 * (commision / 100);
            decimal result = allSum2 - commisionSum;

            Console.WriteLine(result);
        }
    }
