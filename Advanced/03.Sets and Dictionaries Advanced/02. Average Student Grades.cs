using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentData = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                if (!studentData.ContainsKey(tokens[0]))
                {
                    studentData.Add(tokens[0], new List<decimal>());
                }
                studentData[tokens[0]].Add(decimal.Parse(tokens[1]));
            }
            foreach (var item in studentData)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value.Select(x => x.ToString("F2")))} (avg: {item.Value.Average():f2})");
            }
        }
    }
}
//2.Average Student Grades
//Write a program, which reads a name of a student and his/her grades and adds them to the student record, then prints the student's names with their grades and their average grade.
//Examples
//Input	
//7
//John 5.20
//Maria 5.50
//John 3.20
//Maria 2.50
//Sam 2.00
//Maria 3.46
//Sam 3.00	
//
//Output
//John -> 5.20 3.20 (avg: 4.20)
//Maria-> 5.50 2.50 3.46(avg: 3.82)
//Sam-> 2.00 3.00(avg: 2.50)

