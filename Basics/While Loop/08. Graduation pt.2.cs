using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т08.GraduationPt._2
{
    class Program
    {
        static void Main()
        {

            

            string name = Console.ReadLine();
            int schoolYear = 1;
            int fails = 1;
            double totalScore = 0;

            while (schoolYear<=12)
            {
                double yearScore = double.Parse(Console.ReadLine());
                totalScore += yearScore;

                if (yearScore<4)
                {
                    if (fails>1)
                    {
                        break;
                    }
                    fails++;
                    continue;
                }

                schoolYear++;
            }

            if (schoolYear>12)
            {
            Console.WriteLine($"{name} graduated. Average grade: {totalScore/12:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {schoolYear} grade");
            }


        }
    }
}
