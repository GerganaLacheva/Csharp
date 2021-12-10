using System;
using System.Collections.Generic;
using System.Linq;

namespace EX04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQty = int.Parse(Console.ReadLine());
            int[] orders=Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());

            while (queue.Count > 0)
            {
                if (foodQty >= queue.Peek())
                {
                    foodQty -= queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: { string.Join(" ", queue)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
//4.Fast Food
//You have a fast food restaurant and most of the food that you're offering is previously prepared. You need to know if you will have enough food to serve lunch to all of your customers. Write a program that checks the orders’ quantity. You also want to know the client with the biggest order for the day, because you want to give him a discount the next time he comes. 
//First, you will be given the quantity of the food that you have for the day (an integer number).  Next, you will be given a sequence of integers, each representing the quantity of an order. Keep the orders in a queue. Find the biggest order and print it. You will begin servicing your clients from the first one that came. Before each order, check if you have enough food left to complete it. If you have, remove the order from the queue and reduce the amount of food you have. If you succeeded in servicing all of your clients, print: 
//"Orders complete".
// If not, print:
//"Orders left: {order1} {order2} .... {orderN}".
//Input
//•	On the first line you will be given the quantity of your food - an integer in the range [0, 1000]
//•	On the second line you will receive a sequence of integers, representing each order, separated by a single space
//Output
//•	Print the quantity of biggest order
//•	Print "Orders complete" if the orders are complete
//•	If there are orders left, print them in the format given above
//Constraints
//•	The input will always be valid


//Examples
//Input	                            Output
//348                           	54
//20 54 30 16 7 9                   Orders complete
//
//Input	                            Output
//499                       	    90
//57 45 62 70 33 90 88 76 50       Orders left: 76 50
