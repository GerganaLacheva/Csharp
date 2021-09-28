using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine(GradeChecker(grade));

            static string GradeChecker(double grade)
            {
                string check = string.Empty;
                if (grade<=2.99)
                {
                    check = "Fail";
                }
                else if (grade<=3.49)
                {
                    check = "Poor";
                }
                else if (grade <= 4.49)
                {
                    check = "Good";
                }
                else if (grade <= 5.49)
                {
                    check = "Very good";
                }
                else
                {
                    check = "Excellent";
                }
                return $"{check}";
            }

        }
    }
}
//2.Grades
//Create a method that receives a grade between 2.00 and 6.00 and prints the corresponding grade definition:
//•	2.00 – 2.99 - "Fail"
//•	3.00 – 3.49 - "Poor"
//•	3.50 – 4.49 - "Good"
//•	4.50 – 5.49 - "Very good"
//•	5.50 – 6.00 - "Excellent"
//Examples
//Input	Output
//3.33	Poor
//4.50	Very good
//2.99	Fail
