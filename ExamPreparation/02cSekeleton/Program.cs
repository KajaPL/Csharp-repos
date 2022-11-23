using System;

namespace _02cSekeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            double minutesControl = double.Parse(Console.ReadLine());
            double secondsControl = double.Parse(Console.ReadLine());
            double hiveLong = double.Parse(Console.ReadLine());
            double secondsFor100meters = double.Parse(Console.ReadLine());

            double sumSecondsControl = minutesControl * 60 + secondsControl;
            double sumSlower = hiveLong / 120;
            double totalSlow = sumSlower * 2.5;
            double timeMarin = (hiveLong / 100) * secondsFor100meters - totalSlow;
            
            if (timeMarin <= sumSecondsControl)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {timeMarin:f3}.");
            }
            else
            {
                double sum4 = timeMarin - sumSecondsControl;
                Console.WriteLine("No, Marin failed! He was {0:F3} second slower.", sum4);
            }

        }
    }
}
