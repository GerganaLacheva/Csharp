using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            //55555.67 record
            //3017 distance
            //5.03 timepermeter



            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());
            double delay = Math.Floor(distance / 15) * 12.5;
            double totalTime = distance * timePerMeter + delay;
            if (totalTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                double fail = totalTime - record;
                Console.WriteLine($"No, he failed! He was {fail:f2} seconds slower.");
            }
        }
    }
}
