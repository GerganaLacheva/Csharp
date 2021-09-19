using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace te04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GOAL = 10000;
            int totalSteps = 0;

            while (totalSteps<GOAL)
            {
                string input = Console.ReadLine();
                if (input=="Going home")
                {
                    int stepsLeft = int.Parse(Console.ReadLine());
                    totalSteps += stepsLeft;
                    break;
                }
                int steps = int.Parse(input);
                totalSteps += steps;
            }
            if (totalSteps>=GOAL)
            {
                Console.WriteLine($"Goal reached! Good job!");
                int extraSteps = totalSteps - GOAL;
                Console.WriteLine($"{extraSteps} steps over the goal!");
            }
            else
            {
                int difference = GOAL - totalSteps;
                Console.WriteLine($"{difference} more steps to reach goal.");
            }

        }
    }
}
