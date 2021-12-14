using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = arr[j];

                    if (i == j)
                    {
                        sum += arr[j];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
//3.Primary Diagonal
//Create a program that finds the sum of matrix primary diagonal.
 
//Input
//•	On the first line, you are given the integer N – the size of the square matrix
//•	The next N lines holds the values for every row – N numbers separated by a space
//Examples
//Input	            Output
//3
//11  2   4
//4   5   6
//10  8  -12	    4


