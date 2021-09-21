using System;

namespace _01._Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {averageGrade:f2}");
        }
    }
}

//1.Student Information
//Create a program that receives 3 lines of input:
//•	student name 
//•	age
//•	average grade. 
//Your task is to print all the info about the student in the following format: "Name: {student name}, Age: {student age}, Grade: {student grade}".
//Examples
//Input	Output
//John
//15
//5.40	Name: John, Age: 15, Grade: 5.40
//Steve
//16
//2.50    Name: Steve, Age: 16, Grade: 2.50
//Marry
//12
//6.00    Name: Marry, Age: 12, Grade: 6.00

