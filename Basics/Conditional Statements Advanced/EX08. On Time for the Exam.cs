using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t08.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minutesOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minutesOfArrival = int.Parse(Console.ReadLine());

            int timeOfExam = (hourOfExam * 60) + minutesOfExam;
            int timeOfArrival = (hourOfArrival * 60) + minutesOfArrival;

            if (timeOfArrival < (timeOfExam - 30))
            {
                Console.WriteLine("Early");
                if (timeOfExam >= timeOfArrival + 60)
                {
                    Console.WriteLine("{0}:{1:D2} hours before the start", ((timeOfExam - timeOfArrival) / 60), ((timeOfExam - timeOfArrival) % 60));
                }
                else
                {
                    Console.WriteLine("{0} minutes before the start", (timeOfExam - timeOfArrival));
                }
            }
            else if (timeOfArrival >= timeOfExam - 30 && timeOfArrival <= timeOfExam)
            {
                Console.WriteLine("On time");
                if ((timeOfExam - timeOfArrival) >= 1)
                {
                    Console.WriteLine("{0} minutes before the start", (timeOfExam - timeOfArrival));
                }
            }
            else if (timeOfArrival > timeOfExam)
            {
                Console.WriteLine("Late");
                if (timeOfArrival >= timeOfExam + 60)
                {
                    Console.WriteLine("{0}:{1:D2} hours after the start", ((timeOfArrival - timeOfExam) / 60), ((timeOfArrival - timeOfExam) % 60));
                }
                else
                {
                    Console.WriteLine("{0} minutes after the start", (timeOfArrival - timeOfExam));
                }
            }
        }
    }
}
