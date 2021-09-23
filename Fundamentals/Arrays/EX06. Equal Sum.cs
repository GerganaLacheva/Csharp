using System;
using System.Linq;

namespace EX06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            if (input.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                leftSum = input.Take(i).Sum();

                rightSum = input.Skip(i + 1).Sum();

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
//6.Equal Sums
//Write a program that determines if there exists an element in the array such that the sum of the elements on its left is equal to the sum of the elements on its right 
//(there will never be more than 1 element like that). If there are no elements to the left / right, their sum is considered to be 0. 
//Print the index that satisfies the required condition or "no" if there is no such index.
//Examples
//  Input	                    Output	        Comments
//  1 2 3 3	                    2	            At a[2] -> left sum = 3, right sum = 3
//                                              a[0] +a[1] = a[3]
//  1 2                         no              At a[0] -> left sum = 0, right sum = 2
//                                              At a[1] -> left sum = 1, right sum = 0
//                                              No such index exists
//  1	                        0	            At a[0] -> left sum = 0, right sum = 0
//  1 2 3	                    no	            No such index exists
//  10 5 5 99 3 4 2 5 1 1 4	    3	            At a[3] -> left sum = 20, right sum = 20
//                                              a[0] +a[1] + a[2] = a[4] + a[5] + a[6] + a[7] + a[8] + a[9] + a[10]
