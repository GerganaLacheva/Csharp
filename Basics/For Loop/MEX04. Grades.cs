using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tae4.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            
            double totalScores5 = 0;
            double totalScores4 = 0;
            double totalScores3 = 0;
            double totalScores2 = 0;
            double sumScores = 0;

            for (int i = 1; i <= students; i++)
            {

                double scores = double.Parse(Console.ReadLine());

                if (scores >= 5.00 && scores <= 6.00)
                {
                    totalScores5++;
                }
                else if (scores >= 4 && scores <= 4.99)
                {
                    totalScores4++;
                }
                else if (scores >= 3 && scores <= 3.99)
                {
                    totalScores3++;
                }
                if (scores < 3.00)
                {
                    totalScores2++;
                }
                sumScores += scores;
            }
                double conv5 = totalScores5 /students* 100;
                double conv4 = totalScores4 /students* 100;
                double conv3 = totalScores3 /students * 100;
                double conv2 = totalScores2 /students * 100;
                Console.WriteLine($"Top students: {conv5:f2}%");
                Console.WriteLine($"Between 4.00 and 4.99: {conv4:f2}%");
                Console.WriteLine($"Between 3.00 and 3.99: {conv3:f2}%");
                Console.WriteLine($"Fail: {conv2:f2}%");
                Console.WriteLine($"Average: {(sumScores/students):f2}");
        }
    }
}
