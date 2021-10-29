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

                Student student = new Student();            //създаваме си нов студент и му записваме свойствата
                student.Name = name;                        //това замества използването на конструктор
                student.ID = id;                            //
                student.Age = age;                          //

                students.Add(student);                      //добавяме новия студент към листа


                input = Console.ReadLine();
            }

            for (int i = 0; i < students.Count; i++)        //сортировка със Selection Sort
            {
                int minIndex = i;

                for (int j = i; j < students.Count; j++)
                {
                    if (students[j].Age < students[minIndex].Age)   //ако г. на текущия студент, който сме намерили, е по-малък от първоначално намерения
                    {
                        minIndex = j;                               //презаписваме първоначално намерения с текущо намерения
                    }
                }

                Student temp = students[minIndex];                  //суапваме ги
                students[minIndex] = students[i];
                students[i] = temp;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} with ID: {student.ID} is {student.Age} years old.");
            }
        }
        class Student
        {
            public string Name { get; set; }

            public string ID { get; set; }

            public int Age { get; set; }
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
