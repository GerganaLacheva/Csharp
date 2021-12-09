using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (input[i] == ')')
                {
                    int index = indexes.Pop();
                    Console.WriteLine(input.Substring(index,i-index+1));
                }
            }
        }
    }
}
//4.Matching Brackets
//We are given an arithmetic expression with brackets. Scan through the string and extract each sub-expression.
//Print the result back at the terminal.

//Examples
//Input	                        
//1 + (2 - (2 + 3) *4 / (3 + 1)) *5
//
//Output
//(2 + 3)
//(3 + 1)
//(2 - (2 + 3) * 4 / (3 + 1))
//
//Input
//(2 + 3) - (2 + 3)
//
//Output
//(2 + 3)
//(2 + 3)
//
//Hints
//•	Scan through the expression searching for brackets
//o	If you find an opening bracket, push the index into the stack
//o	If you find a closing bracket pop the topmost element from the stack. This is the index of the opening bracket.
//o	Use the current and the popped index to extract the sub-expression
