using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            Queue<string> queue = new Queue<string>();

            while (input!= "End")
            {
                if (input=="Paid")
                {
                    for (int i = queue.Count - 1; i >= 0; i--)
                    {
                        Console.WriteLine($"{queue.Dequeue()}");
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
//6.Supermarket
//Reads an input consisting of a name and adds it to a queue until "End" is received. If you receive "Paid", print every customer name and empty the queue, otherwise we receive a client and we have to add him to the queue. When we receive "End" we have to print the count of the remaining people in the queue in the format: "{count} people remaining.".

//Examples
//Input	                            Output
//Liam                              Liam
//Noah                              Noah
//James                             James
//Paid                              4 people remaining.
//Oliver
//Lucas
//Logan
//Tiana
//End	
//
//Input	                            Output
//Amelia                            3 people remaining.
//Thomas
//Elias
//End	
