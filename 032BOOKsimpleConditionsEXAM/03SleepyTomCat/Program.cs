using System;

namespace _03SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            var daysOff = int.Parse(Console.ReadLine());
            var daysAtWork = 365 - daysOff;
            var playMins = daysAtWork * 63 + daysOff * 127;
            if (playMins > 30000)
            {
                var difference = playMins - 30000;
                var hours = 0;
                var mins = 0;
                if (difference > 59)
                {
                    hours = difference / 60;
                    mins = difference - (hours * 60);
                }
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, mins);
            }
            else if (playMins <= 30000)
            {
                var difference = 30000 - playMins;
                var hours = 0;
                var mins = 0;
                if (difference > 59)
                {
                    hours = difference / 60;
                    mins = difference - (hours * 60);
                }
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, mins);
            }


        }
    }
}
