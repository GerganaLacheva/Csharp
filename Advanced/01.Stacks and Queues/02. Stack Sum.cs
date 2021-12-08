using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);
            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] tokens = command.Split();

                switch (tokens[0])
                {
                    case "add":
                        stack.Push(int.Parse(tokens[1]));
                        stack.Push(int.Parse(tokens[2]));
                        break;
                    case "remove":
                        int removeElements = int.Parse(tokens[1]);

                        if (stack.Count >= removeElements)
                        {
                            for (int i = 0; i < removeElements; i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                }

                command = Console.ReadLine().ToLower();
            }
            int sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
//2.Stack Sum
//Write program that:
//•	Reads an input of integer numbers and adds them to a stack
//•	Reads commands until "end" is received
//•	Prints the sum of the remaining elements of the stack
//Input
//•	On the first line you will receive an array of integers
//•	On the next lines, until the "end" command is given, you will receive commands – a single command and one or two numbers after the command, depending on what command you are given
//•	If the command is "add", you will always receive exactly two numbers after the command which you need to add in the stack
//•	If the command is "remove", you will always receive exactly one number after the command which represents the count of the numbers you need to remove from the stack. If there are not enough elements skip the command.
//Output
//•	When the command "end" is received, you need to print the sum of the remaining elements in the stack
//Examples
//Input	
//1 2 3 4
//adD 5 6
//REmove 3
//eNd	
//
//Output
//Sum: 6
//
//Input
//3 5 8 4 1 9
//add 19 32
//remove 10
//add 89 22
//remove 4
//remove 3
//end
//
//Output
//Sum: 16
//
//Hints
//•	Use a Stack<int>
//•	Use the methods Push(), Pop()
//•	Commands may be given in mixed case
