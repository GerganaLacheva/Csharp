using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] studentData = command.Split();
                string firstName = studentData[0];
                string lastName = studentData[1];
                int age = int.Parse(studentData[2]);
                string town = studentData[3];

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.Town = town;

                students.Add(student);
                command = Console.ReadLine();
            }

            string townFlag = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.Town == townFlag)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Town { get; set; }
        }
    }
}
//4.Students
//Define a class called Student, which will hold the following information about some students: 
//•	first name
//•	last name
//•	age
//•	home town
//Input / Constraints
//Read information about some students until you receive the "end" command. After that, you will receive a city name.
//Output
//Print the students which are from the given city in the following format: "{firstName} {lastName} is {age} years old."
//Examples

//Input	Output
//John Smith 15 Sofia
//Peter Ivanov 14 Plovdiv
//Linda Bridge 16 Sofia
//Simon Stone 12 Varna
//end
//Sofia	John Smith is 15 years old.
//Linda Bridge is 16 years old.
