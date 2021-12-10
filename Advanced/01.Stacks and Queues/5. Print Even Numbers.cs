using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> evenNumbers = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(i => i % 2 == 0));

            Console.WriteLine(string.Join(", ", evenNumbers));

            //int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //Queue<int> queue = new Queue<int>();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] % 2 == 0)
            //    {
            //        queue.Enqueue(input[i]);
            //    }
            //}

            //Console.WriteLine(string.Join(", ", queue));
        }
    }
}
//5.Print Even Numbers
//Write program that:
//•	Reads an array of integers and adds them to a queue
//•	Prints the even numbers separated by ", "
//Examples
//Input	
//1 2 3 4 5 6	
//
//Output
//2, 4, 6
//
//Input
//11 13 18 95 2 112 81 46	
//
//Output
//18, 2, 112, 46
