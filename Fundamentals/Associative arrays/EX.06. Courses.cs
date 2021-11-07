using System;
using System.Collections.Generic;
using System.Linq;

namespace EX06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (command != "end")
            {
                string[] commandArguments = command.Split(':');
                string courseName = commandArguments[0];
                string studentName = commandArguments[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(studentName);

                command = Console.ReadLine();
            }
            foreach (var course in courses.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{course.Key.Trim()}: {course.Value.Count}");

                foreach (var item in course.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"--{item}");
                }
            }
        }
    }
}
//6.Courses
//Create a program that keeps the information about courses. Each course has a name and registered students.
//You will be receiving a course name and a student name until you receive the command "end". Check if such a course already exists, and if not, add the course. Register the user into the course. When you receive the command "end", print the courses with their names and total registered users, ordered by the count of registered users in descending order. For each contest print, the registered users ordered by name in ascending order.
//Input
//•	Until the "end" command is received, you will be receiving input in the format: "{courseName} : {studentName}".
//•	The product data is always delimited by " : ".
//Output
//•	Print the information about each course in the following the format: 
//"{courseName}: {registeredStudents}"
//•	Print the information about each student, in the following the format:
//"-- {studentName}"
//Examples
//Input	
//Programming Fundamentals : John Smith
//Programming Fundamentals : Linda Johnson
//JS Core : Will Wilson
//Java Advanced : Harrison White
//end	
//
//Output
//Programming Fundamentals: 2
//-- John Smith
//-- Linda Johnson
//JS Core: 1
//-- Will Wilson
//Java Advanced: 1
//-- Harrison White
