using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace te04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();

            int scoreCount = 0;
            double totalScoresCount = 0;

            while (presentationName != "Finish")
            {
                double sumOfScores = 0;
                for (int i = 1; i <= juryCount; i++)
                {
                    double score = double.Parse(Console.ReadLine());
                    sumOfScores += score;
                    scoreCount++;
                    totalScoresCount += score;
                }
                double average = sumOfScores / juryCount;
                Console.WriteLine($"{presentationName} - {average:f2}.");
                presentationName = Console.ReadLine();
            }
            double finalAverageScore = totalScoresCount / scoreCount;
            Console.WriteLine($"Student's final assessment is {finalAverageScore:f2}.");
        }
    }
}
