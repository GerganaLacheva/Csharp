using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t02.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secPerMeter = double.Parse(Console.ReadLine());

            double competitorTime = distance * secPerMeter + (Math.Floor(distance / 50)) * 30;

            if (competitorTime < record)
            {
                Console.WriteLine($"Yes! The new record is {(competitorTime):f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {Math.Abs(record - competitorTime):f2} seconds slower.");
            }
        }
    }
}
