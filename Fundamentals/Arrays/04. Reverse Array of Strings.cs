using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split().Reverse().ToArray();
            Console.WriteLine(string.Join(" ", strings));
        }
    }
}
//4.Reverse Array of Strings
//Create a program that reads an array of strings, reverses it, and prints its elements. The input consists of a sequence of space-separated Strings. Print the output on a single line (space separated).
//Examples
//Input	        Output
//a b c d e	    e d c b a
//-1 hi ho w	    w ho hi -1
