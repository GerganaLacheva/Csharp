using System;
using System.Linq;


namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] arr2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }

            int sum = arr1.Sum();
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
//7.Equal Arrays
//Read two arrays and determine whether they are identical or not. The arrays are identical if all their elements are equal. If the arrays are identical find the sum of the elements of one of them and print the following message to the console: "Arrays are identical. Sum: {sum}"
//Otherwise, find the first index where the arrays differ and print the following message to the console:  "Arrays are not identical. Found difference at {index} index."
//Examples
//Input	        Output
//10 20 30
//10 20 30	    Arrays are identical. Sum: 60
//1 2 3 4 5
//1 2 4 3 5       Arrays are not identical. Found difference at 2 index
