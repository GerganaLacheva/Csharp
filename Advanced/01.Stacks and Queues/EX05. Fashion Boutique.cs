using System;
using System.Collections.Generic;
using System.Linq;

namespace EX05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(clothes);
            int rackCapacity = int.Parse(Console.ReadLine());

            int sum = 0;
            int rackCount = 1;

            while (stack.Count > 0)
            {
                sum += stack.Peek();
                if (sum <= rackCapacity)
                {
                    stack.Pop();
                }
                else
                {
                    rackCount++;
                    sum = 0;
                }

            }
            Console.WriteLine(rackCount);
        }
    }
}
//5.Fashion Boutique
//You own a fashion boutique and you receive a delivery once a month in a huge box, which is full of clothes. You have to arrange
//them in your store, so you take the box and start from the last piece of clothing on the top of the pile to the first one at the
//bottom. Use a stack for the purpose. Each piece of clothing has its value (an integer). You have to sum their values, while you
//take them out of the box. You will be given an integer representing the capacity of a rack. While the sum of the clothes is less
//than the capacity, keep summing them. If the sum becomes equal to the capacity you have to take a new rack for the next clothes,
//if there are any left in the box.If it becomes greater than the capacity, don't add the piece of clothing to the current rack
//and take a new one. In the end, print how many racks you have used to hang all of the clothes.
//Input
//•	On the first line you will be given a sequence of integers, representing the clothes in the box, separated by a single space
//•	On the second line, you will be given an integer, representing the capacity of a rack
//Output
//•	Print the number of racks, needed to hang all of the clothes from the box
//Constraints
//•	The values of the clothes will be integers in the range [0,20]
//•	There will never be more than 50 clothes in a box
//•	The capacity will be an integer in the range [0,20]
//•	None of the integers from the box will be greater than then the value of the capacity
//Examples
//Input                                 Output
//5 4 8 6 3 8 7 7 9
//16	                                5
//Input                                 Output
//1 7 8 2 5 4 7 8 9 6 3 2 5 4 6
//20	                                5
