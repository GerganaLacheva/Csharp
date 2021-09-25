using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentInput = arr[i];
                
                if (currentInput%2==0)
                {
                    sumEven += currentInput;
                }
                else if (currentInput % 2 == 1)
                {
                    sumOdd += currentInput;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(sumEven-sumOdd);
        }
    }
}
//6.Even and Odd Subtraction
//Create a program that calculates the difference between the sum of the even and the sum of the odd numbers in an array.
//Examples
//Input	            Output	        Comments
//1 2 3 4 5 6	        3	            Even: 2 + 4 + 6 = 12
//                                    Odd: 1 + 3 + 5 = 9
//                                    Result: 12 – 9 = 3

