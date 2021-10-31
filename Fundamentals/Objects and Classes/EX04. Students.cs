using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] studentData = Console.ReadLine().Split();

                Student student = new Student
                {
                    FirstName = studentData[0],
                    LastName = studentData[1],
                    Grade = double.Parse(studentData[2])
                };

                students.Add(student);
            }

            List<Student> sortedStudent = students.OrderByDescending(x => x.Grade).ToList();

            foreach (var student in sortedStudent)
            {
                Console.WriteLine(student);
            }
        }

        class Student
        {

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public double Grade { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }
        }
    }
}
//4.Students
//Create a program that sorts some students by their grade in descending order. Each student should have a first name (String), the last name (String), and a grade (a floating-point number).
//Input
//•	On the first line, you will receive a number n - the count of all students
//•	On the next n lines, you will be receiving information about these students in the following format:"{first name} {second name} {grade}"
//Output
//•	Print out the information about each student in the following format:"{first name} {second name}: {grade}"
//Example
//Input	Output
//4
//Lakia Eason 3.90
//Prince Messing 5.49
//Akiko Segers 4.85
//Rocco Erben 6.00	Rocco Erben: 6.00
//Prince Messing: 5.49
//Akiko Segers: 4.85
//Lakia Eason: 3.90
