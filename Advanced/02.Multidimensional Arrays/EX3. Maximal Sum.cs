using System;
using System.Linq;

namespace EX3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[][] matrix = new int[dimensions[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            int maxSum = 0;
            int rowStartIndex = 0;
            int colStartIndex = 0;
            for (int i = 0; i < matrix.Length - 2; i++)
            {
                for (int j = 0; j < matrix[i].Length - 2; j++)
                {
                    int sum = matrix[i][j] + matrix[i][j + 1] + matrix[i][j + 2]
                              + matrix[i + 1][j] + matrix[i + 1][j + 1] + matrix[i + 1][j + 2]
                              + matrix[i + 2][j] + matrix[i + 2][j + 1] + matrix[i + 2][j + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowStartIndex = i;
                        colStartIndex = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int i = rowStartIndex; i <= rowStartIndex + 2; i++)
            {
                for (int j = colStartIndex; j <= colStartIndex + 2; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
//3.Maximal Sum
//Create a program that reads a rectangular integer matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
//Input
//•	On the first line, you will receive the rows N and columns M. On the next N lines you will receive each row with its columns
//Output
//•	Print the elements of the 3 x 3 square as a matrix, along with their sum
//Examples
//Input		
//4 5
//1 5 5 2 4
//2 1 4 14 3
//3 7 11 2 8
//4 8 12 16 4	 	
//
//Output
//Sum = 75
//1 4 14
//7 11 2
//8 12 16
