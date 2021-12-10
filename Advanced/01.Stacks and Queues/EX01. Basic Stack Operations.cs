using System;
using System.Collections.Generic;
using System.Linq;

namespace EX01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < commands[0]; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < commands[1]; i++)
            {
                stack.Pop();
            }
            if (stack.Any())    //проверява дали изобщо има нещо в нашия стек
            {
                if (stack.Contains(commands[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
//1.Basic Stack Operations
//Play around with a stack. You will be given an integer N representing the number of elements to push into the stack,
//an integer S representing the number of elements to pop from the stack and finally an integer X, an element that you
//should look for in the stack. If it’s found, print "true" on the console. If it isn't, print the smallest element
//currently present in the stack. If there are no elements in the sequence, print 0 on the console.
//Input
//•	On the first line you will be given N, S and X, separated by a single space
//•	On the next line you will be given N number of integers
//Output
//•	On a single line print either true if X is present in the stack, otherwise print the smallest element in the stack.
//If the stack is empty, print 0
//Examples
//Input		
//5 2 13
//1 13 45 32 4	
//
//Output
//true	
//
//Comments
//We have to push 5 elements. Then we pop 2 of them. Finally, we have to check whether 13 is present in the stack.
//Since it is we print true.
//
//Input
//4 1 666
//420 69 13 666	
//
//Output
//13	
