using System;
using System.Linq;
namespace MEX04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = string.Join("", input.Reverse());
            Console.WriteLine(input);
        }
    }
}
//Write a program which reverses a string and print it on the console.
//Examples
//Input	Output
//Hello	olleH
//SoftUni	inUtfoS
//1234	4321
