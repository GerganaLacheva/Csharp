using System;
using System.Collections.Generic;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> text = new Stack<string>();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                text.Push(input[i].ToString());
            }
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(text.Pop());
            }
            //while (text.Count > 0)
            //{
            //    Console.Write(text.Pop());
            //}
            //Console.WriteLine();
        }
    }
}
//1.Reverse Strings
//Write program that:
//•	Reads an input string
//•	Reverses it using a Stack< T >
//•	Prints the result back at the terminal
//Examples
//Input	                Output
//I Love C#	            #C evoL I
//Stacks and Queues	    seueuQ dna skcatS
//Hints
//•	Use a Stack<string>
//•	Use the methods Push(), Pop()
