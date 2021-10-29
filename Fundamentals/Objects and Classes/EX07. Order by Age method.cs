using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07.Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] splitted = input.Split();
                string name = splitted[0];
                string id = splitted[1];
                int age = int.Parse(splitted[2]);

                Student student = new Student();            
                student.Name = name;                        
                student.ID = id;                            
                student.Age = age;                          

                students.Add(student);                      

                input = Console.ReadLine();
            }

            students = students.OrderBy(student => student.Age).ThenBy(s=>s.Name).ToList(); //ThenBy може да се ползва n-пъти при сортиране по допълнителен критерий

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
        class Student
        {
            public string Name { get; set; }

            public string ID { get; set; }

            public int Age { get; set; }

            public override string ToString()
            {
                return $"{Name} with ID: {ID} is {Age} years old.";
            }
        }
    }
}
//7.Order by Age
//You will receive an unknown number of lines. On each line, you will receive an array with 3 elements. The first element will be of type String and represents the name of the person.  The second element will be of type String and represents the ID of the person.  The last element will be of type integer and represents the age of the person. If you get a person who's ID you have already received before, update the name and age for that ID with that of the new person. When you receive the command "End", print all the people, ordered by age. 
//Examples
//Input	Output
//George 123456 20
//Peter 78911 15
//Stephen 524244 10
//End	Stephen with ID: 524244 is 10 years old.
//Peter with ID: 78911 is 15 years old.
//George with ID: 123456 is 20 years old.
