using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tae5.Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());
            double score09 = 0;
            double score1019 = 0;
            double score2029 = 0;
            double score3039 = 0;
            double score4050 = 0;
            double scoreInvalid = 0;
            double totalScore = 0;


            for (int i = 0; i < moves; i++)
            {
                double scoreInput = int.Parse(Console.ReadLine());

                if (scoreInput >= 0 && scoreInput <= 9)
                {
                    totalScore += scoreInput*0.20;
                    score09++;

                }
                else if (scoreInput >= 10 && scoreInput <= 19)
                {
                    totalScore += scoreInput * 0.30;
                    score1019++;
                }
                else if (scoreInput >= 20 && scoreInput <= 29)
                {
                    totalScore += scoreInput * 0.40;
                    score2029++;
                }
                else if (scoreInput >= 30 && scoreInput <= 39)
                {
                    totalScore += 50;
                    score3039++;

                }
                else if (scoreInput >= 40 && scoreInput <= 50)
                {
                    totalScore += 100;
                    score4050++;

                }
                else if (scoreInput < 0 || scoreInput > 50)
                {
                    totalScore = totalScore / 2;
                    scoreInvalid++;
                }
                
            }
            Console.WriteLine($"{totalScore:f2}");
            double convScore09 = score09 / moves * 100;
            double convScore1019 = score1019 / moves * 100;
            double convScore2029 = score2029 / moves * 100;
            double convScore3039 = score3039 / moves * 100;
            double convScore4050 = score4050 / moves * 100;
            double convScoreInvalid = scoreInvalid / moves * 100;
            Console.WriteLine($"From 0 to 9: {convScore09:f2}%");
            Console.WriteLine($"From 10 to 19: {convScore1019:f2}%");
            Console.WriteLine($"From 20 to 29: {convScore2029:f2}%");
            Console.WriteLine($"From 30 to 39: {convScore3039:f2}%");
            Console.WriteLine($"From 40 to 50: {convScore4050:f2}%");
            Console.WriteLine($"Invalid numbers: {convScoreInvalid:f2}%");
        }
    }
}
