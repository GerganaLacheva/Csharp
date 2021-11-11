using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06.Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    Console.Write(input[i]);
                }
            }
            Console.Write(input[input.Length-1]);
        }
    }
}
//Replace Repeating Chars
//Create a program that reads a string from the console and replaces any sequence of the same letters with a single corresponding letter.
//Examples
//Input	                    Output
//aaaaabbbbbcdddeeeedssaa	abcdedsa
//qqqwerqwecccwd	        qwerqwecwd
