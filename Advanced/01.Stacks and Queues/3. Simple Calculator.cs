using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
            Stack<string> calk = new Stack<string>(input);

            while (calk.Count > 1)
            {
                int a = int.Parse(calk.Pop());
                string oper = calk.Pop();
                int b = int.Parse(calk.Pop());

                

                if (oper=="+")
                {
                    calk.Push((a+b).ToString());
                }
                else
                {
                   calk.Push((a-b).ToString());
                }
            }
            Console.WriteLine(calk.Pop());
        }
    }
}
//3.Simple Calculator
//Create a simple calculator that can evaluate simple expressions with only addition and subtraction. There will not be any parentheses.
//Solve the problem using a Stack.
//Examples
//Input	                    Output
//2 + 5 + 10 - 2 - 1	    14
//2 - 2 + 5	                5
//Hints
//•	Use a Stack<string>
//•	You can either
//o	add the elements and then Pop() them out
//o or Push() them and reverse the stack
