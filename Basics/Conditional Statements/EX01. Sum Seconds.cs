using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int compet1 = int.Parse(Console.ReadLine());
            //    int compet2 = int.Parse(Console.ReadLine());
            //    int compet3 = int.Parse(Console.ReadLine());

            //    int totalTime = 0;

            //    totalTime = compet1 + compet2 + compet3;

            //    int minutes = 0;
            //    int seconds = 0;

            //    if (totalTime >= 120)
            //    {
            //        minutes = 2;
            //        seconds = totalTime - 120;
            //    }
            //    else if (totalTime >= 60)
            //    {
            //        minutes = 1;
            //        seconds = totalTime - 60;
            //    }

            //    else
            //    {
            //        seconds = totalTime;
            //    }

            //    Console.WriteLine($"{minutes}:{seconds:d2}");

            int totalTime = 0;
            totalTime += int.Parse(Console.ReadLine());
            totalTime += int.Parse(Console.ReadLine());
            totalTime += int.Parse(Console.ReadLine());

            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            Console.WriteLine($"{minutes}:{seconds:d2}");
        }

    }
}
