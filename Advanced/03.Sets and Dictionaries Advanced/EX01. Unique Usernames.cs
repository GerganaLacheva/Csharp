using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                names.Add(input);
            }
            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
//Problem 1.Unique Usernames
//Create a program that reads from the console a sequence of N usernames and keeps a collection only of the unique ones. On the first line, you will be given an integer N. On the next N lines, you will receive one username per line. Print the collection on the console in order of insertion:
//Examples
//Input	
//6
//John
//John
//John
//Peter
//John
//Boy1234	
//
//Output
//John
//Peter
//Boy1234
