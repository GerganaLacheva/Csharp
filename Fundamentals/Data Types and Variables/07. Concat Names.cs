using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string name3 = Console.ReadLine();
            Console.WriteLine($"{name1}{name3}{name2}");

        }
    }
}
//7.Concat Names
//Read two names and a delimiter. Print the names joined by the delimiter.
//Examples
//Input	Output
//John
//Smith
//->	John->Smith
