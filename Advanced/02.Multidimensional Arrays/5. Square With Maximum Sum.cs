using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = ReadMatrix();
            int[,] matrix = new int[dimensions[0], dimensions[1]];

            for (int i = 0; i < dimensions[0]; i++)
            {
                int[] arr = ReadMatrix();
                for (int j = 0; j < dimensions[1]; j++)
                {
                    matrix[i, j] = arr[j];
                }
            }
            int maxSum = int.MinValue;
            int maxElementRow = 0;
            int maxElementColumn = 0;

            for (int i = 0; i < dimensions[0] - 1; i++)
            {
                for (int j = 0; j < dimensions[1] - 1; j++)
                {
                    int currSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxElementRow = i;
                        maxElementColumn = j;
                    }
                }
            }
            Console.WriteLine($"{matrix[maxElementRow,maxElementColumn]} {matrix[maxElementRow, maxElementColumn+1]}");
            Console.WriteLine($"{matrix[maxElementRow+1,maxElementColumn]} {matrix[maxElementRow+1, maxElementColumn+1]}");
            Console.WriteLine(maxSum);
        }

        private static int[] ReadMatrix()
        {
            return Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        }
    }
}
//5.Square with Maximum Sum
//Create a program that read a matrix from console. Then find biggest sum of 2x2 submatrix and print it to console.
//On first line you will get matrix sizes in format rows, columns.
//One next rows lines you will get elements for each column separated with coma.
//Print biggest top-left square, which you find and sum of its elements.
//Examples
//Input	
//3, 6
//7, 1, 3, 3, 2, 1
//1, 3, 9, 8, 5, 6
//4, 6, 7, 9, 1, 0	
//
//Output
//9 8
//7 9
//33
//
//Input
//2, 4
//10, 11, 12, 13
//14, 15, 16, 17	
//
//Output
//12 13 
//16 17 
//58
//
//Hints
//•	Think about IndexOutOfRangeException()
//•	If you find more than one max square, print the top-left one
