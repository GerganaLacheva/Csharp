using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());
            int overtimeWorkers = int.Parse(Console.ReadLine());

            double effectiveWorkingHours = Math.Floor(workingDays * 0.9 * 8 + overtimeWorkers * 2 * workingDays);

            if (effectiveWorkingHours>=hoursNeeded)
            {
                Console.WriteLine($"Yes!{effectiveWorkingHours-hoursNeeded} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{hoursNeeded-effectiveWorkingHours} hours needed.");
            }
        }
    }
}
