using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            var students = new List<Student>();
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArguments = command.Split();
                string firstName = commandArguments[0];
                string lastName = commandArguments[1];
                int age = int.Parse(commandArguments[2]);
                string city = commandArguments[3];

                if (existingSudent(students, firstName, lastName))
                {

                    var student = GetStudent(students, firstName, lastName, age);
                }
                else
                {
                    var student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        City = city,

                    };
                    students.Add(student);
                }
            }
            string filterCity = Console.ReadLine();
            var filteredStudents = students.Where(s => s.City == filterCity).ToList();

            foreach (Student student in filteredStudents)
            {

                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        static bool existingSudent(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName, int age)
        {
            Student existingStudent = null;
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                    existingStudent.Age = age;
                }
            }
            return existingStudent;
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
//5.Students 2.0
//Use the class from the previous problem. If you receive a student, which already exists (first name and last name should be unique) overwrite the information.
//Input	Output
//John Smith 15 Sofia
//Peter Ivanov 14 Plovdiv
//Peter Ivanov 25 Plovdiv
//Linda Bridge 16 Sofia
//Linda Bridge 27 Sofia
//Simon Stone 12 Varna
//end
//Sofia	John Smith is 15 years old.
//Linda Bridge is 27 years old.
