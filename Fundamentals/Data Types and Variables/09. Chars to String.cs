using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());
            char input3 = char.Parse(Console.ReadLine());
            Console.WriteLine($"{input1.ToString()}{input2.ToString()}{input3.ToString()}");
        }
    }
}
//9.Chars to String
//Create a program that reads 3 lines of input. On each line, you get a single character. Combine all the characters into one string and print it on the console.
//Examples
//Input	Output
//a
//b
//c	abc
