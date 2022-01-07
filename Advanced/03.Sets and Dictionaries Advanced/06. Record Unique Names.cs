using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqueNames = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                uniqueNames.Add(name);
            }

            foreach (var item in uniqueNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
//6.Record Unique Names
//Create a program, which will take a list of names and print only the unique names in the list.
//Examples
//Input
//8
//John
//Alex
//John
//Sam
//Alex
//Alice
//Peter
//Alex

//Output
//John
//Alex
//Sam
//Alice
//Peter
