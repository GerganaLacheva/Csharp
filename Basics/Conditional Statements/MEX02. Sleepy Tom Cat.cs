using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            int workingDays = 365-holidays;
            int minutesHolidayDay = 127;
            int minutesWorkingDay = 63;
            int sleepNorm = 30000;
            int totalPlay = 0;
            totalPlay = holidays * minutesHolidayDay + workingDays * minutesWorkingDay;

            if (totalPlay>sleepNorm)
            {

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{(totalPlay-sleepNorm)/60} hours and {(totalPlay-sleepNorm)%60} minutes more for play");
            }
            else if (totalPlay < sleepNorm)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{(sleepNorm-totalPlay)/60} hours and {(sleepNorm-totalPlay)%60} minutes less for play");
            }
        }
    }
}
