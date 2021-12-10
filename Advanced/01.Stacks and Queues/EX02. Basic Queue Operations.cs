using System;
using System.Collections.Generic;
using System.Linq;

namespace EX02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = commands[0];
            int s = commands[1];
            int x = commands[2];

            Queue<int> queue = new Queue<int>();
            Add(queue, numbers, n);
            Remove(queue,s);
            Check(queue,numbers, x);
            
        }
        static Queue<int> Add(Queue<int> queue, int[] numbers, int command)
        {
            for (int i = 0; i < command; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            return queue;
        }
        static Queue<int> Remove(Queue<int> queue, int command)
        {
            for (int i = 0; i < command; i++)
            {
                queue.Dequeue();
            }
            return queue;
        }
        static void Check(Queue<int> queue, int[] numbers, int command)
        {
            if (queue.Any())
            {
                if (queue.Contains(command))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }

}
//2.Basic Queue Operations
//Play around with a queue. You will be given an integer N representing the number of elements to enqueue (add),
//an integer S representing the number of elements to dequeue (remove) from the queue and finally an integer X,
//an element that you should look for in the queue.If it is, print true on the console.If it’s not print the smallest
//element currently present in the queue.If there are no elements in the sequence, print 0 on the console.
//Examples
//Input     
//5 2 32
//1 13 45 32 4
//
//Output
//true
//
//Comments
//We have to enqueue 5 elements.Then we dequeue 2 of them.Finally, we have to check whether 32 is present in the queue.
//Since it is we print true.
//
//Input
//4 1 666
//666 69 13 420
//
//Output
//13
//
//Input
//3 3 90
//90 0 90
//
//Output
//0
