using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace te02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowScores = int.Parse(Console.ReadLine());
            string excerciseName = Console.ReadLine();
            string lastProblem = "";

            int lowScoresCounter = 0;
            int totalScoresCounter = 0;
            int scoreCounter = 0;

            while (excerciseName != "Enough")
            {
                int score = int.Parse(Console.ReadLine());
                scoreCounter += score;
                totalScoresCounter++;

                if (score <= 4)
                {
                    lowScoresCounter++;
                    if (lowScoresCounter == lowScores)
                    {
                        break;
                    }
                }
                lastProblem = excerciseName;
                excerciseName = Console.ReadLine();
            }
            if (excerciseName == "Enough")
            {
                double averageScore = 1.0 * scoreCounter / totalScoresCounter;
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {totalScoresCounter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {lowScoresCounter} poor grades.");
            }
        }
    }
}
